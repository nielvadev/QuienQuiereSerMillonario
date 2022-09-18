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
    public partial class FormGame2 : Form
    {
        public FormGame2()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            //SoundPlayer Preguntas = new SoundPlayer();
            //Preguntas.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Preguntas.wav";
            //Preguntas.Play();

            btnPlay.Visible = false;
            txtQuestion.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnCC.Visible = true;
            btnCall.Visible = true;
            btnChange.Visible = true;

            Question2();
        }
        public void Question2()
        {
            //PREGUNTA 
            txtQuestion.Text = "¿Cuál es la capital de Canadá?";
            btnA.Text = "A). Quebec";
            btnB.Text = "B). Montreal";
            btnC.Text = "C). Vancouver";
            btnD.Text = "D). Ottawa";

        }

        private void btnSalirG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            btnA.Visible = false;
            btnC.Visible = false;
            btnCC.Visible = false;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            //SoundPlayer Call = new SoundPlayer();
            //Call.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Call.wav";
            //Call.Play();
            MessageBox.Show("Hola amigo, Tiempo sin saber de ti, que hay de la familia... Tu papá sigue al Occidente de EEUU en Los Ángeles?... tú sabes que yo viví en Canadá mucho tiempo, es por eso que estoy completamente seguro que es Ota... *Se acabó el tiempo", "Tu amigo dice");
            btnCall.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //PREGUNTA 2
            txtQuestion.Text = "¿En que zona de Estados Unidos se encuentra la bellísima ciudad de Los Ángles?";
            btnA.Text = "A). Norte";
            btnB.Text = "B). Sur";
            btnC.Text = "C). Este";
            btnD.Text = "D). Oeste";
            btnChange.Visible = false;

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //SoundPlayer Win = new SoundPlayer();
                //Win.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Win.wav";
                //Win.Play();
                btnD.BackColor = Color.Green;
                MessageBox.Show("¡ CORRECTO !", "Confirmación");
                
                FormGame3 frmGame3 = new FormGame3();
                frmGame3.Show();
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
                //SoundPlayer Lose = new SoundPlayer();
                //Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                //Lose.Play();
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
                //SoundPlayer Lose = new SoundPlayer();
                //Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                //Lose.Play();
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
                //SoundPlayer Lose = new SoundPlayer();
                //Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                //Lose.Play();
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

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
