using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_velha
{
    public partial class Form1 : Form
    {
        public int jogada = 9;
        public int Vitoria_O = 0;
        public int Vitoria_X = 0;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnXcomeça_Click(object sender, EventArgs e)
        {
            bool vezX = true;
            lbnVez.Text = "X";
            botoesEnable();
            btnXcomeça.Enabled = false;
            btnOComeçar.Enabled = false;

        }

        private void botoesEnable()
        {
            btnC1L1.Enabled = true;
            btnC2L1.Enabled = true;
            btnC3L1.Enabled = true;
            btnC1L2.Enabled = true;
            btnC2L2.Enabled = true;
            btnC3L2.Enabled = true;
            btnC1L3.Enabled = true;
            btnC2L3.Enabled = true;
            btnC3L3.Enabled = true;
        }

        private void botoesDisabilitado()
        {
            btnC1L1.Enabled = false;
            btnC2L1.Enabled = false;
            btnC3L1.Enabled = false;
            btnC1L2.Enabled = false;
            btnC2L2.Enabled = false;
            btnC3L2.Enabled = false;
            btnC1L3.Enabled = false;
            btnC2L3.Enabled = false;
            btnC3L3.Enabled = false;
        }

        private void Limparbotoes()
        {
            btnC1L1.Text = "";
            btnC2L1.Text = "";
            btnC3L1.Text = "";
            btnC1L2.Text = "";
            btnC2L2.Text = "";
            btnC3L2.Text = "";
            btnC1L3.Text = "";
            btnC2L3.Text = "";
            btnC3L3.Text = "";
            lbnVez.Text = "";
            lbnVencedor.Text = "";
            lbnJogadas.Text = "9";


        }

        private void btnComeçar_Click(object sender, EventArgs e)
        {
            bool vezO = true;
            jogada = 9;
            lbnVez.Text = "O";
            botoesEnable();
            btnXcomeça.Enabled = false;
            btnOComeçar.Enabled = false;
        }

        private void btnRecomeçar_Click(object sender, EventArgs e)
        {
            botoesDisabilitado();
            Limparbotoes();
            btnXcomeça.Enabled = true;
            btnOComeçar.Enabled = true;

        }
        private void VerificaVencedor()
        {
            jogada--;
            lbnJogadas.Text = jogada.ToString();
            

            if (btnC1L1.Text == btnC2L1.Text && btnC1L1.Text == btnC3L1.Text
                && btnC1L1.Text != "")
            {
                lbnVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!","Vencedor",MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
                
            }
            else if (btnC1L2.Text == btnC2L2.Text && btnC3L2.Text == btnC1L2.Text && btnC1L2.Text != "")
            {
                lbnVencedor.Text = btnC1L2.Text;
                MessageBox.Show(btnC1L2.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }
            else if (btnC1L3.Text == btnC2L3.Text && btnC3L3.Text == btnC1L3.Text && btnC1L3.Text != "")
            {
                lbnVencedor.Text = btnC1L3.Text;
                MessageBox.Show(btnC1L3.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }


            else if (btnC1L1.Text == btnC1L2.Text && btnC1L1.Text == btnC1L3.Text
                && btnC1L1.Text != "")
            {
                lbnVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }
            else if (btnC2L1.Text == btnC2L2.Text && btnC2L1.Text == btnC2L3.Text
               && btnC2L1.Text != "")
            {
                lbnVencedor.Text = btnC2L1.Text;
                MessageBox.Show(btnC2L1.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }
            else if (btnC3L1.Text == btnC3L2.Text && btnC3L1.Text == btnC3L3.Text
              && btnC3L1.Text != "")
            {
                lbnVencedor.Text = btnC3L1.Text;
                MessageBox.Show(btnC3L1.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }

            else if (btnC1L1.Text == btnC2L2.Text && btnC1L1.Text == btnC3L3.Text
              && btnC1L1.Text != "")
            {
                lbnVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }
            else if (btnC1L3.Text == btnC2L2.Text && btnC1L3.Text == btnC3L1.Text
             && btnC3L1.Text != "")
            {
                lbnVencedor.Text = btnC1L1.Text;
                MessageBox.Show(btnC1L1.Text + " é o vencedor!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                botoesDisabilitado();
            }
            else
            {
                if (jogada==0)
                {
                    MessageBox.Show("--EMPATE--", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbnVencedor.Text = "EMPATE";
                }

            }
            if (lbnVencedor.Text=="O")
            {
                Vitoria_O++;
                lbnPlacarO.Text = Vitoria_O.ToString();
            }
            else if (lbnVencedor.Text == "X")
            {
                Vitoria_X++;
                lbnPlacarX.Text = Vitoria_X.ToString();
            }
            else
            {

            }



        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (lbnVez.Text == "X")
            {
                btn.Text = "X";
                lbnVez.Text = "O";
                btn.Enabled = false;

            }
            else
            {
                lbnVez.Text = "X";
                btn.Text = "O";
                btn.Enabled = false;
            }
            VerificaVencedor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
