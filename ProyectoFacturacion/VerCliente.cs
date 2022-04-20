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
using System.Data.SqlTypes;
using Microsoft.SqlServer;
using System.Data.Sql;
namespace ProyectoFacturacion
{
    public partial class VerCliente : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
        Conexion con = new Conexion();
        public VerCliente()
        {
            InitializeComponent();
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "select* from Clientes";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCod.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            TxtCedu.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            TxtNom.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            TxtApe.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            TxtGen.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            TxtDire.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            TxtTel.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
        }

        private void VerCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = LlenarDataGV("Clientes").Tables[0];

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string eliminar = "  delete From Clientes where CodCliente = '" + TxtCod.Text + "'";
                con.ejecutar(eliminar);
                MessageBox.Show("Se elimino el cliente");
                TxtCod.Text = "";
                dgvClientes.DataSource = LlenarDataGV("Clientes").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el cliente" + error.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string modificar = "update Clientes set Nombre='" + TxtNom.Text + "', Apellidos='" + TxtApe.Text + "',  Direccion='" + TxtDire.Text + "' , Tel='" + TxtTel.Text + "' where CodCliente= '" + TxtCod.Text + "'";
                con.ejecutar(modificar);
                TxtDire.Text = "";
                TxtTel.Text = "";
                TxtCod.Text = "";
                TxtCedu.Text = "";
                TxtNom.Text = "";
                TxtGen.Text = "";
                TxtApe.Text = "";

                dgvClientes.DataSource = LlenarDataGV("Clientes").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar el cliente" + error.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRegre_Click(object sender, EventArgs e)
        {
            Form formi0 = new Clientes();
            this.Hide();
            formi0.Show();
        }

        private void TxtCod_KeyUp(object sender, KeyEventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Clientes where CodCliente like('%"+TxtCod.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvClientes.DataSource = dt;
            cnx.Close();

        }
        private void ocultarColumna()
        {
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[1].Visible = false;
            dgvClientes.Columns[2].Visible = false;
            dgvClientes.Columns[3].Visible = false;
            dgvClientes.Columns[4].Visible = false;
            dgvClientes.Columns[5].Visible = false;
            dgvClientes.Columns[6].Visible = false;
        }
        private void eliminar() {
            dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
