namespace Movie_Organizer_Mark2
{
    partial class SelectMovie
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
            this.LstBoxSelectedMovie = new System.Windows.Forms.ListBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxSelectedMovie
            // 
            this.LstBoxSelectedMovie.FormattingEnabled = true;
            this.LstBoxSelectedMovie.Location = new System.Drawing.Point(12, 12);
            this.LstBoxSelectedMovie.Name = "LstBoxSelectedMovie";
            this.LstBoxSelectedMovie.Size = new System.Drawing.Size(360, 173);
            this.LstBoxSelectedMovie.TabIndex = 0;
            this.LstBoxSelectedMovie.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstBoxSelectedMovie_MouseDoubleClick);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(109, 224);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(201, 224);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SelectMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LstBoxSelectedMovie);
            this.Name = "SelectMovie";
            this.Text = "SelectedMovie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxSelectedMovie;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}