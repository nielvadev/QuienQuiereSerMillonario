using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSM
{
    public partial class FormGame3 : Form
    {
        public FormGame3()
        {
            InitializeComponent();
        }

        private void btnSalirG_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
            btnC.Visible = false;
            btnCC.Visible = false;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            SoundPlayer Call = new SoundPlayer();
            Call.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Call.wav";
            Call.Play();
            MessageBox.Show("Hola, que bueno saludarte, te felicito por llegar hasta ahí. Solo recuerdo que se llama Michael, pero no recuerdo el apellido.. creo que era Schumacher... Ahhh no, ese es el de la fórmula 1. Suerte :)", "Tu amigo dice");
            btnCall.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //PREGUNTA 2
            txtQuestion.Text = "¿Cuál es piloto de automovilismo, famoso por ser el primero en conseguir 7 campeonatos mundiales?";
            btnA.Text = "A). Kimi Raikonnen";
            btnB.Text = "B). Fernando Alonso";
            btnC.Text = "C). Lewis Hamilton";
            btnD.Text = "D). Michael Schumacher";
            btnChange.Visible = false;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            SoundPlayer Preguntas = new SoundPlayer();
            Preguntas.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Preguntas.wav";
            Preguntas.Play();
            btnPlay.Visible = false;
            txtQuestion.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnCC.Visible = true;
            btnCall.Visible = true;
            btnChange.Visible = true;

            Question3();
        }
        public void Question3()
        {
            //PREGUNTA 
            txtQuestion.Text = "¿Cuál es el deportista que posee el record de ganar más medallas en una edición de Juegos Olímpicos?";
            btnA.Text = "A). Usain Bolt";
            btnB.Text = "B). Andrew Phillips";
            btnC.Text = "C). Wanyu Zhou";
            btnD.Text = "D). Michael Phelps";

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Win = new SoundPlayer();
                Win.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Win.wav";
                Win.Play();
                btnD.BackColor = Color.Green;
                MessageBox.Show("¡ CORRECTO !", "Confirmación");

                FormGame4 frmGame4 = new FormGame4();
                frmGame4.Show();
                this.Hide();
            }
            else
            {
                btnD.BackColor = Color.Black;
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
                btnD.BackColor = Color.Green;
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
                btnD.BackColor = Color.Green;
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

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Lose = new SoundPlayer();
                Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                Lose.Play();
                btnC.BackColor = Color.Red;
                btnD.BackColor = Color.Green;
                MessageBox.Show("¡ iNCORRECTO !", "Confirmación");
                FormGame frmGame = new FormGame();
                frmGame.Show();
                this.Hide();

                ;
            }
            else
            {
                btnC.BackColor = Color.Black;
            }
        }
    }
}
