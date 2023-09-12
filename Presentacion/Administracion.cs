using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Administracion : Form
    {
        MySqlConnection myCon;
        public Administracion()
        {
            InitializeComponent();
        }

        private void conectar()
        {
            try
            {
                string server = "localhost";
                string database = "empleados";
                string user = "root";
                string pwd = "123456";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";
                myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                MessageBox.Show("Conexion exitosa :3");
            }
            catch (Exception error)
            {
                MessageBox.Show( "Error de conexion " + error);
            }
        }

        private void llenarTabla()
        {
            string query = "select Nombre,CI,Tipo,Telefono from Personas;";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgPersonal.Rows.Add();
                        dgPersonal.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgPersonal.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgPersonal.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgPersonal.Rows[n].Cells[3].Value = reader.GetString(3);
                        //MessageBox.Show(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No hay Personal");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
                string where = " where 1=1 ";
                //Si el nombre no esta vacio
                if (txtBuscar.Text != "")
                {
                    where = where + " and nombre like'%" + txtBuscar.Text + "%' ";
                }
                
                string query = "select Nombre,CI,Tipo,Telfono " + where + " ;";
                MySqlCommand comandoDB = new MySqlCommand(query, myCon);
                comandoDB.CommandTimeout = 60;
                MySqlDataReader reader;
                dgPersonal.Rows.Clear();
                dgPersonal.Refresh();
                try
                {
                    reader = comandoDB.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int n = dgPersonal.Rows.Add();
                            dgPersonal.Rows[n].Cells[0].Value = reader.GetString(0);
                            dgPersonal.Rows[n].Cells[1].Value = reader.GetString(1);
                            dgPersonal.Rows[n].Cells[2].Value = reader.GetString(2);
                            dgPersonal.Rows[n].Cells[3].Value = reader.GetString(3);
                            //MessageBox.Show(reader.GetString(0));
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay Personal");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnFuncionamiento_Click(object sender, EventArgs e)
        {
            Agregar Funcionamiento = new Agregar();
            Funcionamiento.Show();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
    }

