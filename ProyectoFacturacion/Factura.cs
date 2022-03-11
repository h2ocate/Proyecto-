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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnFormaPa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegresar5_Click(object sender, EventArgs e)
        {
            Form formui = new Inicio();
            this.Hide();
            formui.Show();
        }
    }
}
