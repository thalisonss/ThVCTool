namespace MonitorVOTOCMC1
{
    partial class frmMonitor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMC1WSLOG = new System.Windows.Forms.TabControl();
            this.tabPageMC1WSLOG = new System.Windows.Forms.TabPage();
            this.btnExtrairDadosMC1WSLOG = new System.Windows.Forms.PictureBox();
            this.lblMC1WSLOGAtualizado = new System.Windows.Forms.Label();
            this.lblCountMC1WSLOG = new System.Windows.Forms.Label();
            this.progressBarMC1WSLOG = new System.Windows.Forms.ProgressBar();
            this.btnRefreshMC1WSLOG = new System.Windows.Forms.PictureBox();
            this.tabPageMC1WSLOGConfig = new System.Windows.Forms.TabPage();
            this.cboMC1WSLOGRefresh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAteData = new System.Windows.Forms.DateTimePicker();
            this.dtpDeData = new System.Windows.Forms.DateTimePicker();
            this.timerRefreshMC1WSLOG = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.imgGitHub = new System.Windows.Forms.PictureBox();
            this.tabControlMC1WSLOG.SuspendLayout();
            this.tabPageMC1WSLOG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtrairDadosMC1WSLOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshMC1WSLOG)).BeginInit();
            this.tabPageMC1WSLOGConfig.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMC1WSLOG
            // 
            this.tabControlMC1WSLOG.Controls.Add(this.tabPageMC1WSLOG);
            this.tabControlMC1WSLOG.Controls.Add(this.tabPageMC1WSLOGConfig);
            this.tabControlMC1WSLOG.Location = new System.Drawing.Point(12, 49);
            this.tabControlMC1WSLOG.Name = "tabControlMC1WSLOG";
            this.tabControlMC1WSLOG.SelectedIndex = 0;
            this.tabControlMC1WSLOG.Size = new System.Drawing.Size(274, 191);
            this.tabControlMC1WSLOG.TabIndex = 0;
            // 
            // tabPageMC1WSLOG
            // 
            this.tabPageMC1WSLOG.BackColor = System.Drawing.Color.Black;
            this.tabPageMC1WSLOG.Controls.Add(this.btnExtrairDadosMC1WSLOG);
            this.tabPageMC1WSLOG.Controls.Add(this.lblMC1WSLOGAtualizado);
            this.tabPageMC1WSLOG.Controls.Add(this.lblCountMC1WSLOG);
            this.tabPageMC1WSLOG.Controls.Add(this.progressBarMC1WSLOG);
            this.tabPageMC1WSLOG.Controls.Add(this.btnRefreshMC1WSLOG);
            this.tabPageMC1WSLOG.Location = new System.Drawing.Point(4, 22);
            this.tabPageMC1WSLOG.Name = "tabPageMC1WSLOG";
            this.tabPageMC1WSLOG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMC1WSLOG.Size = new System.Drawing.Size(266, 165);
            this.tabPageMC1WSLOG.TabIndex = 0;
            this.tabPageMC1WSLOG.Text = "MC1_WS_LOG";
            // 
            // btnExtrairDadosMC1WSLOG
            // 
            this.btnExtrairDadosMC1WSLOG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtrairDadosMC1WSLOG.Image = global::MonitorVOTOCMC1.Properties.Resources.sheets_icon;
            this.btnExtrairDadosMC1WSLOG.Location = new System.Drawing.Point(6, 3);
            this.btnExtrairDadosMC1WSLOG.Name = "btnExtrairDadosMC1WSLOG";
            this.btnExtrairDadosMC1WSLOG.Size = new System.Drawing.Size(24, 21);
            this.btnExtrairDadosMC1WSLOG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExtrairDadosMC1WSLOG.TabIndex = 4;
            this.btnExtrairDadosMC1WSLOG.TabStop = false;
            this.btnExtrairDadosMC1WSLOG.Click += new System.EventHandler(this.btnExtrairDadosMC1WSLOG_Click);
            // 
            // lblMC1WSLOGAtualizado
            // 
            this.lblMC1WSLOGAtualizado.ForeColor = System.Drawing.Color.White;
            this.lblMC1WSLOGAtualizado.Location = new System.Drawing.Point(3, 139);
            this.lblMC1WSLOGAtualizado.Name = "lblMC1WSLOGAtualizado";
            this.lblMC1WSLOGAtualizado.Size = new System.Drawing.Size(260, 15);
            this.lblMC1WSLOGAtualizado.TabIndex = 3;
            this.lblMC1WSLOGAtualizado.Text = "00/00/00 00:00:00";
            this.lblMC1WSLOGAtualizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountMC1WSLOG
            // 
            this.lblCountMC1WSLOG.AutoSize = true;
            this.lblCountMC1WSLOG.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.lblCountMC1WSLOG.ForeColor = System.Drawing.Color.White;
            this.lblCountMC1WSLOG.Location = new System.Drawing.Point(112, 54);
            this.lblCountMC1WSLOG.Name = "lblCountMC1WSLOG";
            this.lblCountMC1WSLOG.Size = new System.Drawing.Size(40, 46);
            this.lblCountMC1WSLOG.TabIndex = 2;
            this.lblCountMC1WSLOG.Text = "0";
            // 
            // progressBarMC1WSLOG
            // 
            this.progressBarMC1WSLOG.Location = new System.Drawing.Point(-4, 157);
            this.progressBarMC1WSLOG.Name = "progressBarMC1WSLOG";
            this.progressBarMC1WSLOG.Size = new System.Drawing.Size(274, 10);
            this.progressBarMC1WSLOG.TabIndex = 1;
            // 
            // btnRefreshMC1WSLOG
            // 
            this.btnRefreshMC1WSLOG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshMC1WSLOG.Image = global::MonitorVOTOCMC1.Properties.Resources.refresh_icon;
            this.btnRefreshMC1WSLOG.Location = new System.Drawing.Point(236, 3);
            this.btnRefreshMC1WSLOG.Name = "btnRefreshMC1WSLOG";
            this.btnRefreshMC1WSLOG.Size = new System.Drawing.Size(24, 21);
            this.btnRefreshMC1WSLOG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefreshMC1WSLOG.TabIndex = 0;
            this.btnRefreshMC1WSLOG.TabStop = false;
            this.btnRefreshMC1WSLOG.Click += new System.EventHandler(this.btnRefreshMC1WSLOG_Click);
            // 
            // tabPageMC1WSLOGConfig
            // 
            this.tabPageMC1WSLOGConfig.Controls.Add(this.cboMC1WSLOGRefresh);
            this.tabPageMC1WSLOGConfig.Controls.Add(this.label2);
            this.tabPageMC1WSLOGConfig.Controls.Add(this.label1);
            this.tabPageMC1WSLOGConfig.Controls.Add(this.dtpAteData);
            this.tabPageMC1WSLOGConfig.Controls.Add(this.dtpDeData);
            this.tabPageMC1WSLOGConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageMC1WSLOGConfig.Name = "tabPageMC1WSLOGConfig";
            this.tabPageMC1WSLOGConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMC1WSLOGConfig.Size = new System.Drawing.Size(266, 165);
            this.tabPageMC1WSLOGConfig.TabIndex = 1;
            this.tabPageMC1WSLOGConfig.Text = "Configurações";
            this.tabPageMC1WSLOGConfig.UseVisualStyleBackColor = true;
            // 
            // cboMC1WSLOGRefresh
            // 
            this.cboMC1WSLOGRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMC1WSLOGRefresh.FormattingEnabled = true;
            this.cboMC1WSLOGRefresh.Items.AddRange(new object[] {
            "OFF",
            "5s",
            "15s",
            "30s",
            "1m",
            "5m",
            "15m",
            "1h"});
            this.cboMC1WSLOGRefresh.Location = new System.Drawing.Point(20, 115);
            this.cboMC1WSLOGRefresh.Name = "cboMC1WSLOGRefresh";
            this.cboMC1WSLOGRefresh.Size = new System.Drawing.Size(100, 21);
            this.cboMC1WSLOGRefresh.TabIndex = 4;
            this.cboMC1WSLOGRefresh.SelectedIndexChanged += new System.EventHandler(this.cboMC1WSLOGRefresh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De:";
            // 
            // dtpAteData
            // 
            this.dtpAteData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAteData.Location = new System.Drawing.Point(20, 72);
            this.dtpAteData.Name = "dtpAteData";
            this.dtpAteData.Size = new System.Drawing.Size(100, 20);
            this.dtpAteData.TabIndex = 1;
            // 
            // dtpDeData
            // 
            this.dtpDeData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeData.Location = new System.Drawing.Point(20, 23);
            this.dtpDeData.Name = "dtpDeData";
            this.dtpDeData.Size = new System.Drawing.Size(100, 20);
            this.dtpDeData.TabIndex = 0;
            // 
            // timerRefreshMC1WSLOG
            // 
            this.timerRefreshMC1WSLOG.Tick += new System.EventHandler(this.timerRefreshMC1WSLOG_Tick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.imgClose);
            this.panelMain.Location = new System.Drawing.Point(-7, -6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(309, 49);
            this.panelMain.TabIndex = 1;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // imgClose
            // 
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Image = global::MonitorVOTOCMC1.Properties.Resources.close_icon;
            this.imgClose.Location = new System.Drawing.Point(268, 12);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(31, 28);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClose.TabIndex = 5;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.linkGitHub);
            this.panel1.Controls.Add(this.imgGitHub);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-3, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 24);
            this.panel1.TabIndex = 7;
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
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(297, 270);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.tabControlMC1WSLOG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlMC1WSLOG.ResumeLayout(false);
            this.tabPageMC1WSLOG.ResumeLayout(false);
            this.tabPageMC1WSLOG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtrairDadosMC1WSLOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshMC1WSLOG)).EndInit();
            this.tabPageMC1WSLOGConfig.ResumeLayout(false);
            this.tabPageMC1WSLOGConfig.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMC1WSLOG;
        private System.Windows.Forms.TabPage tabPageMC1WSLOG;
        private System.Windows.Forms.PictureBox btnRefreshMC1WSLOG;
        private System.Windows.Forms.TabPage tabPageMC1WSLOGConfig;
        private System.Windows.Forms.ProgressBar progressBarMC1WSLOG;
        private System.Windows.Forms.Label lblCountMC1WSLOG;
        private System.Windows.Forms.Timer timerRefreshMC1WSLOG;
        private System.Windows.Forms.DateTimePicker dtpAteData;
        private System.Windows.Forms.DateTimePicker dtpDeData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMC1WSLOGRefresh;
        private System.Windows.Forms.Label lblMC1WSLOGAtualizado;
        private System.Windows.Forms.PictureBox btnExtrairDadosMC1WSLOG;
        private System.Windows.Forms.Panel panelMain;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgGitHub;
        private System.Windows.Forms.LinkLabel linkGitHub;
    }
}

