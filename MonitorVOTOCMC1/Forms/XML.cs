using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using MonitorVOTOCMC1.Business;
using MonitorVOTOCMC1.Database.Implements;
using MonitorVOTOCMC1.Database.Entity;
using System.IO;

namespace MonitorVOTOCMC1
{
    public partial class frmXML : Form
    {
        public frmXML()
        {
            InitializeComponent();
        }

        #region | VARIAVEIS |
        static string target = "https://github.com/thalisonss";

        MC1BOWTMVOTORANTIMDatabase _customerGCCDatabase;

        //Mover WinForm
        private bool isDragging = false;
        private int xOffset = 0;
        private int yOffset = 0;
        #endregion

        #region | FUNÇÕES |
        private void GerarXML()
        {
            _customerGCCDatabase = new MC1BOWTMVOTORANTIMDatabase();

            // Chame o método para obter a lista de clientes
            List<mc1_CustomerGCCExt> cliente = _customerGCCDatabase.WSLOGQuantidadeRegistrosComErro(dtpMc1LastUpdate.Value, txtCidUser.Text, txtCidCustomerParent.Text);

            // Crie um StringWriter para armazenar o XML formatado
            using (StringWriter stringWriter = new StringWriter())
            {
                // Crie um XmlTextWriter com formatação
                using (XmlTextWriter xmlWriter = new XmlTextWriter(stringWriter))
                {
                    xmlWriter.Formatting = Formatting.Indented;
                    xmlWriter.Indentation = 2; // Define o recuo desejado (2 espaços)

                    // Abre o elemento raiz
                    xmlWriter.WriteStartElement("RecebeCliente");

                    foreach (var clienteItem in cliente)
                    {
                        // Abre o elemento Cliente
                        xmlWriter.WriteStartElement("Cliente");

                        // Adicione os elementos no formato desejado <XXX>YYY<XXX>
                        WriteElement(xmlWriter, "BAIRRO", clienteItem.cNeighborhood);
                        WriteElement(xmlWriter, "CELULAR", clienteItem.cMobile);
                        WriteElement(xmlWriter, "CEP", clienteItem.lZipCode.ToString());
                        WriteElement(xmlWriter, "CIDADE", clienteItem.cCity);
                        WriteElement(xmlWriter, "CLIENTE_SAP", clienteItem.cCustomerSAP);
                        WriteElement(xmlWriter, "CNPJ", clienteItem.cDocument.Length > 11 ? clienteItem.cDocument : string.Empty);
                        WriteElement(xmlWriter, "COMPLEMENTO", clienteItem.cComplement);
                        WriteElement(xmlWriter, "CONTATO_CARGO", clienteItem.cOffice);
                        WriteElement(xmlWriter, "CONTATO_CELULAR", clienteItem.cContactMobile);
                        WriteElement(xmlWriter, "CONTATO_DEPARTAMENTO", clienteItem.cDepartment);
                        WriteElement(xmlWriter, "CONTATO_EMAIL", clienteItem.cContactEmail);
                        WriteElement(xmlWriter, "CONTATO_NOME", clienteItem.cContacteName);
                        WriteElement(xmlWriter, "CONTATO_SOBRENOME", clienteItem.cLastNameContact);
                        WriteElement(xmlWriter, "CONTATO_TELEFONE", clienteItem.cContactPhone);
                        WriteElement(xmlWriter, "CPF", clienteItem.cDocument.Length <= 11 ? clienteItem.cDocument : string.Empty);
                        WriteElement(xmlWriter, "DAT_NASCIMENTO", Convert.ToDateTime(clienteItem.dBirth).ToString("yyyyMMdd"));
                        WriteElement(xmlWriter, "DESCARGA_CLIENTE", clienteItem.iDischargingCustomer.ToString());
                        WriteElement(xmlWriter, "DESCARGA_FUMACA", clienteItem.lDischargingSmoke.ToString());

                        if (string.IsNullOrEmpty(clienteItem.cEmailNfe) == true)
                        {
                            WriteElement(xmlWriter, "EMAIL", clienteItem.cContactEmail);
                        }
                        else
                        {
                            WriteElement(xmlWriter, "EMAIL", clienteItem.cEmailNfe);
                        }

                        WriteElement(xmlWriter, "GR_CENTRALIZADOR", clienteItem.cGroupCentralizing);

                        if (Convert.ToString(clienteItem.cGroupAccount).ToUpper() == "RURAL")
                        {
                            WriteElement(xmlWriter, "GR_CONTA_CLIENTE", "CNPF");
                            WriteElement(xmlWriter, "FUNC_PARCEIRO", "RV");
                        }
                        else
                        {
                            WriteElement(xmlWriter, "GR_CONTA_CLIENTE", clienteItem.cGroupAccount);
                            WriteElement(xmlWriter, "FUNC_PARCEIRO", clienteItem.cFunctionPartner);
                        }

                        WriteElement(xmlWriter, "GR_SEGMENTO", clienteItem.cGroupSegmento);
                        WriteElement(xmlWriter, "GRCLIENTE", clienteItem.cGroupCustomer);
                        WriteElement(xmlWriter, "ID_PROSPECT", clienteItem.cIdCustomerProspect);
                        WriteElement(xmlWriter, "ID_TABLET", clienteItem.cIDCustomer);
                        WriteElement(xmlWriter, "ID_TABLET_PAI", clienteItem.cIDCustomerParent);
                        WriteElement(xmlWriter, "ID_VENDEDOR", clienteItem.cUser);
                        WriteElement(xmlWriter, "INSC_MUNIC", clienteItem.cRegistrationCity);
                        WriteElement(xmlWriter, "INSCR_ESTADUAL", clienteItem.cStateRegistration);
                        WriteElement(xmlWriter, "NOME_FANTASIA", clienteItem.cCustomerFantasyName);
                        WriteElement(xmlWriter, "NUMERO", clienteItem.cNumber);
                        WriteElement(xmlWriter, "PALETIZADO", clienteItem.iPaletizado.ToString());
                        WriteElement(xmlWriter, "RAZAO_SOCIAL", clienteItem.cCustomerName);
                        WriteElement(xmlWriter, "RUA", clienteItem.cStreet);
                        WriteElement(xmlWriter, "SEGMENTO", clienteItem.cSegmento);
                        WriteElement(xmlWriter, "SINCRONIZACAO", clienteItem.xTypeSync);
                        WriteElement(xmlWriter, "SUFRAMA", clienteItem.cSuframa);
                        WriteElement(xmlWriter, "TELEFONE", clienteItem.cPhone);
                        WriteElement(xmlWriter, "TRILHA", clienteItem.cCodeTrilha);
                        WriteElement(xmlWriter, "UF", clienteItem.cState);
                        WriteElement(xmlWriter, "CODIGO_VENDEDOR_RV", clienteItem.cUserSales.ToString());
                        WriteElement(xmlWriter, "HIBRIDO", clienteItem.xTypeReceiving);

                        // Fecha o elemento Cliente
                        xmlWriter.WriteEndElement();
                    }

                    // Fecha o elemento raiz
                    xmlWriter.WriteEndElement();

                    // Fecha o documento XML
                    xmlWriter.Close();
                }

                // Exibe o XML gerado no TextBox
                txtXML.Text = stringWriter.ToString();
            }
        }

        // Função auxiliar para escrever elementos no formato <XXX>YYY<XXX>
        private void WriteElement(XmlTextWriter xmlWriter, string elementName, string elementValue)
        {
            xmlWriter.WriteStartElement(elementName);
            xmlWriter.WriteString(elementValue);
            xmlWriter.WriteEndElement();
        }
        #endregion

        #region | CONTROLES |
        private void btnGerarXML_Click(object sender, EventArgs e)
        {
            this.GerarXML();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion

        private void imgGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(target);
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(target);
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
    }
}
