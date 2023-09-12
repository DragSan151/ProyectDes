using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Acesso_de_dato;


namespace Presentacion
{
    public partial class Restablecer_Contra : Form
    {
        public Restablecer_Contra()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = new UserDao();
            var result = user.recoverPassword(txtRestablecer.Text);
            lblResultado.Text = result;
        }
    }
}
