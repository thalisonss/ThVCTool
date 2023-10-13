using MonitorVOTOCMC1.Database.Implements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorVOTOCMC1.Forms
{
    public partial class frmVerificarConexao : Form
    {
        #region | Variaveis |
        MC1BOWTMVOTORANTIMDatabase _db;
        MC1WSLOGDatabase _wslogdb;
        #endregion

        public frmVerificarConexao()
        {
            InitializeComponent();
            progressBar1.Value = 25;
            timer2.Enabled = true;
        }

        private void VerificarConexao()
        {
            timer2.Enabled = false;
            _db = new MC1BOWTMVOTORANTIMDatabase();
            _wslogdb = new MC1WSLOGDatabase();

            if (_db.VerificarConexao())
            {
                imgDatabase.Image = Properties.Resources.green_circle_icon;
                progressBar1.Value = 50;
            }
            else
            {
                imgDatabase.Image = Properties.Resources.red_circle_icon;
                progressBar1.Value = 50;
            }

            if (_wslogdb.VerificarConexao())
            {
                imgDataBaseETL.Image = Properties.Resources.green_circle_icon;
                progressBar1.Value = 100;
            }
            else
            {
                imgDataBaseETL.Image = Properties.Resources.red_circle_icon;
                progressBar1.Value = 100;
            }
            
            lblStatus.Text = "Concluido";
            btnFechar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            VerificarConexao();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
