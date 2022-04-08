using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFacturacion
{
    public partial class VerPago : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
        Conexion con = new Conexion();
        public VerPago()
        {
            InitializeComponent();
            cbxPago.DropDownStyle = ComboBoxStyle.DropDown;
            cbxPago.Items.Add("Efectivo");
            cbxPago.Items.Add("Credito");
            cbxPago.Items.Add("Cheque");
            cbxPago.Items.Add("Transferencia");
            cbxPago.Items.Add("Pagare");
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "select* from Pago";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }
        private void VerPago_Load(object sender, EventArgs e)
        {
            dgvPago.DataSource = LlenarDataGV("Pago").Tables[0];

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string modificar = "update Pago set tipoPago='" + cbxPago.Text + "', Monto='" + TxtMonto1.Text + "',  Plazo='" + TxtPlazos.Text + "'  where IDPago= '" + TxtId.Text + "'";
                con.ejecutar(modificar);
                TxtId.Text = "";
                TxtMonto1.Text = "";
                TxtPlazos.Text = "";
                cbxPago.Text = "";
            

                dgvPago.DataSource = LlenarDataGV("Pago").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar el pago" + error.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string eliminar = "delete Pago where IDPago = '" + TxtId.Text + "'";
                con.ejecutar(eliminar);
                MessageBox.Show("Se elimino el pago");
                TxtId.Text = "";
                dgvPago.DataSource = LlenarDataGV("Pago").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el pago" + error.Message);
            }
        }

        private void dgvPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           TxtId.Text = dgvPago.CurrentRow.Cells[1].Value.ToString();
           cbxPago.Text = dgvPago.CurrentRow.Cells[2].Value.ToString();
           TxtMonto1.Text = dgvPago.CurrentRow.Cells[3].Value.ToString();
           TxtPlazos.Text = dgvPago.CurrentRow.Cells[4].Value.ToString();

        }

        private void BtnRegre_Click(object sender, EventArgs e)
        {
            Form formi07 = new Pago();
            this.Hide();
            formi07.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void TxtId_KeyUp(object sender, KeyEventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Pago where IDPago like('%" + TxtId.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPago.DataSource = dt;

            cnx.Close();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
