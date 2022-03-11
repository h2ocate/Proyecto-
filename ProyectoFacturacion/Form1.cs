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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            this.Hide();
            formulario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form form3 = new Inicio();
            this.Hide();
            form3.Show();
        }
    }
}
