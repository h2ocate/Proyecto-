using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFacturacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string codigo = "insert into Clientes (CodCliente, Cedula, Nombre, Apellidos, Genero, Direccion, Tel) values ('" + TxtCodCliente.Text + "','" + TxtCedula.Text + "','" + TxtNombre1.Text + "','" + TxtApellido1.Text + "','" + TxtGenero.Text + "','" + TxtDireccion.Text + "','" + TxtTel.Text + "')";
                con.ejecutar(codigo);
                MessageBox.Show("Informacion del cliente guardada correctamente");
                TxtCodCliente.Text = "";
                TxtCedula.Text = "";
                TxtNombre1.Text = "";
                TxtApellido1.Text = "";
                TxtGenero.Text = "";
                TxtDireccion.Text = "";
                TxtTel.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            Form formu5 = new VerCliente();
            this.Hide();
            formu5.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            Form form5 = new Inicio();
            this.Hide();
            form5.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            btnEnviar1.Enabled = false;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            validarClientes();
        }
        private void validarClientes()
        {
            var vr = !string.IsNullOrEmpty(TxtCodCliente.Text) && !string.IsNullOrEmpty(TxtCedula.Text) && !string.IsNullOrEmpty(TxtNombre1.Text) && !string.IsNullOrEmpty(TxtApellido1.Text) && !string.IsNullOrEmpty(TxtGenero.Text) &&
                !string.IsNullOrEmpty(TxtDireccion.Text) && !string.IsNullOrEmpty(TxtTel.Text);
            btnEnviar1.Enabled = vr;
        }

    }
}
