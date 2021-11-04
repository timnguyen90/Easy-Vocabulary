using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EasyVocabulary
{
    public partial class ucListenAndWrite : UserControl
    {
        public ucListenAndWrite()
        {
            InitializeComponent();
        }

        private void ucListenAndWrite_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                panel1.Visible = true;

            }
            else
            {
                panel1.Visible = false;

            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                playToolStripMenuItem.Text = "Pause (F3)";
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                playToolStripMenuItem.Text = "Play (F3)";

            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + @"\Videos";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

       


    }
}
