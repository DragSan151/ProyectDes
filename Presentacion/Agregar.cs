using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Acesso_de_dato;


namespace Presentacion
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        SqlConnection conexion= new SqlConnection("server=localhost;databases=proyect;integrated security=true ");
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "Insert into clientes values (" + txtNombre.Text + ",'" + txtContraseña.Text + ",'" + txtTipo.Text + "')";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "delete from clientes where nombre=" + txtNombre.Text + ",contraseña='" + txtContraseña.Text + ",Tipo='" + txtTipo.Text + "'where";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");

            conexion.Close();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string consulta = "update clientes set nombre=" + txtNombre.Text + ",contraseña='" + txtContraseña.Text + ",Tipo='" + txtTipo.Text + "'where";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if(cant > 0)
            {
                MessageBox.Show("Registro modificado");

            }

            conexion.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 10;
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }
    }
}
