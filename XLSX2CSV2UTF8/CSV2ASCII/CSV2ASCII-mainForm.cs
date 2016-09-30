using CSV2ASCII.Classes;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace CSV2ASCII
{
    public partial class CSV2ASCII : MaterialSkin.Controls.MaterialForm
    {

        /// <summary>
        /// Private var to save the sourcedir
        /// </summary>
        private string @sourceDir;

        /// <summary>
        /// Private var to save the destDir
        /// </summary>
        private string @destDir;

        private bool checkFolders;

        public CSV2ASCII()
        {
            //Init the var with an empty string
            @sourceDir = string.Empty;

            //Init the var with an empty string
            @destDir = string.Empty;

            InitializeComponent();
        }

        /// <summary>
        /// Method used when convert button is used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method when the browse button is used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseBtn_Click(object sender, EventArgs e)
        {
            //Initiate a new browserdialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Set the description
            fbd.Description = "Selectionnez le dossier où se trouvent les fichiers .xlsx:";

            //Check if the user pressed ok
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Set the source dir
                @sourceDir = fbd.SelectedPath + "\\";
                                
                //Fill the textbox with the dir
                srcDirectoryFolder.Text = @sourceDir;

                //Check if check box checked
                if (!destCheckB.Checked)
                {
                    //Enable the convert button
                    convertBtn.Enabled = true;
                }
                else
                {
                    //Check if we already have a correct sourcedir
                    if (@sourceDir != string.Empty && @destDir != string.Empty)
                    {
                        //Enable the button
                        convertBtn.Enabled = true;
                    }
                }

                //Exit the method
                return;
            }

            //Check if we already have a correct sourcedir
            if (@sourceDir != string.Empty && !destCheckB.Checked)
            {
                //Enable the button
                convertBtn.Enabled = true;
            }
            else
            {
                //Disable the button
                convertBtn.Enabled = false;
            }
        }

        private void destCheckB_CheckedChanged(object sender, EventArgs e)
        {
            if (destCheckB.Checked)
            {
                destFolderBrowseBtn.Enabled = true;

                //CheckFolders to false
                checkFolders = false;

                //Disable the convert button
                convertBtn.Enabled = false;
            }
            else
            {
                destFolderBrowseBtn.Enabled = false;
                destFolderTxt.Text = "";

                //CheckFolders to true
                checkFolders = true;

                if (sourceDir == String.Empty || sourceDir == "")
                {
                    convertBtn.Enabled = false;
                }
                else
                {
                    //Enable the convert button
                    convertBtn.Enabled = true;
                }
            }
        }

        private void destFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            //Initiate a new browserdialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Set the description
            fbd.Description = "Selectionnez le dossier où se trouvent les fichiers .xlsx:";

            //Check if the user pressed ok
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Set the source dir
                @destDir = fbd.SelectedPath + "\\";

                //Check if we already have a correct destdir
                if (@destDir != string.Empty && @sourceDir != string.Empty)
                {
                    //Enable the button
                    convertBtn.Enabled = true;
                }

                //Fill the textbox with the dir
                destFolderTxt.Text = @destDir;

                //Exit the method
                return;
            }

            //Check if we already have a correct destdir
            if (@destDir != string.Empty && @sourceDir != string.Empty)
            {
                //Enable the button
                convertBtn.Enabled = true;
            }
            else
            {
                //Disable the button
                convertBtn.Enabled = false;
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            //Check destination dir
            if (@destDir == string.Empty || @destDir == "")
            {
                @destDir = @sourceDir;
            }

            //Initiate a new folder class
            Folder folder = new Folder(sourceDir);

            //Set the encoding to ANSI
            Encoding ANSI = Encoding.GetEncoding(1252);

            //Show the convert lab
            convertLab.Visible = true;

            //Check each .xlsx file and convert it to csv
            Parallel.ForEach(folder.getEXCELs(), fileName =>
            {
                //Complete filepath to the xlsx
                string @filePath = sourceDir + fileName + ".xlsx";

                //Open an excel process
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

                //Disable overwriting alerts
                app.DisplayAlerts = false;

                //Link the xlsx file to the excel workbook
                Workbook wb = app.Workbooks.Open(@filePath);

                //Save the file as a csv and check local to true to delimite with ";"
                wb.SaveAs(@destDir + fileName + ".csv", XlFileFormat.xlCSVWindows, Local: true);

                //Close the workbook
                wb.Close(false);

                //Close the process
                app.Quit();
            });

            //Check each csv file and convert it
            Parallel.ForEach(folder.getCSVs(), fileName =>
            {
                //Complete filepath to the csv file
                string @filePath = sourceDir + fileName + ".csv";

                //Read the file in ANSI and delete the delimiters ";"
                string removedDelimiterFile = File.ReadAllText(filePath, Encoding.Default).Replace(';', ' ');

                //Set an array of byte for the ANSI file bytes
                byte[] ansiBytes = ANSI.GetBytes(removedDelimiterFile);

                //Set an array for the UTF8 encoded file and convert to UTF8
                byte[] utf8Bytes = Encoding.Convert(ANSI, Encoding.UTF8, ansiBytes);

                //Fill the string with the UTF8 encoded text
                string utf8String = Encoding.UTF8.GetString(utf8Bytes);

                //Create the text file encode in UTF8
                File.WriteAllText(@destDir + fileName + ".txt", utf8String);
            });

            //Hide the convert lab
            convertLab.Visible = false;

            //Messagebox success
            MessageBox.Show("La conversion s'est bien déroulée !");
            Process.Start("explorer.exe", @destDir);

            //Disable the button
            convertBtn.Enabled = false;


            //Uncheck checkbox
            destCheckB.Checked = false;

            //Reset the source dir var
            @sourceDir = string.Empty;

            //Reset dest dir var
            @destDir = string.Empty;

            //Clear the textboxes
            srcDirectoryFolder.Clear();
            destFolderTxt.Clear();
        }
    }
}
