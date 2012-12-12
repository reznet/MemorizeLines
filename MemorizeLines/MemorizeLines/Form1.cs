using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemorizeLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProjectFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
                FilesListBox.Items.Clear();

                FilesListBox.BeginUpdate();
                foreach (var file in Directory.GetFiles(ProjectFolderTextBox.Text, "*.wav"))
                {
                    FilesListBox.Items.Add(file);
                }
                FilesListBox.EndUpdate();
            }
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string file = (string)FilesListBox.SelectedItem;

            if (file != null)
            {
                SoundPlayer soundPlayer = new SoundPlayer(file);
                soundPlayer.Play();
            }
        }
    }
}
