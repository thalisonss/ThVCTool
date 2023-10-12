namespace MonitorVOTOCMC1.Forms
{
    partial class frmVerificarConexao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerificarConexao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.imgGitHub = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgDataBaseETL = new System.Windows.Forms.PictureBox();
            this.imgDatabase = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDataBaseETL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.linkGitHub);
            this.panel1.Controls.Add(this.imgGitHub);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-1, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 24);
            this.panel1.TabIndex = 12;
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
            // 
            // imgGitHub
            // 
            this.imgGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgGitHub.Image = ((System.Drawing.Image)(resources.GetObject("imgGitHub.Image")));
            this.imgGitHub.Location = new System.Drawing.Point(7, 1);
            this.imgGitHub.Name = "imgGitHub";
            this.imgGitHub.Size = new System.Drawing.Size(24, 21);
            this.imgGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGitHub.TabIndex = 5;
            this.imgGitHub.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Location = new System.Drawing.Point(-2, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(309, 49);
            this.panelMain.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(95, 81);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(110, 21);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Verificando...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(302, 10);
            this.progressBar1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Database ETL";
            // 
            // imgDataBaseETL
            // 
            this.imgDataBaseETL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDataBaseETL.Image = global::MonitorVOTOCMC1.Properties.Resources.yellow_circle_icon;
            this.imgDataBaseETL.Location = new System.Drawing.Point(85, 212);
            this.imgDataBaseETL.Name = "imgDataBaseETL";
            this.imgDataBaseETL.Size = new System.Drawing.Size(24, 21);
            this.imgDataBaseETL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDataBaseETL.TabIndex = 24;
            this.imgDataBaseETL.TabStop = false;
            // 
            // imgDatabase
            // 
            this.imgDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDatabase.Image = global::MonitorVOTOCMC1.Properties.Resources.yellow_circle_icon;
            this.imgDatabase.Location = new System.Drawing.Point(85, 150);
            this.imgDatabase.Name = "imgDatabase";
            this.imgDatabase.Size = new System.Drawing.Size(24, 21);
            this.imgDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDatabase.TabIndex = 7;
            this.imgDatabase.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmVerificarConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(301, 368);
            this.Controls.Add(this.imgDataBaseETL);
            this.Controls.Add(this.imgDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerificarConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerificarConexao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDataBaseETL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.PictureBox imgGitHub;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgDatabase;
        private System.Windows.Forms.PictureBox imgDataBaseETL;
        private System.Windows.Forms.Timer timer1;
    }
}