namespace MonitorVOTOCMC1
{
    partial class frmXML
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
            this.btnGerarXML = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.RichTextBox();
            this.dtpMc1LastUpdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidUser = new System.Windows.Forms.TextBox();
            this.txtCidCustomerParent = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.imgGitHub = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarXML
            // 
            this.btnGerarXML.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGerarXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarXML.ForeColor = System.Drawing.Color.White;
            this.btnGerarXML.Location = new System.Drawing.Point(464, 393);
            this.btnGerarXML.Name = "btnGerarXML";
            this.btnGerarXML.Size = new System.Drawing.Size(110, 67);
            this.btnGerarXML.TabIndex = 0;
            this.btnGerarXML.Text = "Gerar XML";
            this.btnGerarXML.UseVisualStyleBackColor = false;
            this.btnGerarXML.Click += new System.EventHandler(this.btnGerarXML_Click);
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(12, 55);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(396, 462);
            this.txtXML.TabIndex = 3;
            this.txtXML.Text = "";
            // 
            // dtpMc1LastUpdate
            // 
            this.dtpMc1LastUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMc1LastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMc1LastUpdate.Location = new System.Drawing.Point(434, 121);
            this.dtpMc1LastUpdate.Name = "dtpMc1LastUpdate";
            this.dtpMc1LastUpdate.Size = new System.Drawing.Size(180, 29);
            this.dtpMc1LastUpdate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(431, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(430, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente \"Pai\":";
            // 
            // txtCidUser
            // 
            this.txtCidUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCidUser.Location = new System.Drawing.Point(434, 207);
            this.txtCidUser.Name = "txtCidUser";
            this.txtCidUser.Size = new System.Drawing.Size(180, 29);
            this.txtCidUser.TabIndex = 8;
            // 
            // txtCidCustomerParent
            // 
            this.txtCidCustomerParent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCidCustomerParent.Location = new System.Drawing.Point(434, 281);
            this.txtCidCustomerParent.Name = "txtCidCustomerParent";
            this.txtCidCustomerParent.Size = new System.Drawing.Size(180, 29);
            this.txtCidCustomerParent.TabIndex = 9;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.imgClose);
            this.panelMain.Location = new System.Drawing.Point(-2, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(631, 49);
            this.panelMain.TabIndex = 10;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            this.panelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseMove);
            this.panelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseUp);
            // 
            // imgClose
            // 
            this.imgClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClose.Image = global::MonitorVOTOCMC1.Properties.Resources.close_icon;
            this.imgClose.Location = new System.Drawing.Point(582, 6);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(42, 37);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClose.TabIndex = 5;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.linkGitHub);
            this.panel1.Controls.Add(this.imgGitHub);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-1, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 24);
            this.panel1.TabIndex = 11;
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
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
            this.imgGitHub.Image = global::MonitorVOTOCMC1.Properties.Resources.github_icon;
            this.imgGitHub.Location = new System.Drawing.Point(7, 1);
            this.imgGitHub.Name = "imgGitHub";
            this.imgGitHub.Size = new System.Drawing.Size(24, 21);
            this.imgGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGitHub.TabIndex = 5;
            this.imgGitHub.TabStop = false;
            this.imgGitHub.Click += new System.EventHandler(this.imgGitHub_Click);
            // 
            // frmXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(626, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.txtCidCustomerParent);
            this.Controls.Add(this.txtCidUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMc1LastUpdate);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.btnGerarXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarXML;
        private System.Windows.Forms.RichTextBox txtXML;
        private System.Windows.Forms.DateTimePicker dtpMc1LastUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCidUser;
        private System.Windows.Forms.TextBox txtCidCustomerParent;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox imgClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.PictureBox imgGitHub;
    }
}