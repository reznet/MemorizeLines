using MemorizeLines.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemorizeLines
{
    public partial class Form1 : Form
    {
        SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProjectFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
                Settings.Default.LastProjectPath = ProjectFolderTextBox.Text;
                Settings.Default.Save();
                
                ReloadFiles();
            }
        }

        private void ReloadFiles()
        {
            FilesListBox.Items.Clear();
            FilesListBox.BeginUpdate();
            foreach (var file in Directory.GetFiles(ProjectFolderTextBox.Text, "*.wav"))
            {
                FilesListBox.Items.Add(file);
            }
            FilesListBox.EndUpdate();
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayCurrentFile();
        }

        private void PlayCurrentFile()
        {
            string file = (string)FilesListBox.SelectedItem;

            if (file != null)
            {
                if(soundPlayer != null)
                {
                    soundPlayer.Stop();
                }
                soundPlayer = new SoundPlayer(file);
                soundPlayer.Play();
            }
        }

        private void StopCurrentFile()
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
        }

        private void RecordNewSoundButton_Click(object sender, EventArgs e)
        {
            var maxFileNumber = Directory.GetFiles(ProjectFolderTextBox.Text, "*.wav").Max(s => Convert.ToInt32(Path.GetFileNameWithoutExtension(s)));
            int result = 0;

            result = mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            if (result != 0)
            {
                StringBuilder sb = new StringBuilder(256);
                mciGetErrorString(result, sb, 256);
                throw new Exception(sb.ToString());
            }
            result = mciSendString("record recsound", "", 0, 0);
            if (result != 0)
            {
                StringBuilder sb = new StringBuilder(256);
                mciGetErrorString(result, sb, 256);
                throw new Exception(sb.ToString());
            }

            MessageBox.Show("Press OK when done recording.");

            int newFileNumber = maxFileNumber + 1;

            string outputPath = Path.Combine(ProjectFolderTextBox.Text, newFileNumber.ToString("00") + ".wav");

            result = mciSendString("save recsound \"" + outputPath + "\"", "", 0, 0);
            if (result != 0)
            {
                StringBuilder sb = new StringBuilder(256);
                mciGetErrorString(result, sb, 256);
                Console.WriteLine(sb.ToString());
            }
            result = mciSendString("close recsound ", "", 0, 0);
            if (result != 0)
            {
                StringBuilder sb = new StringBuilder(256);
                mciGetErrorString(result, sb, 256);
                Console.WriteLine(sb.ToString());
            }

            FilesListBox.Items.Add(outputPath);
        }

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        [DllImport("winmm.dll")]
        private static extern Int32 mciGetErrorString(Int32 errorCode, StringBuilder errorText, Int32 errorTextSize);

        private void FilesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (FilesListBox.SelectedItem != null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    File.Delete((string)FilesListBox.SelectedItem);
                }
                else if (e.KeyCode == Keys.Space)
                {
                    PlayCurrentFile();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    StopCurrentFile();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Settings.Default.LastProjectPath))
            {
                ProjectFolderTextBox.Text = Settings.Default.LastProjectPath;
                ReloadFiles();
            }
        }
    }
}
