﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

                FilesListBox.EndUpdate();
            }
        }
    }
}
