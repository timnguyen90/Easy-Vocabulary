using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyVocabulary
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }
        public delegate void GetVal(string val);
        public GetVal Mygetval;
        private void frmEditor_Load(object sender, EventArgs e)
        {
            try
            {
                editor1.DocumentText = Program.strEdit;
            }
            catch (Exception)
            {
             
            }
            
        }

        private void frmEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (Mygetval != null)
                {
                    Mygetval(editor1.Html.ToString());
                }   
            }
            catch (Exception)
            {
            }
           
        }

    }
}
