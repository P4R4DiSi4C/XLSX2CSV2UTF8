namespace CSV2ASCII
{
    partial class CSV2ASCII
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSV2ASCII));
            this.srcDirectoryFolder = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.srcFolderLab = new MaterialSkin.Controls.MaterialLabel();
            this.browseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.destFolderBrowseBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.destFolderTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.destCheckB = new MaterialSkin.Controls.MaterialCheckBox();
            this.convertLab = new MaterialSkin.Controls.MaterialLabel();
            this.convertBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // srcDirectoryFolder
            // 
            this.srcDirectoryFolder.Depth = 0;
            this.srcDirectoryFolder.Enabled = false;
            this.srcDirectoryFolder.Hint = "";
            this.srcDirectoryFolder.Location = new System.Drawing.Point(16, 107);
            this.srcDirectoryFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.srcDirectoryFolder.Name = "srcDirectoryFolder";
            this.srcDirectoryFolder.PasswordChar = '\0';
            this.srcDirectoryFolder.SelectedText = "";
            this.srcDirectoryFolder.SelectionLength = 0;
            this.srcDirectoryFolder.SelectionStart = 0;
            this.srcDirectoryFolder.Size = new System.Drawing.Size(231, 23);
            this.srcDirectoryFolder.TabIndex = 3;
            this.srcDirectoryFolder.UseSystemPasswordChar = false;
            // 
            // srcFolderLab
            // 
            this.srcFolderLab.AutoSize = true;
            this.srcFolderLab.BackColor = System.Drawing.Color.Transparent;
            this.srcFolderLab.Depth = 0;
            this.srcFolderLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.srcFolderLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.srcFolderLab.Location = new System.Drawing.Point(12, 74);
            this.srcFolderLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.srcFolderLab.Name = "srcFolderLab";
            this.srcFolderLab.Size = new System.Drawing.Size(60, 19);
            this.srcFolderLab.TabIndex = 6;
            this.srcFolderLab.Text = "Source:";
            // 
            // browseBtn
            // 
            this.browseBtn.Depth = 0;
            this.browseBtn.Location = new System.Drawing.Point(253, 107);
            this.browseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Primary = true;
            this.browseBtn.Size = new System.Drawing.Size(23, 23);
            this.browseBtn.TabIndex = 8;
            this.browseBtn.Text = "...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // destFolderBrowseBtn
            // 
            this.destFolderBrowseBtn.Depth = 0;
            this.destFolderBrowseBtn.Enabled = false;
            this.destFolderBrowseBtn.Location = new System.Drawing.Point(253, 189);
            this.destFolderBrowseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.destFolderBrowseBtn.Name = "destFolderBrowseBtn";
            this.destFolderBrowseBtn.Primary = true;
            this.destFolderBrowseBtn.Size = new System.Drawing.Size(23, 23);
            this.destFolderBrowseBtn.TabIndex = 12;
            this.destFolderBrowseBtn.Text = "...";
            this.destFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.destFolderBrowseBtn.Click += new System.EventHandler(this.destFolderBrowseBtn_Click);
            // 
            // destFolderTxt
            // 
            this.destFolderTxt.Depth = 0;
            this.destFolderTxt.Enabled = false;
            this.destFolderTxt.Hint = "";
            this.destFolderTxt.Location = new System.Drawing.Point(12, 189);
            this.destFolderTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.destFolderTxt.Name = "destFolderTxt";
            this.destFolderTxt.PasswordChar = '\0';
            this.destFolderTxt.SelectedText = "";
            this.destFolderTxt.SelectionLength = 0;
            this.destFolderTxt.SelectionStart = 0;
            this.destFolderTxt.Size = new System.Drawing.Size(231, 23);
            this.destFolderTxt.TabIndex = 11;
            this.destFolderTxt.UseSystemPasswordChar = false;
            // 
            // destCheckB
            // 
            this.destCheckB.AutoSize = true;
            this.destCheckB.BackColor = System.Drawing.Color.White;
            this.destCheckB.Depth = 0;
            this.destCheckB.Font = new System.Drawing.Font("Roboto", 10F);
            this.destCheckB.Location = new System.Drawing.Point(15, 153);
            this.destCheckB.Margin = new System.Windows.Forms.Padding(0);
            this.destCheckB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.destCheckB.MouseState = MaterialSkin.MouseState.HOVER;
            this.destCheckB.Name = "destCheckB";
            this.destCheckB.Ripple = true;
            this.destCheckB.Size = new System.Drawing.Size(182, 30);
            this.destCheckB.TabIndex = 13;
            this.destCheckB.Text = "Destination personalisée";
            this.destCheckB.UseVisualStyleBackColor = false;
            this.destCheckB.CheckedChanged += new System.EventHandler(this.destCheckB_CheckedChanged);
            // 
            // convertLab
            // 
            this.convertLab.AutoSize = true;
            this.convertLab.BackColor = System.Drawing.Color.Transparent;
            this.convertLab.Depth = 0;
            this.convertLab.Font = new System.Drawing.Font("Roboto", 11F);
            this.convertLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.convertLab.Location = new System.Drawing.Point(12, 272);
            this.convertLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.convertLab.Name = "convertLab";
            this.convertLab.Size = new System.Drawing.Size(159, 19);
            this.convertLab.TabIndex = 14;
            this.convertLab.Text = "Conversion en cours...\r\n";
            this.convertLab.Visible = false;
            // 
            // convertBtn
            // 
            this.convertBtn.Depth = 0;
            this.convertBtn.Enabled = false;
            this.convertBtn.Location = new System.Drawing.Point(76, 223);
            this.convertBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Primary = true;
            this.convertBtn.Size = new System.Drawing.Size(129, 36);
            this.convertBtn.TabIndex = 15;
            this.convertBtn.Text = "CONVERTIR";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // CSV2ASCII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 301);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.convertLab);
            this.Controls.Add(this.destCheckB);
            this.Controls.Add(this.destFolderBrowseBtn);
            this.Controls.Add(this.destFolderTxt);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.srcFolderLab);
            this.Controls.Add(this.srcDirectoryFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CSV2ASCII";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV2ASCII";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField srcDirectoryFolder;
        private MaterialSkin.Controls.MaterialLabel srcFolderLab;
        private MaterialSkin.Controls.MaterialRaisedButton browseBtn;
        private MaterialSkin.Controls.MaterialRaisedButton destFolderBrowseBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField destFolderTxt;
        private MaterialSkin.Controls.MaterialCheckBox destCheckB;
        private MaterialSkin.Controls.MaterialLabel convertLab;
        private MaterialSkin.Controls.MaterialRaisedButton convertBtn;
    }
}

