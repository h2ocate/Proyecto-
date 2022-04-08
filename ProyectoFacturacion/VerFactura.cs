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
    public partial class VerFactura : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
        Conexion con = new Conexion();
        public VerFactura()
        {
            InitializeComponent();
            cbxPago.DropDownStyle = ComboBoxStyle.DropDown;
            cbxPago.Items.Add("Efectivo");
            cbxPago.Items.Add("Credito");
            cbxPago.Items.Add("Cheque");
            cbxPago.Items.Add("Transferencia");
            cbxPago.Items.Add("Pagare");
        }

        private void VerFactura_Load(object sender, EventArgs e)
        {
            dgvFactura.DataSource = LlenarDataGV("facturas").Tables[0];
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "select* from facturas";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string modificar = "update facturas set FormaPago='" + cbxPago.Text + "', IdEMpleado='" + TxtIdEmp.Text + "',  IdArticulo='" + TxtArt.Text + "' , Comentario='" + TxtComment.Text + "', Fecha='" + dtpFecha.Text + "'" +
                    ", Cantidad='" + TxtCant.Text + "', PrecioUnit='" + TxtPrecio.Text + "', idCliente='" + TxtIdClient.Text + "' where Num= '" + TxtNoFact.Text + "'";
                con.ejecutar(modificar);
                TxtNoFact.Text = "";
                cbxPago.Text = "";
                TxtArt.Text = "";
                TxtComment.Text = "";
                TxtIdEmp.Text = "";
                TxtCant.Text = "";
                TxtPrecio.Text = "";
                dtpFecha.Text = "";
                TxtIdClient.Text = "";

                dgvFactura.DataSource = LlenarDataGV("facturas").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar la factura" + error.Message);
            }
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNoFact.Text = dgvFactura.CurrentRow.Cells[0].Value.ToString();
            cbxPago.Text = dgvFactura.CurrentRow.Cells[1].Value.ToString();
            TxtIdEmp.Text = dgvFactura.CurrentRow.Cells[2].Value.ToString();
            TxtArt.Text = dgvFactura.CurrentRow.Cells[3].Value.ToString();
            TxtComment.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
            dtpFecha.Text = dgvFactura.CurrentRow.Cells[5].Value.ToString();
            TxtCant.Text = dgvFactura.CurrentRow.Cells[6].Value.ToString();
            TxtPrecio.Text = dgvFactura.CurrentRow.Cells[7].Value.ToString();
            TxtIdClient.Text = dgvFactura.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string eliminar = "delete facturas where Num = '" + TxtNoFact.Text + "'";
                con.ejecutar(eliminar);
                MessageBox.Show("Se elimino la factura");
                TxtNoFact.Text = "";
                dgvFactura.DataSource = LlenarDataGV("facturas").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar la factura" + error.Message);
            }
        }

        private void BtnRegre_Click(object sender, EventArgs e)
        {
            Form formu10 = new Factura();
            this.Hide();
            formu10.Show();
        }

        private void TxtNoFact_KeyUp(object sender, KeyEventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM facturas where Num like('%" + TxtNoFact.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvFactura.DataSource = dt;

            cnx.Close();
        }

        private void TxtNoFact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
