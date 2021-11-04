using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyVocabulary
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/nguyen.van.phuc.1990");  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmInformation_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\System\BakSound.mp3";
        }
    }
}
