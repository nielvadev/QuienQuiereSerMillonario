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

    

    public partial class FormRegister : Form
    {
        private string aux;
        private int cont;

        public FormRegister()
        {
            InitializeComponent();

        }

    private void btnReturnLogin_Click(object sender, EventArgs e)
        {

            /*SoundPlayer Sele = new SoundPlayer();
            Sele.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Select.wav";
            Sele.Play();*/
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Hide();
         
        }

        private void btnSalirR_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Botón salida de aplicación
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            /*SoundPlayer Sele = new SoundPlayer();
            Sele.SoundLocation = "C:\\Users\\Juan Daniel\\source\\repos\\QQSM\\Resources\\Select.wav";
            Sele.Play();*/

            Table.Create();
            cont = 0;
            
            if (txtPassR1.Text != txtPassR2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(txtPassR1.Text == "" || txtPassR2.Text == "")
            {
                MessageBox.Show("Escriba una contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string User = txtUserR.Text;

                foreach (DataRow item in Table.dtUsers.Rows)
                {

                    aux = item["user"].ToString();
                    if (User == aux)
                    {
                        cont++;
                    }
                }

                if (cont > 0)
                {
                    MessageBox.Show("Este usuario ya existe, escoja otro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    Table.dtUsers.Rows.Add(txtUserR.Text, txtPassR1.Text, txtEmail.Text, txtName.Text);
                    MessageBox.Show("El usuario ha sido agregado satisfactoriamente", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin frmLogin = new FormLogin();
                    frmLogin.Show();
                    this.Hide();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
