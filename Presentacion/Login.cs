
using System.Globalization;
using System.Runtime.InteropServices;
using ClienteDes;
using Domain;
using ProductorDES;
using FormPrincipalDes;
using MySql.Data.MySqlClient;
using Capa_de_Soporte.Cache;

namespace Presentacion
{


    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Contraseña")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.LightGray;
                txtCedula.UseSystemPasswordChar = true;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Contraseña";
                txtCedula.ForeColor = Color.Silver;
                txtCedula.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginDes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario" && txtUsuario.TextLength > 2)
            {
                if (txtCedula.Text != "Contraseña")
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var validLogin = user.LoginUser(txtUsuario.Text, txtCedula.Text);

                    if (validLogin == true)
                    {
                        if (CacheLogin.Tipo == Posicion.Administrativo)
                        {
                            Admin mainMenu = new Admin();
                            MessageBox.Show("Bienvenido " + CacheLogin.nombre);
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        else
                        {
                            if (CacheLogin.Tipo == Posicion.Productor)
                            {
                                PrincipalProd Productor = new PrincipalProd();
                                MessageBox.Show("Bienvenido " + CacheLogin.nombre);
                                Productor.Show();
                                Productor.FormClosed += Logout;
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        msgError("Incorrecto el usuario y/o contraseña. \n   Intente denuevo.");
                        txtCedula.Text = "Contraseña";
                        txtUsuario.Focus();
                    }
                }
                else msgError("Porfavor Ingrese la contraseña");
            }
            else msgError("Porfavor Ingrese el Usuario");
        }

    
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtCedula.Text = "Contraseña";
            txtCedula.UseSystemPasswordChar = false;
            txtUsuario.Text = "Usuario";
            lblErrorMessage.Visible = false;
            this.Show();
        }
        

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCedula.MaxLength=10;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.Text= System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtUsuario.Text);
            txtUsuario.SelectionStart = txtUsuario.Text.Length;

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admminten letras.");

            }

            txtUsuario.MaxLength = 10;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new Restablecer_Contra();
            recoverPassword.ShowDialog();
        }
    

        private void btnLimp_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtUsuario.Focus();
                }
            }


        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
    
