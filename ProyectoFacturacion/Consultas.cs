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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            Form formi12 = new Reporte();
            this.Hide();
            formi12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formi13 = new Inicio();
            this.Hide();
            formi13.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Form formi3 = new ConsultaVendedores();
            this.Hide();
            formi3.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Form formi15 = new ConsultaArticulos();
            this.Hide();
            formi15.Show();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            Form formi15 = new ConsultaPago();
            this.Hide();
            formi15.Show();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }
    }
}
