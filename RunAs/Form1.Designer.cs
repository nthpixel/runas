namespace RunAs
{
	partial class RunAs
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
            this.btRun = new System.Windows.Forms.Button();
            this.ddlApps = new System.Windows.Forms.ComboBox();
            this.ddlCreds = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRunAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRun
            // 
            this.btRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRun.Location = new System.Drawing.Point(351, 133);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(113, 36);
            this.btRun.TabIndex = 0;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // ddlApps
            // 
            this.ddlApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlApps.FormattingEnabled = true;
            this.ddlApps.Location = new System.Drawing.Point(12, 47);
            this.ddlApps.Name = "ddlApps";
            this.ddlApps.Size = new System.Drawing.Size(224, 28);
            this.ddlApps.TabIndex = 1;
            // 
            // ddlCreds
            // 
            this.ddlCreds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCreds.FormattingEnabled = true;
            this.ddlCreds.Location = new System.Drawing.Point(242, 47);
            this.ddlCreds.Name = "ddlCreds";
            this.ddlCreds.Size = new System.Drawing.Size(222, 28);
            this.ddlCreds.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.credentialsToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.testToolStripMenuItem.Text = "Options";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            this.credentialsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.credentialsToolStripMenuItem.Text = "Credentials";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRunAsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutRunAsToolStripMenuItem
            // 
            this.aboutRunAsToolStripMenuItem.Name = "aboutRunAsToolStripMenuItem";
            this.aboutRunAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutRunAsToolStripMenuItem.Text = "About RunAs";
            // 
            // RunAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 293);
            this.Controls.Add(this.ddlCreds);
            this.Controls.Add(this.ddlApps);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RunAs";
            this.Text = "RunAs...";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btRun;
		private System.Windows.Forms.ComboBox ddlApps;
		private System.Windows.Forms.ComboBox ddlCreds;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRunAsToolStripMenuItem;
	}
}

