using FormPrincipalDes;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductorDES
{
    public partial class PrincipalProd : Form
    {
        public PrincipalProd()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<MiProyect>() where MiProyect : Form, new()
        {
            Form formulario;
            formulario = panelInicial.Controls.OfType<MiProyect>().FirstOrDefault(); //Busca en la coleccion un formulario que nosotrso allamos creado anterirormente 

            if (null == formulario)
            {
                formulario = new MiProyect();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelInicial.Controls.Add(formulario);
                panelInicial.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();


            }
        }
        //Mover el panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ComprasProductor>();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Show();
           // this.Hide();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<TrabajoProductor>();

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ProductosProd>();
        }

        private void btnPredio_Click(object sender, EventArgs e)
        {

        }
    }
}
