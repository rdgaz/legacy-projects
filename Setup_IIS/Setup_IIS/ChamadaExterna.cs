using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
%
namespace Setup_IIS
{
    class ChamadaExterna

    {
          

        // Executa programa externo podendó passar parâmetros.
        public void ChamaProgramaExterno(string nomeCaminhoExe, string parametro)
        {

            try
            {
                using (Process p = new Process())
                {
                    // Define a aplicação e o(s) parametro(s)
                    p.StartInfo.FileName = Path.Combine(Application.StartupPath, @nomeCaminhoExe);
                    if (!string.IsNullOrEmpty(parametro))
                        p.StartInfo.Arguments = parametro;
                    //p.StartInfo.WorkingDirectory = pastaInicio;

                    // Inicia a aplicação principal
                    p.Start();

                    // Aguarda até que o processo termine (opcional)                 
                    p.WaitForExit();
                }
            }
         
            catch
            {
                MessageBox.Show("Problemas para chegar ao destino " + @nomeCaminhoExe);
            }

        }

      
        // Extrai um zip para o caminho destino que se nãoi existor é criado.
        public void ExtrairZip(string caminhoDestino, string caminhoZip)
        {
             ZipFile.ExtractToDirectory(caminhoZip, caminhoDestino);
        }


        //Verifica se o arquivo exixte
        public bool arquivoExiste(string caminhoArquivo)
        {
            if (System.IO.File.Exists(@caminhoArquivo))

                return true;

            else
                return false;
        }

        public void GeradoraArquivo()
        {
          string tmp = System.Environment.GetEnvironmentVariable("TMP");

          if (!string.IsNullOrEmpty(tmp))
              tmp = System.Environment.GetEnvironmentVariable("TEMP");

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@tmp+"\\siis.bat", false, System.Text.Encoding.UTF8))
            {
                //sw.WriteLine("pause");
				sw.WriteLine("@ echo off");
                sw.WriteLine("mode con lines=10");
                sw.WriteLine("mode con cols=15");
                sw.WriteLine("");
				sw.WriteLine("Start /w pkgmgr /iu:IIS-WebServerRole;IIS-WebServer;IIS-CommonHttpFeatures;IIS-StaticContent;IIS-DefaultDocument;IIS-DirectoryBrowsing;IIS-HttpErrors;IIS-ApplicationDevelopment;IIS-ASPNET;IIS-NetFxExtensibility;IIS-ISAPIExtensions;IIS-ISAPIFilter;IIS-HealthAndDiagnostics;IIS-HttpLogging;IIS-LoggingLibraries;IIS-RequestMonitor;IIS-Security;IIS-RequestFiltering;IIS-HttpCompressionStatic;IIS-WebServerManagementTools;IIS-ManagementConsole;WAS-WindowsActivationService;WAS-ProcessModel;WAS-NetFxEnvironment;WAS-ConfigurationAPI");
                sw.Close();
            }
        }
    }

}
