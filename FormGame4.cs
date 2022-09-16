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
    public partial class FormGame4 : Form
    {
        public FormGame4()
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

            SoundPlayer Suspense = new SoundPlayer();
            Suspense.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Suspense.wav";
            Suspense.Play();

            Question4();
        }
        public void Question4()
        {
            //PREGUNTA 
            txtQuestion.Text = "¿Cuál fue la profesión de Georges Lemaître, famoso por plantear la teoría del Big Bang?";
            btnA.Text = "A). Sacerdote";
            btnB.Text = "B). Matemático";
            btnC.Text = "C). Biólogo";
            btnD.Text = "D). Astrónomo";

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
            MessageBox.Show("Hola veci, hasta que me llamaste. Mi profesora decía que era un sacerdote, suena un poco loco, no? Esperemos que el telescopio Hubble nos ayude desubrirlo ... Mmmm, dice mamá que ya hay un telescopio mas nuevo y que se llama James, como el jugador de basket !","Tu amigo dice");
            btnCall.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //PREGUNTA 
            txtQuestion.Text = "¿Cuál es el telescopio espacial con mejor calidad de imagenes que orbita actualmente?";
            btnA.Text = "A). James Webb";
            btnB.Text = "B). Chandra";
            btnC.Text = "C). Spitzer";
            btnD.Text = "D). Hubble";
            btnChange.Visible=false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            {
                btnA.BackColor = Color.Blue;
                if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SoundPlayer Win = new SoundPlayer();
                    Win.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Win.wav";
                    Win.Play();
                    btnA.BackColor = Color.Green;
                    MessageBox.Show("¡ CORRECTO !", "Confirmación");

                    FormGame5 frmGame5 = new FormGame5();
                    frmGame5.Show();
                    this.Hide();
                }
                else
                {
                    btnA.BackColor = Color.Black;
                }
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
                btnA.BackColor = Color.Green;
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
                btnA.BackColor = Color.Green;
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

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Lose = new SoundPlayer();
                Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                Lose.Play();
                btnD.BackColor = Color.Red;
                btnA.BackColor = Color.Green;
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

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
