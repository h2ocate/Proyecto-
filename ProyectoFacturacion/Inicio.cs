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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnRegresar1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form1();
            this.Hide();
            form2.Show();
        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            Form formi5 = new Articulos();
            this.Hide();
            formi5.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Form formi6 = new Clientes();
            this.Hide();
            formi6.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Form formi7 = new Pago();
            this.Hide();
            formi7.Show();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            Form formi2 = new Vendedores();
            this.Hide();
            formi2.Show();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Form formu1 = new Factura();
            this.Hide();
            formu1.Show();
        }
    }
}
