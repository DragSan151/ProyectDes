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
    public partial class TrabajoProductor : Form
    {
        public TrabajoProductor()
        {
            InitializeComponent();
        }

        private void btnCriterios_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de Producto!!");
            else if (cboFertilizantes.Text == "")
                MessageBox.Show("Debe seleccionar un Fertilizante!!");
            else if (cboPredios.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar una zona del Predio!!");
            else if (cboNitrato.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar una cantidad de nitrato!!");

            if (cboFertilizantes.Text == "Nitrogeno")
            {
                if (rbz2.Checked == true)
                {
                    rbZ3.Checked = false;
                }
                else
                {
                    rbz2.Checked = false;
                }

            }
             else
            {
                //Capturando datos 
                string Fertilizantes = cboFertilizantes.Text;
                string producto = cboProductos.Text;
                string Predio = cboPredios.Text;
                string Nitrato = cboNitrato.Text;
                string NitratoZ3 = cboZ3.Text;
                int Cantidad_Nitrato = Int32.Parse(Nitrato);
                double Cantidad_NitratoZ3 = Int32.Parse(NitratoZ3);
                

                int Nc = 0;
                int Ns = 0;
                int EQ = 0;
                int Np = 0;
                int Ps = 0;
                int P = 0;
                int Criterio = 0;


                //Calculo fertilizacion trigo y cebada con nitrogeno y z2.2
                //Formula = (Nc - Ns)*EQ
                //Nc= Nivel critico
                //● Ns = Nitrógeno en planta
                //● EQ = Equivalente en fertilizante

                if (Cantidad_Nitrato == 5)
                {
                    Nc = 1;
                    Ns = 5;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 10)
                {
                    Nc = 2;
                    Ns = 10;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 15)
                {
                    Nc = 3;
                    Ns = 15;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato ==20)
                {
                    Nc = 4;
                    Ns = 20;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 25)
                {
                    Nc = 5;
                    Ns = 25;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 30)
                {
                    Nc = 6;
                    Ns = 30;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 35)
                {
                    Nc = 7;
                    Ns = 35;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 40)
                {
                    Nc = 8;
                    Ns = 40;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 45)
                {
                    Nc = 9;
                    Ns = 45;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 50)
                {
                    Nc = 10;
                    Ns = 50;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 55)
                {
                    Nc = 11;
                    Ns = 55;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 60)
                {
                    Nc = 12;
                    Ns = 60;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 65)
                {
                    Nc = 13;
                    Ns = 65;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_Nitrato == 70)
                {
                    Nc = 14;
                    Ns = 70;
                    EQ = 5;
                    Criterio = (Nc - Ns) * EQ;
                }


                //Calculo fertilizacion trigo y cebada con nitrogeno y z3.0
                // Formula  N = EQ*(Nc-Np)
                // Cebada 25 kg
                //Trigo 40 kg
                //Nitrogeno

                if (Cantidad_NitratoZ3 == 0.5)
                {
                    Nc = (int)0.5;
                    Np = 30;
                    EQ = 5;
                    Criterio = EQ*(Nc-Np);
                }
                if (Cantidad_NitratoZ3 == 1)
                {
                    Nc = 1;
                    Np = 30;
                    EQ = 10;
                    Criterio = EQ * (Nc - Np);
                }
                if (Cantidad_NitratoZ3 == 1.5)
                {
                    Nc = (int)1.5;
                    Np = 30;
                    EQ = 15;
                    Criterio = (Nc - Ns) * EQ;
                }
                if (Cantidad_NitratoZ3 == 2)
                {
                    Nc = 2;
                    Np = 30;
                    EQ = 20;
                    Criterio = EQ * (Nc - Np);
                }
                if (Cantidad_NitratoZ3 == 2.5)
                {
                    Nc = (int)2.5;
                    Np = 30;
                    EQ = 25;
                    Criterio = EQ * (Nc - Np);
                }
                if (Cantidad_NitratoZ3 == 3)
                {
                    Nc = 3;
                    Np = 30;
                    EQ = 30;
                    Criterio = EQ * (Nc - Np);
                }
                if (Cantidad_NitratoZ3 == 3.5)
                {
                    Nc = (int)3.5;
                    Np = 30;
                    EQ = 35;
                    Criterio = EQ * (Nc - Np);
                }
                if (Cantidad_NitratoZ3 == 4)
                {
                    Nc = 4;
                    Np = 30;
                    EQ = 40;
                    Criterio = EQ * (Nc - Np);
                }
                if (Cantidad_NitratoZ3 == 4.2)
                {
                    Nc = (int)4.2;
                    Np = 30;
                    EQ = 45;
                    Criterio = EQ * (Nc - Np);
                }

                //Calculo fertilizacion fosforo trigo y cebada
                // (P ) = (Nc-Ps)* EQ
               
                P = (Nc - Ps) * EQ;


                //Impresion de resultados 
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(Fertilizantes);
                fila.SubItems.Add(Predio);
                fila.SubItems.Add(Nitrato);
                fila.SubItems.Add(Criterio.ToString());

                listViewCriterios.Items.Add(fila);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productos = cboProductos.Text;

            if (productos.Equals(">Trigo")) ;
            if (productos.Equals(">Cebada")) ;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
    }

