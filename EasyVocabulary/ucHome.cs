using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EasyVocabulary
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            webBrowserMain.Navigate(Application.StartupPath + @"\LNN\index.htm");
        }

        private void btnEeltsSimon_Click(object sender, EventArgs e)
        {
            webBrowserMain.Navigate("http://ielts-simon.com/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowserMain.Navigate(Application.StartupPath + @"\LNN\index.htm");
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowserMain.GoBack();
        }

        private void btnNex_Click(object sender, EventArgs e)
        {
            webBrowserMain.GoForward();
        }

        
    }
}
