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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
            cbxPago.DropDownStyle = ComboBoxStyle.DropDown;
            cbxPago.Items.Add("Efectivo");
            cbxPago.Items.Add("Credito");
            cbxPago.Items.Add("Cheque");
            cbxPago.Items.Add("Transferencia");
            cbxPago.Items.Add("Pagare");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pago_Load(object sender, EventArgs e)
        {
            btnguardar1.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            Form formi8 = new Inicio();
            this.Hide();
            formi8.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidarPago();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarPago();
        }

        private void btnguardar1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string codigo = "insert into Pago (Codi2, IDPago, tipoPago, Monto, Plazo) values ('" + TxtCodCliente.Text + "','" + TxtCodPago.Text + "','" + cbxPago.Text + "','" + TxtMonto.Text + "','" + TxtPlazo.Text + "')";
                con.ejecutar(codigo);
                MessageBox.Show("Informacion del pago guardada correctamente");
                TxtCodCliente.Text = "";
                TxtCodPago.Text = "";
                cbxPago.Text = "";
                TxtMonto.Text = "";
                TxtPlazo.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + error);
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Form formu6 = new VerPago();
            this.Hide();
            formu6.Show();
        }

        private void TxtCodCliente_TextChanged(object sender, EventArgs e)
        {
            ValidarPago();
        }
        private void ValidarPago()
        {
            var vr = !string.IsNullOrEmpty(TxtCodCliente.Text) && !string.IsNullOrEmpty(TxtCodPago.Text) &&
                    !string.IsNullOrEmpty(cbxPago.Text) && !string.IsNullOrEmpty(TxtMonto.Text) && !string.IsNullOrEmpty(TxtPlazo.Text);
            btnguardar1.Enabled = vr;
          
        }

        private void TxtCodPago_TextChanged(object sender, EventArgs e)
        {
            ValidarPago();
        }

        private void TxtPlazo_TextChanged(object sender, EventArgs e)
        {
            ValidarPago();
        }
    }
}
