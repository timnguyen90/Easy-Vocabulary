using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EasyVocabulary
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }

        GroupMain clssGroupMain = new GroupMain();
        GroupChild clssGroupChild = new GroupChild();
        VocalWord clssVoca = new VocalWord();
        ListenAndWrite clssListenAWrite = new ListenAndWrite();
        int InsertFlagDeck = 0, UpdateFlagDeck = 0;

        string AudioName = "", PictureName = "",VideoName="";
       
        private void ucAdmin_Load(object sender, EventArgs e)
        {
            //dataGridViewBoThe
            dataGridViewBoThe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBoThe.DataSource = clssGroupMain.SelectAllGroupMain();
            //dataGridViewNhomTu
            dataGridViewNhomTu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhomTu.DataSource = clssGroupChild.SelectAllGroupChild();
            //dataGridViewTuVung
            dataGridViewTuVung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTuVung.DataSource = clssVoca.SelectAllVocaWord();
            //ComboboxFill
            comboBoxFill.DataSource = clssGroupChild.SelectAllGroupChild();
            comboBoxFill.DisplayMember = "Name";
            comboBoxFill.ValueMember = "Id";
            //Load Listen And Write
            //dataGridViewListenAndWrite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewListenAndWrite.DataSource = clssListenAWrite.SelectAll();
        }

        #region GroupMain
        private void buttonThemThe_Click(object sender, EventArgs e)
        {
            InsertFlagDeck = 1;
            textBoxTenBoThe.Enabled = true;
            textBoxTenBoThe.Clear();
            comboBoxIdUser.Enabled = true;
            comboBoxIdUser.Text = "1";
            buttonLuuThe.Enabled = true;
            buttonSuaThe.Enabled = false;
        }
        private void buttonSuaThe_Click(object sender, EventArgs e)
        {
            UpdateFlagDeck = 1;
            textBoxTenBoThe.Enabled = true;
            comboBoxIdUser.Enabled = true;
            buttonLuuThe.Enabled = true;
            buttonThemThe.Enabled = false;
        }
        private void buttonLuuThe_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert Data
                if (InsertFlagDeck != 0)
                {
                    clssGroupMain.Name = textBoxTenBoThe.Text;
                    clssGroupMain.IdUser = int.Parse(comboBoxIdUser.Text);
                    if (clssGroupMain.Insert() != 0)
                    {
                        dataGridViewBoThe.DataSource = clssGroupMain.SelectAllGroupMain();
                    }
                }
                if (UpdateFlagDeck != 0)
                {
                    //Update Data
                    clssGroupMain.Id = int.Parse(txtTemp.Text);
                    clssGroupMain.Name = textBoxTenBoThe.Text;
                    clssGroupMain.IdUser = int.Parse(comboBoxIdUser.Text);
                    if (clssGroupMain.Update() != 0)
                    {
                        dataGridViewBoThe.DataSource = clssGroupMain.SelectAllGroupMain();

                    }
                }
                CancelForDeck();
            }
            catch (Exception)
            {
            }
        }
        private void CancelForDeck()
        {
            InsertFlagDeck = 0;
            UpdateFlagDeck = 0;
            textBoxTenBoThe.Enabled = false;
            comboBoxIdUser.Enabled = false;
            buttonLuuThe.Enabled = false;
            buttonSuaThe.Enabled = true;
            buttonLuuThe.Enabled = true;
            buttonThemThe.Enabled = true;
        }
        private void buttonHuyBoThe_Click(object sender, EventArgs e)
        {
            CancelForDeck();
        }
        private void dataGridViewBoThe_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridViewBoThe.SelectedRows[0];
                txtTemp.Text = dr.Cells[0].Value.ToString();
                textBoxTenBoThe.Text = dr.Cells[1].Value.ToString();
                comboBoxIdUser.Text = dr.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
            }
        }
        #endregion

        #region GroupChild
        private void buttonTheNTu_Click(object sender, EventArgs e)
        {
            InsertFlagDeck = 1;
            textBoxTenNhomTu.Enabled = true;
            textBoxTenNhomTu.Clear();
            comboBoxIdBoThe.Enabled = true;
            comboBoxIdBoThe.Text = "";
            buttonLuuNTu.Enabled = true;
            buttonSuaNTu.Enabled = false;
            comboBoxIdBoThe.DataSource = clssGroupMain.SelectAllGroupMain();
            comboBoxIdBoThe.DisplayMember = "Name";
            comboBoxIdBoThe.ValueMember = "Id";

        }
       
        private void buttonSuaNTu_Click(object sender, EventArgs e)
        {
            UpdateFlagDeck = 1;
            textBoxTenNhomTu.Enabled = true;
            comboBoxIdBoThe.Enabled = true;
            buttonLuuNTu.Enabled = true;
            buttonTheNTu.Enabled = false;
            comboBoxIdBoThe.DataSource = clssGroupMain.SelectAllGroupMain();
            comboBoxIdBoThe.DisplayMember = "Name";
            comboBoxIdBoThe.ValueMember = "Id";
        }
       
        private void buttonLuuNTu_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertFlagDeck != 0)
                {
                    clssGroupChild.Name = textBoxTenNhomTu.Text;
                    clssGroupChild.IdGroupMain = int.Parse(comboBoxIdBoThe.SelectedValue.ToString());
                    if (clssGroupChild.Insert() != 0)
                    {
                        dataGridViewNhomTu.DataSource = clssGroupChild.SelectAllGroupChild();
                    }
                }
                if (UpdateFlagDeck != 0)
                {
                    clssGroupChild.Id = int.Parse(txtTemp2.Text);
                    clssGroupChild.Name = textBoxTenNhomTu.Text;
                    clssGroupChild.IdGroupMain = int.Parse(comboBoxIdBoThe.SelectedValue.ToString());
                    if (clssGroupChild.Update() != 0)
                    {
                        dataGridViewNhomTu.DataSource = clssGroupChild.SelectAllGroupChild();
                    }
                }
                CancelForGroupChild();
            }
            catch (Exception)
            {
            }

        }
        
        private void CancelForGroupChild()
        {
            textBoxTenNhomTu.Enabled = false;
            comboBoxIdBoThe.Enabled = false;
            buttonLuuNTu.Enabled = false;
            buttonTheNTu.Enabled = true;
            buttonSuaNTu.Enabled = true;
            InsertFlagDeck = 0;
            UpdateFlagDeck = 0;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            CancelForGroupChild();
        }
        
        private void dataGridViewNhomTu_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridViewNhomTu.SelectedRows[0];
                textBoxTenNhomTu.Text = dr.Cells[2].Value.ToString();
                comboBoxIdBoThe.Text = dr.Cells[1].Value.ToString();
                txtTemp2.Text = dr.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
            }
            
        }

        private void comboBoxGroupChild_Click(object sender, EventArgs e)
        {
            comboBoxGroupChild.DataSource = clssGroupChild.SelectAllGroupChild();
            comboBoxGroupChild.DisplayMember = "Name";
            comboBoxGroupChild.ValueMember = "Id";
        }
        #endregion

        #region Vocabulary

        private void txtMean_TextChanged(object sender, EventArgs e)
        {

        }

        public void GetValueForEx(string Val)
        {
            txtExample.Text = Val;
        }

        public void GetValueForMen(string val)
        {
            txtMean.Text = val;
        }
        
        public void GetValueFroEngtoEng(string val)
        {
            txtEnglishEnglish.Text = val;
        }

        private void CancelVoca()
        {
            btnLuu.Enabled = false;
            InsertFlagDeck = 0;
            UpdateFlagDeck = 0;
            comboBoxGroupChild.DataSource = null;
        }
       
        private void txtMean_Click(object sender, EventArgs e)
        {
            Program.strEdit = txtMean.Text;
            frmEditor frmEdit = new frmEditor();
            frmEdit.Mygetval = new frmEditor.GetVal(GetValueForMen);
            frmEdit.Show();
        }

        private void txtExample_Click(object sender, EventArgs e)
        {
            Program.strEdit = txtExample.Text;
            frmEditor frmEdit = new frmEditor();
            frmEdit.Mygetval = new frmEditor.GetVal(GetValueForEx);
            frmEdit.Show();
        }

        private void txtAudio_Click(object sender, EventArgs e)
        {
          
        }

        private void txtPicture_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUploadAudio_Click(object sender, EventArgs e)
        {
            //Get Audio file name
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Audio file|*.mp3|all file|*.*";
            dlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + @"\Sound";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                AudioName = fileName;
                string[] xxx = AudioName.Split('\\');
                txtAudio.Text = xxx[xxx.Length - 1];

            }

        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            //Get Picture file name
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + @"\Pictures";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = dlg.FileName;
                PictureName = fileName;
                string[] xxx = PictureName.Split('\\');
                txtPicture.Text = xxx[xxx.Length - 1];

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtWord.ReadOnly = false;
            txtWord.Clear();
            txtMean.Clear();
            txtExample.Clear();
            txtAudio.Clear();
            txtPicture.Clear();
            //comboBoxGroupChild.DataSource = clssGroupChild.SelectAllGroupChild();
            //comboBoxGroupChild.DisplayMember = "Name";
            //comboBoxGroupChild.ValueMember = "Id";
            InsertFlagDeck = 1;
            UpdateFlagDeck = 0;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            InsertFlagDeck = 0;
            UpdateFlagDeck = 1;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtWord.ReadOnly = false;
            //comboBoxGroupChild.DataSource = clssGroupChild.SelectAllGroupChild();
            //comboBoxGroupChild.DisplayMember = "Name";
            //comboBoxGroupChild.ValueMember = "Id";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert Data
                if (InsertFlagDeck != 0)
                {
                    clssVoca.Vocabulary = txtWord.Text;
                    clssVoca.IdGroupChild = int.Parse(comboBoxGroupChild.SelectedValue.ToString());
                    clssVoca.Mean = txtMean.Text;
                    clssVoca.Picture = txtPicture.Text;
                    clssVoca.Audio = txtAudio.Text;
                    clssVoca.Extend = txtExample.Text;
                    clssVoca.EngMean = txtEnglishEnglish.Text;
                    if (clssVoca.Insert() != 0)
                    {
                        dataGridViewTuVung.DataSource = clssVoca.SelectAllVocaWord();
                    }
                }
                if (UpdateFlagDeck !=0)
                {
                    //Update Data
                    clssVoca.Id = int.Parse(textBox1.Text.ToString());
                    clssVoca.Vocabulary = txtWord.Text;
                    if (comboBoxGroupChild.SelectedValue!=null)
                    {
                        clssVoca.IdGroupChild = int.Parse(comboBoxGroupChild.SelectedValue.ToString());
                    }
                    else
                    {
                        clssVoca.IdGroupChild = int.Parse(comboBoxGroupChild.Text.ToString());
                    }     
                    clssVoca.Mean = txtMean.Text;
                    clssVoca.Picture = txtPicture.Text;
                    clssVoca.Audio = txtAudio.Text;
                    clssVoca.Extend = txtExample.Text;
                    clssVoca.EngMean = txtEnglishEnglish.Text;
                    if (clssVoca.Update() !=0)
                    {
                        dataGridViewTuVung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        if (comboBoxGroupChild.SelectedValue != null)
                        {
                            dataGridViewTuVung.DataSource = clssVoca.SelectWordByIdChild(comboBoxGroupChild.SelectedValue.ToString());
                        }
                        else
                        {
                            dataGridViewTuVung.DataSource = clssVoca.SelectWordByIdChild(comboBoxGroupChild.Text.ToString());
                        }     
                    }
                }
                    //Upload audiofile
                    FileInfo fi1 = new FileInfo(AudioName);
                    string[] x1 = AudioName.Split('\\');
                    string des1 = Application.StartupPath + @"\Sound\" + x1[x1.Length - 1];
                    fi1.CopyTo(des1);
                    txtAudio.Text = "Upload Successful !";
                    //Upload Picture file
                    FileInfo fi = new FileInfo(PictureName);
                    string[] xxx = PictureName.Split('\\');
                    string des = Application.StartupPath + @"\Pictures\" + xxx[xxx.Length - 1];
                    fi.CopyTo(des);
                    txtPicture.Text = "Upload Successful !";

                CancelVoca();
            }
            catch (Exception)
            {
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            CancelVoca();
        }

        private void dataGridViewTuVung_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridViewTuVung.SelectedRows[0];
                textBox1.Text = dr.Cells[0].Value.ToString();
                comboBoxGroupChild.Text = dr.Cells[1].Value.ToString();
                txtWord.Text = dr.Cells[2].Value.ToString();
                txtMean.Text = dr.Cells[3].Value.ToString();
                txtPicture.Text = dr.Cells[4].Value.ToString();
                txtAudio.Text = dr.Cells[5].Value.ToString();
                txtExample.Text = dr.Cells[6].Value.ToString();
                txtEnglishEnglish.Text = dr.Cells[7].Value.ToString();

            }
            catch (Exception)
            {
            }
        }

        private void txtEnglishEnglish_Click(object sender, EventArgs e)
        {
            Program.strEdit = txtEnglishEnglish.Text;
            frmEditor frmEdit = new frmEditor();
            frmEdit.Mygetval = new frmEditor.GetVal(GetValueFroEngtoEng);
            frmEdit.Show();
        }

        private void comboBoxFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Display data for dataGridViewTuVung
                //dataGridViewTuVung
                dataGridViewTuVung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewTuVung.DataSource = clssVoca.SelectWordByIdChild(comboBoxFill.SelectedValue.ToString());
            }
            catch (Exception)
            {
            }
        }

        #endregion

        #region Listen And Write
        //public void GetValueFroTxtTranscript(string val)
        //{
        //    txtTranscript.Text = val;
        //}

        //public void GetValueFroTxTranslate(string val)
        //{
        //    txtTranslate.Text = val;
        //}
        //private void CancelListenAndWriet()
        //{
        //    InsertFlagDeck = 0;
        //    UpdateFlagDeck = 0;
        //    txtName.Enabled = false;
        //    btnSave.Enabled = false;
        //}
        //private void txtTranscript_Click(object sender, EventArgs e)
        //{
        //    Program.strEdit = txtTranscript.Text;
        //    frmEditor frmEdit = new frmEditor();
        //    frmEdit.Mygetval = new frmEditor.GetVal(GetValueFroTxtTranscript);
        //    frmEdit.Show();
        //}

        //private void txtTranslate_Click(object sender, EventArgs e)
        //{
        //    Program.strEdit = txtTranslate.Text;
        //    frmEditor frmEdit = new frmEditor();
        //    frmEdit.Mygetval = new frmEditor.GetVal(GetValueFroTxTranslate);
        //    frmEdit.Show();
        //}

        //private void btnUpload_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory() + @"\Videos";
        //    dlg.Multiselect = false;
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        string fileName = dlg.FileName;
        //        AudioName = fileName;
        //        txtVideo.Text= fileName;

        //    }
        //}

        //private void btnNew_Click(object sender, EventArgs e)
        //{
        //    InsertFlagDeck = 1;
        //    txtName.Enabled = true;
        //    txtName.Clear();
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    UpdateFlagDeck = 1;
        //    txtName.Enabled = true;
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (InsertFlagDeck ==1)
        //        {
                    
        //            clssListenAWrite.Name = txtName.Text;
        //            clssListenAWrite.Transcript = txtTranscript.Text;
        //            clssListenAWrite.Translate = txtTranslate.Text;
        //            clssListenAWrite.Video = txtVideo.Text;
        //            if (clssListenAWrite.Insert()!=0)
        //            {
        //                dataGridViewListenAndWrite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //                dataGridViewListenAndWrite.DataSource = clssListenAWrite.SelectAll();
        //            }
        //        }
        //        if (UpdateFlagDeck ==1)
        //        {
        //            clssListenAWrite.Id = int.Parse(txtID.Text);
        //            clssListenAWrite.Name = txtName.Text;
        //            clssListenAWrite.Transcript = txtTranscript.Text;
        //            clssListenAWrite.Translate = txtTranslate.Text;
        //            clssListenAWrite.Video = txtVideo.Text;
        //            if (clssListenAWrite.Update()!=0)
        //            {
        //                dataGridViewListenAndWrite.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //                dataGridViewListenAndWrite.DataSource = clssListenAWrite.SelectAll();
        //            }
        //        }
        //        //Upload Video file
        //        FileInfo fi1 = new FileInfo(VideoName);
        //        string[] x1 = VideoName.Split('\\');
        //        string des1 = Application.StartupPath + @"\Videos\" + x1[x1.Length - 1];
        //        fi1.CopyTo(des1);
        //        txtVideo.Text = "Upload Successful !";
        //        CancelListenAndWriet();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //private void btmCancel_Click(object sender, EventArgs e)
        //{
        //    CancelListenAndWriet();
        //}

        //private void dataGridViewListenAndWrite_MouseClick(object sender, MouseEventArgs e)
        //{
        //    DataGridViewRow dr = dataGridViewListenAndWrite.SelectedRows[0];
        //    txtID.Text = dr.Cells[0].Value.ToString();
        //    txtName.Text = dr.Cells[1].Value.ToString();
        //    txtTranscript.Text = dr.Cells[2].Value.ToString();
        //    txtTranslate.Text = dr.Cells[3].Value.ToString();
        //    txtVideo.Text = dr.Cells[4].Value.ToString();
        //}
        #endregion
    }
}
