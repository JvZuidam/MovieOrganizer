namespace Movie_Organizer_Mark2
{
    partial class Form1
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(13, 39);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(191, 212);
            this.ListBox1.TabIndex = 0;
            this.ListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            this.ListBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFilesToolStripMenuItem,
            this.movieInformationToolStripMenuItem,
            this.playMovieToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // editFilesToolStripMenuItem
            // 
            this.editFilesToolStripMenuItem.Name = "editFilesToolStripMenuItem";
            this.editFilesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editFilesToolStripMenuItem.Text = "Edit Files";
            // 
            // movieInformationToolStripMenuItem
            // 
            this.movieInformationToolStripMenuItem.Name = "movieInformationToolStripMenuItem";
            this.movieInformationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.movieInformationToolStripMenuItem.Text = "Movie information";
            this.movieInformationToolStripMenuItem.Click += new System.EventHandler(this.movieInformationToolStripMenuItem_Click);
            // 
            // playMovieToolStripMenuItem
            // 
            this.playMovieToolStripMenuItem.Name = "playMovieToolStripMenuItem";
            this.playMovieToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playMovieToolStripMenuItem.Text = "Play Movie";
            this.playMovieToolStripMenuItem.Click += new System.EventHandler(this.playMovieToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFilesToolStripMenuItem,
            this.closeAltF4ToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // openFilesToolStripMenuItem
            // 
            this.openFilesToolStripMenuItem.Name = "openFilesToolStripMenuItem";
            this.openFilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openFilesToolStripMenuItem.Text = "Open Files";
            this.openFilesToolStripMenuItem.Click += new System.EventHandler(this.openFilesToolStripMenuItem_Click);
            // 
            // closeAltF4ToolStripMenuItem
            // 
            this.closeAltF4ToolStripMenuItem.Name = "closeAltF4ToolStripMenuItem";
            this.closeAltF4ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.closeAltF4ToolStripMenuItem.Text = "Close Alt + F4";
            this.closeAltF4ToolStripMenuItem.Click += new System.EventHandler(this.closeAltF4ToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // personalizeToolStripMenuItem
            // 
            this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
            this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personalizeToolStripMenuItem.Text = "Personalize";
            this.personalizeToolStripMenuItem.Click += new System.EventHandler(this.personalizeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 261);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movie Organizer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAltF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
    }
}

