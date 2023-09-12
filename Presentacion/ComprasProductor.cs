using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductorDES
{
    public partial class ComprasProductor : Form
    {
        double precio = 0;

        public ComprasProductor()
        {
            InitializeComponent();
        }

        private void ComprasProd_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text= (0).ToString(" UYU ");

        }

        private void cboProductosTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoTipo = cboProductosTipo.Text;

            if (productoTipo.Equals("Verduras")) ;
            if (productoTipo.Equals("Frutas")) ;
            if (productoTipo.Equals("Semillas")) ;

            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboProductosTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
            ingresar un punto*/
            else if ((e.KeyChar == '.') && (!cboProductos.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("No se puede poner numeros", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Tampoco se puede poner letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
            ingresar un punto*/
            else if ((e.KeyChar == '.') && (!cboProductos.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("No se puede poner numeros", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Tampoco se puede poner letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
            ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtCantidad.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
            ingresar un punto*/
            else if ((e.KeyChar == '.') && (!cboProductos.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("No se puede poner numeros", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Tampoco se puede poner letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productos = cboProductos.Text;

            if (productos.Equals("Papas rosadas")) precio = 500 ;
            if (productos.Equals("Zapallo criollo")) precio = 450 ;
            if (productos.Equals("Trigo")) precio = 250;
            if (productos.Equals(" Cebada")) precio = 300;
            if (productos.Equals("Manzanas")) precio = 400;
            if (productos.Equals("Naranjas")) precio = 350;
            if (productos.Equals("Limones")) precio = 300;

            lblPrecio.Text = precio.ToString("UYU");
           

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (cboProductosTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de Producto!!");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe seleccionar una cantidad!!");
            else if (cboProductos.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un  Producto!!");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de pago !!");

            else
            {
                //Capturando datos 
                string TipoProd = cboProductosTipo.Text;
                string producto = cboProductos.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string tipo = cboTipo.Text;

                //Procesar calculos 
                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;
                double precioFinal = subtotal - descuento + recargo;

                //Impresion de resultados 
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(TipoProd);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString());
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString());
                fila.SubItems.Add(recargo.ToString());
                fila.SubItems.Add(precioFinal.ToString());

                listViewCompras.Items.Add(fila);

                btnCancelar_Click(sender, e);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagar Compra = new Pagar();
            Compra.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
