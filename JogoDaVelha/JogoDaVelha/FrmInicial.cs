using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class FrmInicial : Form
    {
        public int nT;
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo da velha criado por Rodrigo A. Souza");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void botao_clique(object sender, EventArgs e)
        {
            nT++;
            Button button = sender as Button;
            button.Text = lbe.Text;
            button.Enabled = false;
            if (lbe.Text == "X") { button.BackColor = Color.Red; }
            else { button.BackColor = Color.RoyalBlue; }
            juiz();
        }

        private void juiz()
        {
            string v;
            string b = lbe.Text;


            //VERIFICA NA HORIZONTAL
            if (ba1.Text == b && ba2.Text == b && ba3.Text == b) { vencedor(b); }
            if (bb1.Text == b && bb2.Text == b && bb3.Text == b) { vencedor(b); }
            if (bc1.Text == b && bc2.Text == b && bc3.Text == b) { vencedor(b); }
            //VERIFICA NA VERTICAL                               
            if (ba1.Text == b && bb1.Text == b && bc1.Text == b) { vencedor(b); }
            if (ba2.Text == b && bb2.Text == b && bc2.Text == b) { vencedor(b); }
            if (ba3.Text == b && bb3.Text == b && bc3.Text == b) { vencedor(b); }
            //VERIFICA NA HORIZONTAL                               
            if (ba1.Text == b && bb2.Text == b && bc3.Text == b) { vencedor(b); }
            if (bc1.Text == b && bb2.Text == b && ba3.Text == b) { vencedor(b); }

            if (nT == 9) { MessageBox.Show("Deu Empate!"); Application.Restart(); }

            else
            {
                switch (b)
                {
                    case "X":
                        b = "O";
                        break;
                    case "O":
                        b = "X";
                        break;
                }

                lbe.Text = b;
            }

        }

        private void vencedor(string v)
        {
            MessageBox.Show("" + v + " É O VENCEDOR");
            Application.Restart();
        }

    }
}
