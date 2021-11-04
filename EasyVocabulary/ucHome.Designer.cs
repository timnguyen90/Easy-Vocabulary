namespace EasyVocabulary
{
    partial class ucHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHome));
            this.btnEeltsSimon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowserMain = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNex = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEeltsSimon
            // 
            this.btnEeltsSimon.BackColor = System.Drawing.Color.White;
            this.btnEeltsSimon.FlatAppearance.BorderSize = 0;
            this.btnEeltsSimon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEeltsSimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEeltsSimon.Location = new System.Drawing.Point(0, 0);
            this.btnEeltsSimon.Name = "btnEeltsSimon";
            this.btnEeltsSimon.Size = new System.Drawing.Size(167, 25);
            this.btnEeltsSimon.TabIndex = 0;
            this.btnEeltsSimon.Text = "IELTS Simon Online";
            this.btnEeltsSimon.UseVisualStyleBackColor = false;
            this.btnEeltsSimon.Click += new System.EventHandler(this.btnEeltsSimon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowserMain);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-3, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 605);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // webBrowserMain
            // 
            this.webBrowserMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMain.Location = new System.Drawing.Point(3, 16);
            this.webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMain.Name = "webBrowserMain";
            this.webBrowserMain.Size = new System.Drawing.Size(1008, 586);
            this.webBrowserMain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "LopNgoaiNgu.com Offline";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNex
            // 
            this.btnNex.BackColor = System.Drawing.Color.White;
            this.btnNex.FlatAppearance.BorderSize = 0;
            this.btnNex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNex.ImageIndex = 1;
            this.btnNex.ImageList = this.imageList1;
            this.btnNex.Location = new System.Drawing.Point(928, 1);
            this.btnNex.Name = "btnNex";
            this.btnNex.Size = new System.Drawing.Size(63, 25);
            this.btnNex.TabIndex = 1;
            this.btnNex.UseVisualStyleBackColor = false;
            this.btnNex.Click += new System.EventHandler(this.btnNex_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "back.ico");
            this.imageList1.Images.SetKeyName(1, "next.ico");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ImageIndex = 0;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(858, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNex);
            this.Controls.Add(this.btnEeltsSimon);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(1008, 614);
            this.Load += new System.EventHandler(this.ucHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEeltsSimon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowserMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNex;






    }
}
