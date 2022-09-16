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
using System.Xml.Linq;

namespace QQSM
{
    public partial class FormLogin : Form
    {
        FormRegister frmRegister = new FormRegister();
        FormGame frmGame = new FormGame();
        private string auxU, passU;
        private int cont;

        public FormLogin()
        {
            InitializeComponent();
            SoundPlayer Theme = new SoundPlayer();
            Theme.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Theme.wav";
            Theme.Play();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Botón salida de aplicación
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer Sele = new SoundPlayer();
            Sele.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Select.wav";
            Sele.Play();
            frmRegister.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SoundPlayer Sele = new SoundPlayer();
            Sele.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Select.wav";
            Sele.Play();

            cont = 0;

            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario y Contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cont++;
            }
            
            foreach (DataRow item in Table.dtUsers.Rows)
            {
                auxU = item["user"].ToString();
                passU = item["passw"].ToString();

                if (txtUser.Text == auxU && txtPass.Text == passU)
                {
                    cont++;
                    MessageBox.Show("Bienvenido " + auxU, "Inicio Sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGame.Show();
                    this.Hide();
                }
                else if (txtUser.Text == auxU && txtPass.Text != passU)
                {
                    MessageBox.Show("Contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cont++;
                }
            }
            if(cont == 0)
            {
                MessageBox.Show("Usuario no registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
