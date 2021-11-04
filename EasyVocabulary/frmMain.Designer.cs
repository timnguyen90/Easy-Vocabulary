namespace EasyVocabulary
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imageListHome = new System.Windows.Forms.ImageList(this.components);
            this.imageListVocabulary = new System.Windows.Forms.ImageList(this.components);
            this.imageListBBC = new System.Windows.Forms.ImageList(this.components);
            this.imageListListenAndWrite = new System.Windows.Forms.ImageList(this.components);
            this.imageListSetting = new System.Windows.Forms.ImageList(this.components);
            this.imageListAbout = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonListenAndWrite = new System.Windows.Forms.Button();
            this.butLearnVo = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageListHome
            // 
            this.imageListHome.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListHome.ImageStream")));
            this.imageListHome.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListHome.Images.SetKeyName(0, "home-4-512.jpg");
            // 
            // imageListVocabulary
            // 
            this.imageListVocabulary.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListVocabulary.ImageStream")));
            this.imageListVocabulary.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListVocabulary.Images.SetKeyName(0, "books-512.png");
            // 
            // imageListBBC
            // 
            this.imageListBBC.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBBC.ImageStream")));
            this.imageListBBC.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBBC.Images.SetKeyName(0, "bbc.png");
            // 
            // imageListListenAndWrite
            // 
            this.imageListListenAndWrite.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListListenAndWrite.ImageStream")));
            this.imageListListenAndWrite.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListListenAndWrite.Images.SetKeyName(0, "write_icon.png");
            // 
            // imageListSetting
            // 
            this.imageListSetting.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSetting.ImageStream")));
            this.imageListSetting.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSetting.Images.SetKeyName(0, "settings-icon.png");
            // 
            // imageListAbout
            // 
            this.imageListAbout.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAbout.ImageStream")));
            this.imageListAbout.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAbout.Images.SetKeyName(0, "Live Messenger.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 614);
            this.panel1.TabIndex = 6;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.White;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.ImageIndex = 0;
            this.buttonAbout.ImageList = this.imageListAbout;
            this.buttonAbout.Location = new System.Drawing.Point(700, 0);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(119, 41);
            this.buttonAbout.TabIndex = 5;
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.White;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.ImageIndex = 0;
            this.buttonSetting.ImageList = this.imageListSetting;
            this.buttonSetting.Location = new System.Drawing.Point(525, 0);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(175, 41);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "Administrator";
            this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonListenAndWrite
            // 
            this.buttonListenAndWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.buttonListenAndWrite.FlatAppearance.BorderSize = 0;
            this.buttonListenAndWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonListenAndWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListenAndWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListenAndWrite.ForeColor = System.Drawing.Color.White;
            this.buttonListenAndWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListenAndWrite.ImageIndex = 0;
            this.buttonListenAndWrite.ImageList = this.imageListListenAndWrite;
            this.buttonListenAndWrite.Location = new System.Drawing.Point(330, 0);
            this.buttonListenAndWrite.Name = "buttonListenAndWrite";
            this.buttonListenAndWrite.Size = new System.Drawing.Size(195, 41);
            this.buttonListenAndWrite.TabIndex = 3;
            this.buttonListenAndWrite.Text = "Listen And Write";
            this.buttonListenAndWrite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonListenAndWrite.UseVisualStyleBackColor = false;
            this.buttonListenAndWrite.Click += new System.EventHandler(this.buttonListenAndWrite_Click);
            // 
            // butLearnVo
            // 
            this.butLearnVo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.butLearnVo.FlatAppearance.BorderSize = 0;
            this.butLearnVo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.butLearnVo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLearnVo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLearnVo.ForeColor = System.Drawing.Color.White;
            this.butLearnVo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLearnVo.ImageIndex = 0;
            this.butLearnVo.ImageList = this.imageListVocabulary;
            this.butLearnVo.Location = new System.Drawing.Point(115, 0);
            this.butLearnVo.Name = "butLearnVo";
            this.butLearnVo.Size = new System.Drawing.Size(215, 41);
            this.butLearnVo.TabIndex = 1;
            this.butLearnVo.Text = "English Vocabulary";
            this.butLearnVo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butLearnVo.UseVisualStyleBackColor = false;
            this.butLearnVo.Click += new System.EventHandler(this.butLearnVo_Click);
            // 
            // butHome
            // 
            this.butHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.butHome.FlatAppearance.BorderSize = 0;
            this.butHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.butHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHome.ForeColor = System.Drawing.Color.White;
            this.butHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butHome.ImageIndex = 0;
            this.butHome.ImageList = this.imageListHome;
            this.butHome.Location = new System.Drawing.Point(0, 0);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(115, 41);
            this.butHome.TabIndex = 0;
            this.butHome.Text = "Home";
            this.butHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butHome.UseVisualStyleBackColor = false;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.panel2.Location = new System.Drawing.Point(819, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 41);
            this.panel2.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.buttonListenAndWrite);
            this.Controls.Add(this.butLearnVo);
            this.Controls.Add(this.butHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy English Vocabulary 1.0 (Trial Version)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.ImageList imageListHome;
        private System.Windows.Forms.Button butLearnVo;
        private System.Windows.Forms.ImageList imageListVocabulary;
        private System.Windows.Forms.ImageList imageListBBC;
        private System.Windows.Forms.Button buttonListenAndWrite;
        private System.Windows.Forms.ImageList imageListListenAndWrite;
        private System.Windows.Forms.ImageList imageListSetting;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ImageList imageListAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Panel panel2;
    }
}

