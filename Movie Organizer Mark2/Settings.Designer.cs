namespace Movie_Organizer_Mark2
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.TbCtrl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.PicBx1 = new System.Windows.Forms.PictureBox();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.TbCtrl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbCtrl1
            // 
            this.TbCtrl1.Controls.Add(this.tabPage1);
            this.TbCtrl1.Controls.Add(this.tabPage2);
            this.TbCtrl1.Location = new System.Drawing.Point(13, 13);
            this.TbCtrl1.Name = "TbCtrl1";
            this.TbCtrl1.SelectedIndex = 0;
            this.TbCtrl1.Size = new System.Drawing.Size(259, 236);
            this.TbCtrl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSelect);
            this.tabPage1.Controls.Add(this.PicBx1);
            this.tabPage1.Controls.Add(this.TxtBxName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Background";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtBxName
            // 
            this.TxtBxName.Location = new System.Drawing.Point(6, 6);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(100, 20);
            this.TxtBxName.TabIndex = 0;
            this.TxtBxName.Text = "Name";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(192, 270);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(102, 270);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 2;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(17, 270);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // PicBx1
            // 
            this.PicBx1.Image = ((System.Drawing.Image)(resources.GetObject("PicBx1.Image")));
            this.PicBx1.Location = new System.Drawing.Point(6, 56);
            this.PicBx1.Name = "PicBx1";
            this.PicBx1.Size = new System.Drawing.Size(100, 104);
            this.PicBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBx1.TabIndex = 1;
            this.PicBx1.TabStop = false;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(11, 166);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(90, 23);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Select Photo";
            this.BtnSelect.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 305);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TbCtrl1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.TbCtrl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbCtrl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.PictureBox PicBx1;
    }
}