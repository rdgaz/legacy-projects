using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace Setup_IIS
{
    class IntegraIIS
    {
        // Passa o comando para a programaExterno executar o appcmd
        public void CriaSiteIIS(string nomeSite, string porta, string caminhoZip)
        {
               String win = System.Environment.GetEnvironmentVariable("systemroot");

               if (new ChamadaExterna().arquivoExiste("" + win + "\\system32\\inetsrv\\APPCMD.exe"))
               {
                 new ChamadaExterna().ChamaProgramaExterno("" + win + "\\system32\\inetsrv\\APPCMD.exe",
                "add site /name:"+nomeSite+" /bindings:\"http/*:"+porta+":\" /physicalPath:\"C:\\inetpub\\wwwroot\\"+nomeSite+"\"");

                 new ChamadaExterna().ExtrairZip("C:\\inetpub\\wwwroot\\" + nomeSite + "", caminhoZip);
               }
               else
               { System.Windows.Forms.MessageBox.Show("Gerenciador do IIS não ecnontrado! " ); }
        }

               

        // Instala o Serviço do IIS

        public void InstalaServico()
        {

            String win = System.Environment.GetEnvironmentVariable("comspec");
            

            new ChamadaExterna().ChamaProgramaExterno(win,"Start /w pkgmgr /iu:IIS-WebServerRole;IIS-WebServer;IIS-CommonHttpFeatures;IIS-StaticContent;IIS-DefaultDocument;IIS-DirectoryBrowsing;IIS-HttpErrors;IIS-ApplicationDevelopment;IIS-ASPNET;IIS-NetFxExtensibility;IIS-ISAPIExtensions;IIS-ISAPIFilter;IIS-HealthAndDiagnostics;IIS-HttpLogging;IIS-LoggingLibraries;IIS-RequestMonitor;IIS-Security;IIS-RequestFiltering;IIS-HttpCompressionStatic;IIS-WebServerManagementTools;IIS-ManagementConsole;WAS-WindowsActivationService;WAS-ProcessModel;WAS-NetFxEnvironment;WAS-ConfigurationAPI");
        }


    }
}

    