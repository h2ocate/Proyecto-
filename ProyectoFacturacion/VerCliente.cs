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
    public partial class VerCliente : Form
    {
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
                string eliminar = "delete Clientes where CodCliente = '" + TxtCod.Text + "'";
                con.ejecutar(eliminar);
                MessageBox.Show("Se elimino el cliente");
                TxtCod.Text = "";
                dgvClientes.DataSource = LlenarDataGV("Clientes").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el clientes" + error.Message);
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
            try
            {
                Conexion con = new Conexion();
                string buscar = "SELECT * FROM Clientes where CodCliente = '" + TxtCod.Text + "'";
                con.ejecutar(buscar);
                TxtCod.Text = "";
                dgvClientes.DataSource = LlenarDataGV("Clientes").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("no se encontro el clientes" + error.Message);
            }
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
    }
}
