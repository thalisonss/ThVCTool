using MonitorVOTOCMC1.Business;
using MonitorVOTOCMC1.Database.Implements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorVOTOCMC1.Forms
{
    public partial class frmConfigurar : Form
    {
        public frmConfigurar()
        {
            InitializeComponent();
        }

        #region | VARIAVEIS |
        string server;
        string banco;
        string bancoETL;
        string configContent;
        string filePath;

        //Mover WinForm
        private bool isDragging = false;
        private int xOffset = 0;
        private int yOffset = 0;

        #endregion

        #region | CONTROLES |
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            server = txtServidor.Text;
            banco = txtBanco.Text;
            bancoETL = txtBancoETL.Text;

            DialogResult result = MessageBox.Show("Deseja aplicar a configuração?, o Aplicativo irá reniciar após conclusão", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                configContent = $@"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
    <section name=""entityFramework"" type=""System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" requirePermission=""false"" />
  </configSections>
  <startup>
    <supportedRuntime version=""v4.0"" sku="".NETFramework,Version=v4.7.2"" />
  </startup>
  <entityFramework>
    <providers>
      <provider invariantName=""System.Data.SqlClient"" type=""System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer"" />
    </providers>
  </entityFramework>
  <connectionStrings>
    <add name=""BO_WTM_ETL_VOTORANTIMEntities"" connectionString=""metadata=res://*/Database.Entity.MC1WSLogModel.csdl|res://*/Database.Entity.MC1WSLogModel.ssdl|res://*/Database.Entity.MC1WSLogModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={server};initial catalog={bancoETL};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"" providerName=""System.Data.EntityClient"" />
    <add name=""BO_WTM_ETL_VOTORANTIMEntities1"" connectionString=""metadata=res://*/Database.Entity.ModelMC1WSLOG.csdl|res://*/Database.Entity.ModelMC1WSLOG.ssdl|res://*/Database.Entity.ModelMC1WSLOG.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={server};initial catalog={bancoETL};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"" providerName=""System.Data.EntityClient"" />
    <add name=""BOWTMVOTORANTIMEntities"" connectionString=""metadata=res://*/Database.Entity.ModelBOWTMVOTORANTIM.csdl|res://*/Database.Entity.ModelBOWTMVOTORANTIM.ssdl|res://*/Database.Entity.ModelBOWTMVOTORANTIM.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={server};initial catalog={banco};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;"" providerName=""System.Data.EntityClient"" />
  </connectionStrings>
  <runtime>
    <assemblyBinding xmlns=""urn:schemas-microsoft-com:asm.v1"">
      <dependentAssembly>
        <assemblyIdentity name=""System.Runtime.CompilerServices.Unsafe"" publicKeyToken=""b03f5f7f11d50a3a"" culture=""neutral"" />
        <bindingRedirect oldVersion=""0.0.0.0-6.0.0.0"" newVersion=""6.0.0.0"" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
";

                // Caminho onde o arquivo sera salvo
                filePath = "MonitorVOTOCMC1.exe.config";

                // Escreve o conteudo no arquivo
                File.WriteAllText(filePath, configContent, Encoding.UTF8);


                Application.Exit();

                // Reabrir o aplicativo
                Process.Start(Application.ExecutablePath);

                MessageBox.Show("Script executado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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


        #endregion

        private void btnVerificarConexao_Click(object sender, EventArgs e)
        {
            frmVerificarConexao tela = new frmVerificarConexao();
            tela.Show();
        }
    }
}
