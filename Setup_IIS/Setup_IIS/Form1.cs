using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Setup_IIS;

namespace Setup_IIS
{
    public partial class FormAddSite : Form
    {
        public FormAddSite()
        {
            InitializeComponent();
        }


        // ======Validação campos

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            if (openFile.FileName != null)
            {
                if(openFile.FileName.Contains(".zip"))
                tbxCaminhoZip.Text = openFile.FileName;

                else
                    MessageBox.Show("O arquivo selecionado é inválido !");
            }
        }


        private void tbxPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    
        
        private void tbxNomeSite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            new IntegraIIS().CriaSiteIIS(tbxNomeSite.Text,tbxPorta.Text,tbxCaminhoZip.Text);

           // new ChamadaExterna().ExtrairZip("C:\\inetpub\\wwwroot\\" + tbxNomeSite.Text + "", tbxCaminhoZip.Text);
        }


        private void FormAddSite_Load(object sender, EventArgs e)
        {
            AtivaComponentes();	        
        }
 
        private void AtivaComponentes(int ativo)
        {
            if (ativo == 1)
            {
                tbxCaminhoZip.Enabled = true;
                tbxNomeSite.Enabled = true;
                tbxPorta.Enabled = true;
                btnAdicionar.Enabled = true;
                button1.Enabled = true;

                label4.ForeColor = System.Drawing.Color.Green;
                label4.Text = "Serviço já instalado (REINSTALAR)";
            }

            else
            {
                tbxCaminhoZip.Enabled = false;
                tbxNomeSite.Enabled = false;
                tbxPorta.Enabled = false;
                btnAdicionar.Enabled = false;
                button1.Enabled = false;

                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Serviço não instalado (INSTALAR AGORA)";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
           string tmp = System.Environment.GetEnvironmentVariable("TMP");

            new ChamadaExterna().GeradoraArquivo();

            new ChamadaExterna().ChamaProgramaExterno(tmp + "\\siis.bat","");

            AtivaComponentes();
        }

        private void AtivaComponentes()
        {
            String win = System.Environment.GetEnvironmentVariable("systemroot");
            if (new ChamadaExterna().arquivoExiste("" + win + "\\system32\\inetsrv\\APPCMD.exe"))
            {
                AtivaComponentes(1);
            }
            else
            {
                AtivaComponentes(0);
            }
        }
    }
}
