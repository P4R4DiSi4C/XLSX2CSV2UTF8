using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV2ASCII.Classes
{
    public class Folder
    {
        private string sourceDir{get;set;}

        public Folder(string dir)
        {
            sourceDir = dir;
        }

        /*
        * Return an Array with the list of the CSV contained in a folder
        * Param : directory
        */
        public List<string> getCSVs()
        {
            string[] files;

            List<string> validFiles = new List<string>();

            files = Directory.GetFiles(sourceDir);

            foreach (string file in files)
            {
                // Process each file
                if (file.ToLower().Contains(".csv"))
                {
                    validFiles.Add(Path.GetFileNameWithoutExtension(file));
                }
            }

            //Return the array
            return validFiles;
        }



        /*
        * Return an Array with the list of the CSV contained in a folder
        * Param : Directory
        */
        public List<string> getEXCELs()
        {
            string[] files;
            List<string> validFiles = new List<string>();
            files = Directory.GetFiles(sourceDir);
            foreach (string file in files)
            {
                // Process each file
                if (file.ToLower().Contains(".xlsx"))
                {
                    validFiles.Add(Path.GetFileNameWithoutExtension(file));
                }
            }

            //Return the array
            return validFiles;
        }
    }
}
