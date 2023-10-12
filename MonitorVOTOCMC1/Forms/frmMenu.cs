using MonitorVOTOCMC1.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MonitorVOTOCMC1.Database.Implements;

namespace MonitorVOTOCMC1.Forms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
           

        }

        #region | VARIAVEIS |
        MC1BOWTMVOTORANTIMDatabase _db;
        MC1WSLOGDatabase _wslogdb;

        static string target = "https://github.com/thalisonss";

        //Mover WinForm
        private bool isDragging = false;
        private int xOffset = 0;
        private int yOffset = 0;
        #endregion

        #region | CONTROLES |
        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbrirXML_Click(object sender, EventArgs e)
        {
            frmXML tela = new frmXML();
            tela.Show();
        }

        private void btnAbrirMonitor_Click(object sender, EventArgs e)
        {
            frmMonitor tela = new frmMonitor();
            tela.Show();
        }

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                xOffset = e.X;
                yOffset = e.Y;
            }
        }

        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int newX = this.Left + e.X - xOffset;
                int newY = this.Top + e.Y - yOffset;
                this.Location = new System.Drawing.Point(newX, newY);
            }
        }

        private void imgGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }
        #endregion

        #region | FUNÇÕES |

        
        #endregion

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConfigurar tela = new frmConfigurar();
            tela.Show();  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmConfigurar tela = new frmConfigurar();
            tela.Show();
        }
    }
}
