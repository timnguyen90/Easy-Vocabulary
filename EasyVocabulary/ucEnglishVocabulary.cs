using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EasyVocabulary
{
    public partial class ucEnglishVocabulary : UserControl
    {
        public ucEnglishVocabulary()
        {
            InitializeComponent();
        }

        GroupMain clssMain = new GroupMain();
        GroupChild clssChild = new GroupChild();
        WordProcess clssWp = new WordProcess();
        VocalWord clssVocabu = new VocalWord();
        DataTable Dataword = null;
        int Count = 0;
       
        private void ucEnglishVocabulary_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxBoThe.DataSource = clssMain.SelectAllGroupMain();
                comboBoxBoThe.DisplayMember = "Name";
                comboBoxBoThe.ValueMember = "Id";
            }
            catch (Exception)
            {
            } 
        }

        private string StringProcess(string str,int type) 
        {

            return "";
        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int MaxRow = Dataword.Rows.Count;
                    if (Count < MaxRow)
                    {
                        //An Nghia cua tu
                        webBrowserMean.Visible = false;
                        webBrowserEngtoEng.Visible = false;

                        string WordVo = Dataword.Rows[Count]["Vocabulary"].ToString().Trim();
                        //Thuc hien Load du lieu Truoc Khi Biet Dap An
                        //Hien thi Id len txtId
                        txtId.Text = Dataword.Rows[Count]["Id"].ToString();
                        //Hien thi count
                        txtLevel.Text = Dataword.Rows[Count]["Dem"].ToString();
                        //Load doc tu vung
                        //XEM CO BAT CHU NANG GOI Y HAY KHONG ,NEU CO THI XU LY GOI Y
                        axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\Sound\" + Dataword.Rows[Count]["Audio"].ToString();
                        axWindowsMediaPlayerDocTu.Ctlcontrols.play();
                        //Load hinh anh minh hoa
                        if (Dataword.Rows[Count]["Picture"].ToString() != "")
                        {
                            pictureBoxAnh.Image = Image.FromFile(Application.StartupPath + @"\Pictures\" + Dataword.Rows[Count]["Picture"].ToString());
                        }
                        //Load Nghia VietNamese cua tu
                        webBrowserMean.DocumentText = Dataword.Rows[Count]["Mean"].ToString();
                        //Load Nghia English cua tu
                        webBrowserEngtoEng.DocumentText = Dataword.Rows[Count]["EngMean"].ToString();
                        //Hien thi tuy chon tabcontrol tieng anh hay tieng viet
                        if (radioButtonEngVi.Checked == true)
                        {
                            tabControl2.SelectedTab = tabPage3;
                        }
                        if (radioButtonEngEng.Checked == true)
                        {
                            tabControl2.SelectedTab = tabPage4;
                        }
                        //Xoa trang lable tu vung
                        lblWord.Text = "";
                        //Xoa trong vi du
                        webBrowserExample.DocumentText = "<p></p>";
                        txtWord.Focus();
                        //Gan chuoi trong textbox nguoi dung nhap vao
                        string WordInput = txtWord.Text.Trim();
                        if (txtWord.Text != "")
                        {
                            //Thuc hien so sanh chuoi trong tu dien va chuoi do nguoi nhap nhap vao
                            if (String.Compare(WordVo, WordInput, true) == 0)
                            {
                                //Dung tu vung
                                axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\System\yeah.mp3";
                                //Thuc hien load nghia va vi du
                                txtWord.Clear();
                                //Thuc hien hien thi du lieu sau khi tra loi
                                //Hien Thi Tu Vung
                                lblWord.Text = Dataword.Rows[Count]["Vocabulary"].ToString().Trim().ToUpper();
                                //Hien Thi Am thanh
                                //Hien Thi Hinh Anh
                                if (Dataword.Rows[Count]["Picture"].ToString() != "")
                                {
                                    pictureBoxAnh.Image = Image.FromFile(Application.StartupPath + @"\Pictures\" + Dataword.Rows[Count]["Picture"].ToString());
                                }
                                //Hien thi tuy chon tabcontrol tieng anh hay tieng viet
                                if (radioButtonEngVi.Checked == true)
                                {
                                    tabControl2.SelectedTab = tabPage3;
                                }
                                if (radioButtonEngEng.Checked == true)
                                {
                                    tabControl2.SelectedTab = tabPage4;
                                }
                                //Hien Thi Vi Du
                                webBrowserExample.DocumentText = Dataword.Rows[Count]["Extend"].ToString();
                                //Hien Thi Nghia
                                webBrowserMean.Visible = true;
                                webBrowserMean.DocumentText = Dataword.Rows[Count]["Mean"].ToString();
                                //Load Nghia English cua tu
                                webBrowserEngtoEng.Visible = true;
                                webBrowserEngtoEng.DocumentText = Dataword.Rows[Count]["EngMean"].ToString();
                                
                            }
                            else
                            {
                                axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\System\Wrong.mp3";
                                //Sai tu vung
                                txtWord.Clear();
                                //Thuc hien hien thi du lieu sau khi tra loi
                                //Hien Thi Tu Vung
                                lblWord.Text = Dataword.Rows[Count]["Vocabulary"].ToString().Trim().ToUpper();
                                //Hien Thi Hinh Anh
                                if (Dataword.Rows[Count]["Picture"].ToString() != "")
                                {
                                    pictureBoxAnh.Image = Image.FromFile(Application.StartupPath + @"\Pictures\" + Dataword.Rows[Count]["Picture"].ToString());
                                }
                                //Hien thi tuy chon tabcontrol tieng anh hay tieng viet
                                if (radioButtonEngVi.Checked == true)
                                {
                                    tabControl2.SelectedTab = tabPage3;
                                }
                                if (radioButtonEngEng.Checked == true)
                                {
                                    tabControl2.SelectedTab = tabPage4;
                                }
                                //Hien Thi Vi Du
                                webBrowserExample.DocumentText = Dataword.Rows[Count]["Extend"].ToString();
                                //Hien Thi Nghia
                                webBrowserMean.Visible = true;
                                webBrowserMean.DocumentText = Dataword.Rows[Count]["Mean"].ToString();
                                //Load Nghia English cua tu
                                webBrowserEngtoEng.Visible = true;
                                webBrowserEngtoEng.DocumentText = Dataword.Rows[Count]["EngMean"].ToString();

                            }
                            //Tang bien diem toi tu tiep theo
                            Count++;

                        }
                    }
                    else//Lap lai
                    {
                        if (checkBoxLapLai.Checked==true&&Count>=MaxRow)
                        {
                            Dataword = clssWp.SelectAllByIdChild(comboBoxNhomTu.SelectedValue.ToString());
                            Count = 0;
                            string WordVo = Dataword.Rows[Count]["Vocabulary"].ToString().Trim();
                            //Thuc hien Load du lieu Truoc Khi Biet Dap An
                            //KIEM TRA GOI Y CO BAT HAY  KHONG NEU CO THI HIEN THI GOI Y
                            axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\Sound\" + Dataword.Rows[Count]["Audio"].ToString();
                            axWindowsMediaPlayerDocTu.Ctlcontrols.play();
                            //Load anh minh hoa cua tu
                            if (Dataword.Rows[Count]["Picture"].ToString()!="")
                            {
                                pictureBoxAnh.Image = Image.FromFile(Application.StartupPath + @"\Pictures\" + Dataword.Rows[Count]["Picture"].ToString());
                            }
                            //Load nghia cua tu
                            webBrowserMean.DocumentText = Dataword.Rows[Count]["Mean"].ToString();
                            //Load Nghia English cua tu
                            webBrowserEngtoEng.DocumentText = Dataword.Rows[Count]["EngMean"].ToString();
                            //Hien thi Id len txtId
                            txtId.Text = Dataword.Rows[Count]["Id"].ToString();
                            //Hien thi count
                            txtLevel.Text = Dataword.Rows[Count]["Dem"].ToString();
                            //Xoa trang lable tu vung
                            lblWord.Text = "";
                            //Xoa trong vi du
                            webBrowserExample.DocumentText = "<p></p>";
                            //Hien thi tuy chon tabcontrol tieng anh hay tieng viet
                            if (radioButtonEngVi.Checked == true)
                            {
                                tabControl2.SelectedTab = tabPage3;
                            }
                            if (radioButtonEngEng.Checked == true)
                            {
                                tabControl2.SelectedTab = tabPage4;
                            }
                            //Focus vo textbox nhap lieu tu vung
                            txtWord.Focus();
                        }
                    }
                    //Tat am thanh ding khi nhan phim Enter
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                   
                }
            }
            catch (Exception)
            {
            }
        }

        private void comboBoxBoThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Thuc hien load du lieu cho combobox child
                comboBoxNhomTu.DataSource = clssWp.GetGroupWord(comboBoxBoThe.SelectedValue.ToString());
                comboBoxNhomTu.DisplayMember = "NameChild";
                comboBoxNhomTu.ValueMember = "IdChild";
            }
            catch (Exception)
            {
            }
        }

        private void comboBoxNhomTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //select database
                webBrowserEngtoEng.Visible = false;
                webBrowserMean.Visible = false;
                Dataword = clssWp.SelectAllByIdChild(comboBoxNhomTu.SelectedValue.ToString());
                Count = 0;
                 int MaxRow = Dataword.Rows.Count;
                 if (Count < MaxRow)
                 {
                     string WordVo = Dataword.Rows[Count]["Vocabulary"].ToString().Trim();
                     //Thuc hien Load du lieu Truoc Khi Biet Dap An
                     //Doc TU
                     //KIEM TRA XEM CO BAT CHUC NANG GOI Y HAY KHONG , NEU CO HIEN THI GOI Y
                     axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\Sound\" + Dataword.Rows[Count]["Audio"].ToString();
                     axWindowsMediaPlayerDocTu.Ctlcontrols.play();
                     //Load anh minh hoa cua tu
                     if (Dataword.Rows[Count]["Picture"].ToString() != "")
                     {
                         pictureBoxAnh.Image = Image.FromFile(Application.StartupPath + @"\Pictures\" + Dataword.Rows[Count]["Picture"].ToString());
                     }
                     //Load nghia cua tu
                     webBrowserMean.DocumentText = Dataword.Rows[Count]["Mean"].ToString();
                     //Load Nghia English cua tu
                     webBrowserEngtoEng.DocumentText = Dataword.Rows[Count]["EngMean"].ToString();
                     //Hien thi Id len txtId
                     txtId.Text = Dataword.Rows[Count]["Id"].ToString();
                     //Hien thi count
                     txtLevel.Text = Dataword.Rows[Count]["Dem"].ToString();
                     //Xoa trang lable tu vung
                     lblWord.Text = "";
                     //Xoa trong vi du
                     webBrowserExample.DocumentText = "<p></p>";
                     //Hien thi tuy chon tabcontrol tieng anh hay tieng viet
                     if (radioButtonEngVi.Checked == true)
                     {
                         tabControl2.SelectedTab = tabPage3;
                     }
                     if (radioButtonEngEng.Checked == true)
                     {
                         tabControl2.SelectedTab = tabPage4;
                     }
                     //Focus vo textbox nhap lieu tu vung
                     txtWord.Focus();
                 }
            }
            catch (Exception)
            { }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            try
            {
                //Phat lai am thanh tu vung
                if (Count >= Dataword.Rows.Count - 1)
                {
                    axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\Sound\" + Dataword.Rows[Count - 1]["Audio"].ToString();
                    axWindowsMediaPlayerDocTu.Ctlcontrols.play();
                }
                else
                {
                    axWindowsMediaPlayerDocTu.URL = Application.StartupPath + @"\Sound\" + Dataword.Rows[Count-1]["Audio"].ToString();
                    axWindowsMediaPlayerDocTu.Ctlcontrols.play();
                }
                
            }
            catch (Exception)
            {
            }
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtLevel.Text == "")
                {
                    clssVocabu.Dem = 1;
                    clssVocabu.Id = int.Parse(txtId.Text);
                }
                else
                {
                    clssVocabu.Dem = int.Parse(txtLevel.Text.ToString()) + 1;
                    clssVocabu.Id = int.Parse(txtId.Text);
                }
                
                clssVocabu.UpdateLevel();
            }
            catch (Exception)
            {
            }
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtLevel.Text == "")
                {
                    clssVocabu.Dem = 0;
                    clssVocabu.Id = int.Parse(txtId.Text);
                }
                else
                {
                    clssVocabu.Dem = int.Parse(txtLevel.Text.ToString()) - 2;
                    clssVocabu.Id = int.Parse(txtId.Text);
                }

                clssVocabu.UpdateLevel();
            }
            catch (Exception)
            {
            }
        }

    }
}
