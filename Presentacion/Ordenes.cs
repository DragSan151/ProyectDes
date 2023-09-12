using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net;

namespace FormPrincipalDes
{
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        class DownloadFile
        {
          //  private static void Main()
          //  {

          //      WebClient mywebClient = new WebClient();
          //      mywebClient.DownloadFile("http://mysite.com/myfile.txt", @"d:\myfile.txt");
         //   }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion su existe 


            //Validacion
            if (cboTipos.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de Producto!!");
            else if (cboProductos.Text == "")
                MessageBox.Show("Debe seleccionar un Producto!!");

            else
            {
                //Capturando datos 
                string TipoProd = cboTipos.Text;
                string producto = cboProductos.Text;
                int stock = 10;
                string Fecha = DateTime.Now.ToString("dd-MM-yyyy");
                int IdProd = 0;

                //Cuenta
                IdProd++;

                // Impresion sobre el Listview
                ListViewItem fila = new ListViewItem(IdProd.ToString());
                fila.SubItems.Add(TipoProd);
                fila.SubItems.Add(producto);
                fila.SubItems.Add(stock.ToString());
                fila.SubItems.Add(Fecha.ToString());

                listViewCriterios.Items.Add(fila);







            }
            }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
