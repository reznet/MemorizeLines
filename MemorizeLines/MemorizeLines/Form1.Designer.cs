namespace MemorizeLines
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.RecordNewSoundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Folder:";
            // 
            // ProjectFolderTextBox
            // 
            this.ProjectFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectFolderTextBox.Location = new System.Drawing.Point(95, 15);
            this.ProjectFolderTextBox.Name = "ProjectFolderTextBox";
            this.ProjectFolderTextBox.Size = new System.Drawing.Size(366, 20);
            this.ProjectFolderTextBox.TabIndex = 1;
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFolderButton.Location = new System.Drawing.Point(467, 13);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFolderButton.TabIndex = 2;
            this.SelectFolderButton.Text = "...";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(17, 80);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(525, 186);
            this.FilesListBox.TabIndex = 3;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            this.FilesListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilesListBox_KeyDown);
            // 
            // RecordNewSoundButton
            // 
            this.RecordNewSoundButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordNewSoundButton.Location = new System.Drawing.Point(467, 42);
            this.RecordNewSoundButton.Name = "RecordNewSoundButton";
            this.RecordNewSoundButton.Size = new System.Drawing.Size(75, 23);
            this.RecordNewSoundButton.TabIndex = 4;
            this.RecordNewSoundButton.Text = "Record";
            this.RecordNewSoundButton.UseVisualStyleBackColor = true;
            this.RecordNewSoundButton.Click += new System.EventHandler(this.RecordNewSoundButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 275);
            this.Controls.Add(this.RecordNewSoundButton);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.ProjectFolderTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Memorize Lines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProjectFolderTextBox;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Button RecordNewSoundButton;
    }
}

