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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            cbxCategoria.Items.Add("Industria");
            cbxCategoria.Items.Add("Construcción - Madera");
            cbxCategoria.Items.Add("Sellantes - Fijación y Tornillería");
            cbxCategoria.Items.Add("Pinturas y Complementos");
            cbxCategoria.Items.Add("Protección y Vestuario");
            cbxCategoria.Items.Add("Equipos de trabajo");
            cbxCategoria.Items.Add("Electroportátiles y Accesorios");
            cbxCategoria.Items.Add("Mobiliario Jardín / Playa / Camping / Piscinas");
            cbxCategoria.Items.Add("Material Eléctrico");
            cbxCategoria.Items.Add("Calefacción y Ventilación");
            cbxCategoria.Items.Add("Baño y Fontanería");
            cbxCategoria.Items.Add("Cerrajería");
            cbxCategoria.Items.Add("Ferretería Doméstica");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            Form form4 = new Inicio();
            this.Hide();
            form4.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string codigo = "insert into Articulos (Cod1, Nombre, Marca, Categoria, Cantidad, Precio) values ('" + TxtCod.Text + "','" + TxtNombre.Text + "','" + TxtMarca.Text + "','" + cbxCategoria.Text + "','" + TxtCantidad.Text + "','" + TxtPrecio.Text + "')";
                con.ejecutar(codigo);
                MessageBox.Show("Informacion del articulo guardado correctamente");
                TxtCod.Text = "";
                TxtNombre.Text = "";
                TxtMarca.Text = "";
                cbxCategoria.Text = "";
                TxtCantidad.Text = "";
                TxtPrecio.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            Form formu7 = new VerArticulo();
            this.Hide();
            formu7.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            validarArticulo();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            validarArticulo();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validarArticulo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            validarArticulo();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            validarArticulo();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarArticulo();
        }
        private void validarArticulo()
        {
            var vr = !string.IsNullOrEmpty(TxtCod.Text) && !string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtMarca.Text) && !string.IsNullOrEmpty(cbxCategoria.Text) &&
                !string.IsNullOrEmpty(TxtCantidad.Text) && !string.IsNullOrEmpty(TxtPrecio.Text);
            btnEnviar.Enabled = vr;
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            btnEnviar.Enabled = false;
        }
    }
}
