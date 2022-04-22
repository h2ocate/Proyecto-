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
    public partial class VerVendedores : Form
    {
        Conexion con = new Conexion();
        public VerVendedores()
        {
            InitializeComponent();
            cbxEstado.DropDownStyle = ComboBoxStyle.DropDown;
            cbxEstado.Items.Add("Casado");
            cbxEstado.Items.Add("Union Libre");
            cbxEstado.Items.Add("Soltero");
            cbxEstado.Items.Add("Concubinato");
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "select* from Vendedores";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerVendedores_Load(object sender, EventArgs e)
        {
            dgvVendedores.DataSource = LlenarDataGV("Vendedores").Tables[0];
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCod.Text = dgvVendedores.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text = dgvVendedores.CurrentRow.Cells[1].Value.ToString();
            TxtApellido.Text = dgvVendedores.CurrentRow.Cells[2].Value.ToString();
            TxtGenero.Text = dgvVendedores.CurrentRow.Cells[3].Value.ToString();
            TxtTel.Text = dgvVendedores.CurrentRow.Cells[4].Value.ToString();
            cbxEstado.Text = dgvVendedores.CurrentRow.Cells[5].Value.ToString();
            TxtSueldo.Text = dgvVendedores.CurrentRow.Cells[6].Value.ToString();
            TxtComision.Text = dgvVendedores.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string modificar = "update Vendedores set Nombre='" + TxtNombre.Text + "', Apellido='" + TxtApellido.Text + "',  Genero='" + TxtGenero.Text + "' , Tel='" + TxtTel.Text + "', Estado='" + cbxEstado.Text + "'" +
                    ", Sueldo='" + TxtSueldo.Text + "', Comision='" + TxtComision.Text + "' where Codigo= '" + TxtCod.Text + "'";
                con.ejecutar(modificar);
                TxtNombre.Text = "";
                TxtApellido.Text = "";
                TxtGenero.Text = "";
                cbxEstado.Text = "";
                TxtTel.Text = "";
                TxtSueldo.Text = "";
                TxtComision.Text = "";
                TxtCod.Text = "";

                dgvVendedores.DataSource = LlenarDataGV("Vendedores").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar el vendedor" + error.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string eliminar = "delete Vendedores where Codigo = '" + TxtCod.Text + "'";
                con.ejecutar(eliminar);
                MessageBox.Show("Se elimino el vendedor");
                TxtCod.Text = "";
                dgvVendedores.DataSource = LlenarDataGV("Vendedores").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el vendedor" + error.Message);
            }
        }

        private void BtnRegre_Click(object sender, EventArgs e)
        {
            Form formi02 = new Vendedores();
            this.Hide();
            formi02.Show();
        }
    }
}
