using Microsoft.Win32;
using MonitorVOTOCMC1.Business;
using MonitorVOTOCMC1.Database.Entity;
using MonitorVOTOCMC1.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MonitorVOTOCMC1
{
    public partial class frmMonitor : Form
    {
        public frmMonitor()
        {
            InitializeComponent();
        }

        #region | VARIAVEIS |
        static string target = "https://github.com/thalisonss";

        MC1WSLOGBusiness _wslogBusiness;

        //Mover WinForm
        private bool isDragging = false;
        private int xOffset = 0;
        private int yOffset = 0;
        #endregion

        #region | CONTROLES |
        private void imgClose_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void btnFormXML_Click(object sender, EventArgs e)
        {
            frmXML tel = new frmXML();
            tel.Show();
        }

        private void imgGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }
        private void timerRefreshMC1WSLOG_Tick(object sender, EventArgs e)
        {
            WSLOGQuantidadeRegistrosComErro();
        }

        private void btnRefreshMC1WSLOG_Click(object sender, EventArgs e)
        {
            WSLOGQuantidadeRegistrosComErro();
        }

        private void cboMC1WSLOGRefresh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMC1WSLOGRefresh.Text == "5s")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 5000;
            }
            else if (cboMC1WSLOGRefresh.Text == "15s")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 15000;
            }
            else if (cboMC1WSLOGRefresh.Text == "30s")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 30000;
            }
            else if (cboMC1WSLOGRefresh.Text == "1m")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 100000;
            }
            else if (cboMC1WSLOGRefresh.Text == "5m")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 500000;
            }
            else if (cboMC1WSLOGRefresh.Text == "15m")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 150000;
            }
            else if (cboMC1WSLOGRefresh.Text == "1h")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 1000000;
            }
            else if (cboMC1WSLOGRefresh.Text == "3h")
            {
                timerRefreshMC1WSLOG.Enabled = true;
                timerRefreshMC1WSLOG.Interval = 3000000;
            }
            else if (cboMC1WSLOGRefresh.Text == "OFF")
            {
                timerRefreshMC1WSLOG.Enabled = false;
            }
        }

        private void btnExtrairDadosMC1WSLOG_Click(object sender, EventArgs e)
        {
            this.GerarExcel();
        }
        #endregion

        #region | FUNÇÕES |
        private void GerarExcel()
        {
            List<MC1_WS_LOG> listaDeRegistros = ColetarRegistros();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";
            saveFileDialog.Title = "Salvar arquivo Excel";
            saveFileDialog.FileName = "Registros.xlsx"; // Nome padrão do arquivo

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoDoArquivo = saveFileDialog.FileName;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Registros");

                    // Cabeçalhos das colunas
                    //worksheet.Cells[1, 1].Value = "Nome";
                    //worksheet.Cells[1, 2].Value = "Idade";
                    // Adicione mais cabeçalhos conforme necessário

                    int row = 1; // Começando da segunda linha para os dados

                    foreach (var registro in listaDeRegistros)
                    {
                        worksheet.Cells[row, 1].Value = registro.nID;
                        worksheet.Cells[row, 2].Value = registro.dLog;
                        worksheet.Cells[row, 3].Value = registro.cTable;
                        worksheet.Cells[row, 4].Value = registro.cBatch;
                        worksheet.Cells[row, 5].Value = registro.cTrackBatch;
                        worksheet.Cells[row, 6].Value = registro.cType;
                        worksheet.Cells[row, 7].Value = registro.cMessage;
                        // Preencha as colunas com os dados reais dos registros

                        row++;
                    }

                    // Salve o arquivo Excel no caminho selecionado pelo usuário
                    package.SaveAs(new FileInfo(caminhoDoArquivo));

                    MessageBox.Show("Registros exportados para Excel com sucesso!\nArquivo salvo em: " + caminhoDoArquivo);
                }
            }
        }

        private List<MC1_WS_LOG> ColetarRegistros()
        {
            _wslogBusiness = new MC1WSLOGBusiness();

            DateTime deData = dtpDeData.Value.Date;
            DateTime ateData = dtpAteData.Value.Date.AddHours(23)
                                                           .AddMinutes(59)
                                                           .AddSeconds(59)
                                                           .AddMilliseconds(99);

            List<MC1_WS_LOG> logs = _wslogBusiness.WSLOGQuantidadeRegistrosComErro(deData, ateData);

            return logs;
        }

        private void WSLOGQuantidadeRegistrosComErro()
        {

            progressBarMC1WSLOG.Value = 0;

            List<MC1_WS_LOG> logs = ColetarRegistros();

            if (logs.Count < 50)
            {
                lblCountMC1WSLOG.ForeColor = Color.Green;
            }
            else if (logs.Count >= 50 && logs.Count < 100)
            {
                lblCountMC1WSLOG.ForeColor = Color.Yellow;
            }
            else
            {
                lblCountMC1WSLOG.ForeColor = Color.Red;
            }

            lblCountMC1WSLOG.Text = logs.Count.ToString();

            lblMC1WSLOGAtualizado.Text = DateTime.Now.ToString();

            progressBarMC1WSLOG.Value = 100;
        }

        #endregion

    }
}