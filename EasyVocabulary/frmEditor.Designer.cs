namespace EasyVocabulary
{
    partial class frmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.editor1 = new LiveSwitch.TextControl.Editor();
            this.SuspendLayout();
            // 
            // editor1
            // 
            this.editor1.BodyBackgroundColor = System.Drawing.Color.White;
            this.editor1.BodyHtml = null;
            this.editor1.BodyText = null;
            this.editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor1.DocumentText = resources.GetString("editor1.DocumentText");
            this.editor1.EditorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editor1.EditorForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editor1.FontSize = LiveSwitch.TextControl.FontSize.Three;
            this.editor1.Html = null;
            this.editor1.Location = new System.Drawing.Point(0, 0);
            this.editor1.Name = "editor1";
            this.editor1.Size = new System.Drawing.Size(784, 611);
            this.editor1.TabIndex = 0;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.editor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEditor_FormClosed);
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveSwitch.TextControl.Editor editor1;

    }
}