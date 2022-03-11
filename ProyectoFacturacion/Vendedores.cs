using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFacturacion
{
    public partial class Vendedores : Form
    {
        public Vendedores()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form formi1 = new Inicio();
            this.Hide();
            formi1.Show();
        }
    }
}
