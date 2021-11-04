using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace EasyVocabulary
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        ucListenAndWrite ucLr;
        ucAdmin ucAd;
        ucHome ucH;
        ucEnglishVocabulary ucEng;
        ucAdmin ucSett;

        public void loadusercontrol(Panel chua, UserControl obj)
        {
            Panel pan = new Panel();
            pan = chua;
            pan.Controls.Clear();
            pan.Controls.Add(obj);
            obj.Dock = DockStyle.Fill;
        }
        private void butHome_Click(object sender, EventArgs e)
        {
            if (ucH == null)
            {
                ucH = new ucHome();
                loadusercontrol(panel1, ucH);
            }
            else
            {
                loadusercontrol(panel1, ucH);
            }
        }

        private void butLearnVo_Click(object sender, EventArgs e)
        {
            if (ucEng == null)
            {
                ucEng = new ucEnglishVocabulary();
                loadusercontrol(panel1, ucEng);
            }
            else
            {
                loadusercontrol(panel1, ucEng);
            }
        }

        private void buttonListenAndWrite_Click(object sender, EventArgs e)
        {
            if (ucLr == null)
            {
                ucLr = new ucListenAndWrite();
                loadusercontrol(panel1, ucLr);
            }
            else
            {
                loadusercontrol(panel1, ucLr);
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            if (ucSett == null)
            {
                ucSett = new ucAdmin();
                loadusercontrol(panel1, ucSett);
            }
            else
            {
                loadusercontrol(panel1, ucSett);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            //Show form About len
            frmAbout frmAb = new frmAbout();
            frmAb.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmInformation frmInfor = new frmInformation();
            //frmInfor.ShowDialog();
            if (ucH == null)
            {
                ucH = new ucHome();
                loadusercontrol(panel1, ucH);
            }
            else
            {
                loadusercontrol(panel1, ucH);
            }
           
        }
    }
}
