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
            cbxPago.DropDownStyle = ComboBoxStyle.DropDown;
            cbxPago.Items.Add("Efectivo");
            cbxPago.Items.Add("Credito");
            cbxPago.Items.Add("Cheque");
            cbxPago.Items.Add("Transferencia");
            cbxPago.Items.Add("Pagare");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            btnguardar3.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            validarFactura();

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            validarFactura();
        }

        private void btnguardar3_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string codigo = "insert into facturas (Num, FormaPago, IdEmpleado, IdArticulo, Comentario, Fecha, Cantidad, PrecioUnit) values ('" + TxtNum.Text + "','" + cbxPago.Text + "','" + TxtIdEmp.Text + "','" + TxtIdArti.Text + "','" + TxtComent.Text + "','" + dtpFecha.Text + "','" + TxtCant.Text + "','" + TxtPrecio.Text + "')";
                con.ejecutar(codigo);
                MessageBox.Show("Informacion de la factura guardada correctamente");
                TxtNum.Text = "";
                cbxPago.Text = "";
                TxtIdArti.Text = "";
                TxtNum.Text = "";
                TxtPrecio.Text = "";
                dtpFecha.Text = "";
                TxtComent.Text = "";
                TxtCant.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + error);
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            validarFactura();
        }
        private void validarFactura()
        {
            var vr = !string.IsNullOrEmpty(TxtNum.Text) && !string.IsNullOrEmpty(TxtIdArti.Text) && !string.IsNullOrEmpty(cbxPago.Text) && !string.IsNullOrEmpty(dtpFecha.Text) && !string.IsNullOrEmpty(TxtComent.Text)
                && !string.IsNullOrEmpty(TxtPrecio.Text) && !string.IsNullOrEmpty(TxtCant.Text) && !string.IsNullOrEmpty(TxtIdEmp.Text);
            btnguardar3.Enabled = vr;
        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {
            validarFactura();
        }

        private void cbxPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarFactura();
        }

        private void TxtIdEmp_TextChanged(object sender, EventArgs e)
        {
            validarFactura();
        }

        private void TxtCant_TextChanged(object sender, EventArgs e)
        {
            validarFactura();
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            validarFactura();
        }
    }
}