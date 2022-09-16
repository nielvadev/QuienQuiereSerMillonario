using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace QQSM
{
    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void btnSalirG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            txtQuestion.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnCC.Visible = true;
            btnCall.Visible = true;
            btnChange.Visible = true;
            SoundPlayer Preguntas = new SoundPlayer();
            Preguntas.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Preguntas.wav";
            Preguntas.Play();

            Question1();

        }

        public void Question1()
        {
            //PREGUNTA 1
            txtQuestion.Text = "¿En qué año se descubrió América?";
            btnA.Text = "A). 1448";
            btnB.Text = "B). 1642";
            btnC.Text = "C). 1492";
            btnD.Text = "D). 1592";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnA.Visible = false;
            btnB.Visible = false;
            btnCC.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Call = new SoundPlayer();
            Call.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Call.wav";
            Call.Play();

            MessageBox.Show("Hola amigo, cómo estas? No recuerdo la fecha exacta, pero si estoy seguro que fue antes de 1500, por un señor don Cristobal. Suerte", "Tu amigo dice");
            btnCall.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //PREGUNTA 2
            txtQuestion.Text = "¿Quién descubrió América?";
            btnA.Text = "A). Amparo Grisales";
            btnB.Text = "B). Napoleón Bonaparte";
            btnC.Text = "C). Cristobal Colón";
            btnD.Text = "D). Willie Colón";
            btnChange.Visible = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Win = new SoundPlayer();
                Win.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Win.wav";
                Win.Play();
                MessageBox.Show("¡ CORRECTO !", "Confirmación");
                btnC.BackColor = Color.Green;
                FormGame2 frmGame2 = new FormGame2();
                frmGame2.Show();
                this.Hide();
            } 
            else
            {
                btnC.BackColor = Color.Black;
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Lose = new SoundPlayer();
                Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                Lose.Play();
                btnA.BackColor = Color.Red;
                btnC.BackColor = Color.Green;
                MessageBox.Show("¡ iNCORRECTO !", "Confirmación");
                FormGame frmGame = new FormGame();
                frmGame.Show();
                this.Hide();

                ;
            }
            else
            {
                btnA.BackColor = Color.Black;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Lose = new SoundPlayer();
                Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                Lose.Play();
                btnB.BackColor = Color.Red;
                btnC.BackColor = Color.Green;
                MessageBox.Show("¡ iNCORRECTO !", "Confirmación");
                FormGame frmGame = new FormGame();
                frmGame.Show();
                this.Hide();

                ;
            }
            else
            {
                btnB.BackColor = Color.Black;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Lose = new SoundPlayer();
                Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                Lose.Play();
                btnD.BackColor = Color.Red;
                btnC.BackColor = Color.Green;
                MessageBox.Show("¡ iNCORRECTO !", "Confirmación");
                FormGame frmGame = new FormGame();
                frmGame.Show();
                this.Hide();

                ;
            }
            else
            {
                btnD.BackColor = Color.Black;
            }
        }
    }
}
