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
    public partial class VerArticulo : Form
    {
        Conexion con = new Conexion();
        public VerArticulo()
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
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "select* from Articulos";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }
        private void VerArticulo_Load(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = LlenarDataGV("Articulos").Tables[0];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string eliminar = "delete Articulos where Cod1 = '" + TxtCod.Text + "'";
                con.ejecutar(eliminar);
                MessageBox.Show("Se elimino el articulo");
                TxtCod.Text = "";
                dgvArticulos.DataSource = LlenarDataGV("Articulos").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el articulo" + error.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string modificar = "update Articulos set Nombre='" + TxtNombre.Text + "', Marca='" + TxtMarca.Text + "',  Categoria='" + cbxCategoria.Text + "' , Cantidad='" + TxtCant.Text + "', Precio='" + TxtPrecio.Text + "' where Cod1= '" + TxtCod.Text + "'";
                con.ejecutar(modificar);
                TxtCod.Text = "";
                TxtNombre.Text = "";
                TxtMarca.Text = "";
                cbxCategoria.Text = "";
                TxtCant.Text = "";
                TxtPrecio.Text = "";

                dgvArticulos.DataSource = LlenarDataGV("Articulos").Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar el articulo" + error.Message);
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCod.Text = dgvArticulos.CurrentRow.Cells[0].Value.ToString();
            TxtNombre.Text = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
            TxtMarca.Text = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
            cbxCategoria.Text = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
            TxtCant.Text = dgvArticulos.CurrentRow.Cells[4].Value.ToString();
            TxtPrecio.Text = dgvArticulos.CurrentRow.Cells[5].Value.ToString();
        }

        private void BtnRegre_Click(object sender, EventArgs e)
        {
            Form formi05 = new Articulos();
            this.Hide();
            formi05.Show();
        }
    }
}
