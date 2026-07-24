using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Net;
namespace InfoComForm
{
    public partial class Form1 : Form
    {
        string endereco = "";
        string proc;
        string win;
        bool ev = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIP();
            try
            {
                win = System.Environment.GetEnvironmentVariable("TMP");
            }
            catch (Exception)
            {
                win = System.Environment.GetEnvironmentVariable("APPDATA");
                throw;
            }
            ManagementObjectSearcher s2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (var obj in s2.Get())
            {
                proc += obj["Name"].ToString();
            }

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }

        private void TbRamal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbRamal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void GetIP()
        {
            string strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            endereco = addr[addr.Length - 1].ToString();

            if (!endereco.Contains(".200."))
            {
                if(!endereco.Contains(".100."))
                {
                    endereco = addr[addr.Length - 2].ToString(); 
                }
            }
            if (!endereco.Contains(".200."))
            {
                if (!endereco.Contains(".100."))
                {
                    endereco = addr[addr.Length - 3].ToString();
                }
            }
            if (!endereco.Contains(".200."))
            {
                if (!endereco.Contains(".100."))
                {
                    endereco = addr[addr.Length - 4].ToString();
                }
            }
        }
        private void GeraBat(string caminho, string nomearq)
        {

            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String nome = TbNome.Text, mail = TbEmail.Text, setor = CbSetor.Text, ramal = TbRamal.Text;
            int CodSetor = CbSetor.SelectedIndex;
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@caminho + "\\" + nomearq, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(":: gera td e logs");
                    sw.WriteLine("cls");
                    sw.WriteLine("@echo off");
                    sw.WriteLine("color 2");
                    sw.WriteLine("net use I:  /delete /yes");
                    sw.WriteLine(":: versão 3.0.1");
                    sw.WriteLine("setlocal");
                    sw.WriteLine("set /a \"Tipo_pc=0\" ");
                    sw.WriteLine("set \"command=2^>nul WMIC SystemEnclosure Get ChassisTypes /value\" ");
                    sw.WriteLine("for /f \"tokens=2 delims=={}\" %%A IN ('%command%') do ( ");
                    sw.WriteLine("2>nul set /a \"Tipo_pc=%%A\" ");
                    sw.WriteLine(")");
                    sw.WriteLine("if %Tipo_pc%==0 (set /a \"Tipo_pc=2\") ");
                    sw.WriteLine("set _=Outro;Desconhecido;Desktop;Desktop de baixo perfil");
                    sw.WriteLine("set _=%_%;Pizza Box;Mini Torre;Torre;Notebook;Laptop;Notebook");
                    sw.WriteLine("set _=%_%;Palm top;Estacao Documento;Todos em um;Sub Notebook");
                    sw.WriteLine("set _=%_%;Economia de espaco;Vmware;Sistema principal;Expansivo");
                    sw.WriteLine("set _=%_%;Subexpansao;Bus de sistema ;Periferico");
                    sw.WriteLine("set _=%_%;Backup;Rack de sistema;PC selado");
                    sw.WriteLine("for /f \"tokens=%Tipo_pc% delims=; eol=\" %%A in (\"%_%\") do ( ");
                    sw.WriteLine("set tipo=%Tipo_pc% : %%A");
                    sw.WriteLine(")");
                    sw.WriteLine("");
                    sw.WriteLine("title Info.exe - Created By Rodrigo A. Souza");
                    sw.WriteLine("net use I: \\\\192.168.0.5\\arquivos /yes");
                    sw.WriteLine("cls");
                    sw.WriteLine("set s=systeminfo");
                    sw.WriteLine("set pc=%COMPUTERNAME%");
                    sw.WriteLine("set us=%homepath%");
                    sw.WriteLine("cls");
                    sw.WriteLine("echo Gerando arquivos, aguarde...");
                    sw.WriteLine("(");
                    sw.WriteLine("time /t");
                    sw.WriteLine("date /t");
                    sw.WriteLine("echo Nome:  " + nome + "");
                    sw.WriteLine("echo Email: " + mail + "");
                    sw.WriteLine("echo Setor: " + setor + "");
                    sw.WriteLine("echo Ramal: " + ramal + "");
                    sw.WriteLine("echo User: " + userName + " - %us%");
                    sw.WriteLine("echo Tipo: %Tipo%");
                    sw.WriteLine("echo Processador: \"" + proc + "\"");
                    sw.WriteLine("ipconfig | find \"IPv4\" ");
                    sw.WriteLine("%s%");
                    sw.WriteLine("tasklist");
                    sw.WriteLine(")>" + win + "\\" + CodSetor + "_%pc%.log");
                    sw.WriteLine("copy /y %tmp%\\" + CodSetor + "_%pc%.log S:\\Publico\\T.I\\inf\\logs\\" + CodSetor + "_%pc%.log");
                    sw.WriteLine("");
                    sw.WriteLine("(");
                    sw.WriteLine("echo        ^<tr^>");
                    sw.WriteLine("echo          ^<td^>" + nome + "^</td^>");
                    sw.WriteLine("echo   ^<td^> ^<a href=\"mailto:" + nome + " - " + setor + "<" + mail + ">\"^> " + mail + " ^</a^> ^</td^>");
                    sw.WriteLine("echo          ^<td^> %us% ^</td^>");
                    sw.WriteLine("echo          ^<td^>%tipo%^</td^>");
                    sw.WriteLine("echo ^<td^> \"" + proc + "\"^</td^>");
                    sw.WriteLine("echo ^<td^>" + endereco + "^</td^>");
                    sw.WriteLine("echo		  ^<td^> ^<a href=\"file:///S://Publico/T.I/inf/logs/" + CodSetor + "_%pc%.log\" target=\"_blank\"^>LOG^</a^> ^</td^> ");
                    sw.WriteLine("echo        ^</tr^>");
                    sw.WriteLine(")>" + win + "\\" + CodSetor + "_%pc%.txt ");
                    sw.WriteLine("copy /y %tmp%\\" + CodSetor + "_%pc%.txt S:\\Publico\\T.I\\inf\\tr\\" + CodSetor + "_%pc%.txt ");
                    sw.WriteLine("");
                    sw.WriteLine("echo msgbox \"Arquivos enviados com sucesso!\">\"%tmp%\\t.vbs\" ");
                    sw.WriteLine("cscript/nologo \"%tmp%\\t.vbs\" ");
                    sw.WriteLine("net use I:  /delete /yes");

                    sw.Close();
                }

            }

        }
        private bool camposValidos()
        {
            if (TbNome.Text.Length > 0)
            {
                if (CbSetor.Text != "Nenhum")
                {
                    if (ev == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void BtnOk_Click_1(object sender, EventArgs e)
        {

            if (camposValidos())
            {
                GeraBat(win, "info_li.bat");
                System.Diagnostics.Process.Start(@"" + win + "\\info_li.bat");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos solicitados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

            if (TbEmail.Text.Contains("@"))
            {
                if (TbEmail.Text.Contains(".net"))
                {
                    ev = true;
                    label2.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                ev = false;
                label2.ForeColor = System.Drawing.Color.Red;

            }
        }


        private void tbcargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
