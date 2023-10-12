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
            VerificarConexao();
        }

        private void VerificarConexao()
        {
            _db = new MC1BOWTMVOTORANTIMDatabase();
            _wslogdb = new MC1WSLOGDatabase();

            if (_db.VerificarConexao())
            {
                imgDatabase.Image = Properties.Resources.green_circle_icon;
            }
            else
            {
                imgDatabase.Image = Properties.Resources.red_circle_icon;
            }

            if (_wslogdb.VerificarConexao())
            {
                imgDataBaseETL.Image = Properties.Resources.green_circle_icon;
            }
            else
            {
                imgDataBaseETL.Image = Properties.Resources.red_circle_icon;
            }

            progressBar1.Value = 100;
            lblStatus.Text = "Concluido";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
