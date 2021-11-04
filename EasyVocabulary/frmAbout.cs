using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyVocabulary
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/nguyen.van.phuc.1990");  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\System\BakSound.mp3";
        }
    }
}
