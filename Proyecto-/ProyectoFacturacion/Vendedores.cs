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
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDown;
            cbxEstado.Items.Add("Casado");
            cbxEstado.Items.Add("Union Libre");
            cbxEstado.Items.Add("Soltero");
            cbxEstado.Items.Add("Concubinato");
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form formi1 = new Inicio();
            this.Hide();
            formi1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void Vendedores_Load(object sender, EventArgs e)
        {
            btnGuardar2.Enabled = false;
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string codigo = "insert into Vendedores (Codigo, Nombre, Apellido, Genero, Tel, Estado, Sueldo, Comision) values ('" + TxtCod.Text + "','" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + TxtGenero.Text + "','" + TxtTelf.Text + "','" + cbxEstado.Text + "','" + TxtSueldo.Text + "','" + TxtComision.Text + "')";
                con.ejecutar(codigo);
                MessageBox.Show("Informacion del cliente guardada correctamente");
                TxtCod.Text = "";
                TxtNombre.Text = "";
                TxtApellido.Text = "";
                TxtGenero.Text = "";
                TxtGenero.Text = "";
                TxtTelf.Text = "";
                cbxEstado.Text = "";
                TxtSueldo.Text = "";
                TxtGenero.Text = "";
                TxtComision.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + error);
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Form formu8 = new VerVendedores();
            this.Hide();
            formu8.Show();
        }
        private void validarEmpleado()
        {
            var vr = !string.IsNullOrEmpty(TxtCod.Text) && !string.IsNullOrEmpty(TxtNombre.Text) && !string.IsNullOrEmpty(TxtApellido.Text) && !string.IsNullOrEmpty(TxtGenero.Text) && !string.IsNullOrEmpty(TxtTelf.Text) &&
                !string.IsNullOrEmpty(cbxEstado.Text) && !string.IsNullOrEmpty(TxtSueldo.Text) && !string.IsNullOrEmpty(TxtComision.Text);
            btnGuardar2.Enabled = vr;
        }

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void TxtGenero_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void TxtTelf_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void TxtSueldo_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }

        private void TxtComision_TextChanged(object sender, EventArgs e)
        {
            validarEmpleado();
        }
    }
}
