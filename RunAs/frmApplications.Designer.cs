namespace RunAs
{
    partial class frmApplications
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
            this.lblApplications = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPath = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbxApps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblApplications
            // 
            this.lblApplications.AutoSize = true;
            this.lblApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplications.Location = new System.Drawing.Point(13, 13);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(130, 26);
            this.lblApplications.TabIndex = 0;
            this.lblApplications.Text = "Applications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(60, 62);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(349, 20);
            this.txbName.TabIndex = 5;
            // 
            // txbPath
            // 
            this.txbPath.Location = new System.Drawing.Point(60, 89);
            this.txbPath.Name = "txbPath";
            this.txbPath.Size = new System.Drawing.Size(349, 20);
            this.txbPath.TabIndex = 6;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(334, 115);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // lbxApps
            // 
            this.lbxApps.FormattingEnabled = true;
            this.lbxApps.Location = new System.Drawing.Point(24, 144);
            this.lbxApps.Name = "lbxApps";
            this.lbxApps.Size = new System.Drawing.Size(385, 134);
            this.lbxApps.TabIndex = 8;
            // 
            // frmApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 296);
            this.Controls.Add(this.lbxApps);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txbPath);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplications);
            this.Name = "frmApplications";
            this.Text = "frmApplications";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPath;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ListBox lbxApps;
    }
}