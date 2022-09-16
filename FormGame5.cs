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
    public partial class FormGame5 : Form
    {
        public FormGame5()
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

            Question5();
        }
        public void Question5()
        {
            //PREGUNTA 
            txtQuestion.Text = "Dónde se encuentra el 'Museo Rodin'";
            btnA.Text = "A). Roma";
            btnB.Text = "B). París";
            btnC.Text = "C). Venecia";
            btnD.Text = "D). Florencia";

        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            btnA.Visible = false;
            btnC.Visible = false;
            btnCC.Visible = false;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            SoundPlayer Call = new SoundPlayer();
            Call.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Call.wav";
            Call.Play();
            MessageBox.Show("Sabía que me llamarías !!!, No recuerdo la ciudad donde está el museo Rodin exactamente pero se que es en Francia. Fui hace años, pero recuerdo que me decepcioné de no ver obras de Vicent Van Gogh, siempre fue mi pintor favorito", "Tu amigo dice");
            btnCall.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //PREGUNTA 
            txtQuestion.Text = "¿Cuál de las siguientes obras NO está en el Museo Rodín en Paris?";
            btnA.Text = "A). El Pensador";
            btnB.Text = "B). La Noche Estrellada";
            btnC.Text = "C). El Beso";
            btnD.Text = "D). El Gran Vals";
            btnChange.Visible = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Win = new SoundPlayer();
                Win.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Win.wav";
                Win.Play();

                btnB.BackColor = Color.Green;
                MessageBox.Show("¡ CORRECTO, HAS GANADO EL PREMIO MAYOR: EL CONOCIMIENTO !", "Confirmación");

                FormLogin frmLogin = new FormLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {
                btnB.BackColor = Color.Black;
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
                btnB.BackColor = Color.Green;
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

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.BackColor = Color.Blue;
            if (MessageBox.Show("¿Última Palabra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SoundPlayer Lose = new SoundPlayer();
                Lose.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Lose.wav";
                Lose.Play();
                btnC.BackColor = Color.Red;
                btnB.BackColor = Color.Green;
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
                btnB.BackColor = Color.Green;
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
