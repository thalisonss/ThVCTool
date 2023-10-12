namespace MonitorVOTOCMC1.Forms
{
    partial class frmMenu
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAbrirXML = new System.Windows.Forms.Button();
            this.btnAbrirMonitor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgGitHub = new System.Windows.Forms.PictureBox();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.imgClose);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(309, 49);
            this.panelMain.TabIndex = 2;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // btnAbrirXML
            // 
            this.btnAbrirXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirXML.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirXML.ForeColor = System.Drawing.Color.White;
            this.btnAbrirXML.Location = new System.Drawing.Point(39, 110);
            this.btnAbrirXML.Name = "btnAbrirXML";
            this.btnAbrirXML.Size = new System.Drawing.Size(86, 56);
            this.btnAbrirXML.TabIndex = 3;
            this.btnAbrirXML.Text = "XML";
            this.btnAbrirXML.UseVisualStyleBackColor = true;
            this.btnAbrirXML.Click += new System.EventHandler(this.btnAbrirXML_Click);
            // 
            // btnAbrirMonitor
            // 
            this.btnAbrirMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirMonitor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAbrirMonitor.ForeColor = System.Drawing.Color.White;
            this.btnAbrirMonitor.Location = new System.Drawing.Point(179, 111);
            this.btnAbrirMonitor.Name = "btnAbrirMonitor";
            this.btnAbrirMonitor.Size = new System.Drawing.Size(86, 56);
            this.btnAbrirMonitor.TabIndex = 4;
            this.btnAbrirMonitor.Text = "Monitor";
            this.btnAbrirMonitor.UseVisualStyleBackColor = true;
            this.btnAbrirMonitor.Click += new System.EventHandler(this.btnAbrirMonitor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.linkGitHub);
            this.panel1.Controls.Add(this.imgGitHub);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 24);
            this.panel1.TabIndex = 8;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGitHub.Location = new System.Drawing.Point(35, 5);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkGitHub.TabIndex = 6;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MonitorVOTOCMC1.Properties.Resources.config_icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgGitHub
            // 
            this.imgGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGitHub.Image = global::MonitorVOTOCMC1.Properties.Resources.github_icon;
            this.imgGitHub.Location = new System.Drawing.Point(7, 1);
            this.imgGitHub.Name = "imgGitHub";
            this.imgGitHub.Size = new System.Drawing.Size(24, 21);
            this.imgGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGitHub.TabIndex = 5;
            this.imgGitHub.TabStop = false;
            this.imgGitHub.Click += new System.EventHandler(this.imgGitHub_Click);
            // 
            // imgClose
            // 
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Image = global::MonitorVOTOCMC1.Properties.Resources.close_icon;
            this.imgClose.Location = new System.Drawing.Point(264, 7);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(32, 33);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClose.TabIndex = 5;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(305, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbrirMonitor);
            this.Controls.Add(this.btnAbrirXML);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Button btnAbrirXML;
        private System.Windows.Forms.Button btnAbrirMonitor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.PictureBox imgGitHub;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}