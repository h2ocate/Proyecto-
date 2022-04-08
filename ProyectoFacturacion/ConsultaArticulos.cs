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
    public partial class ConsultaArticulos : Form
    {
        public ConsultaArticulos()
        {
            InitializeComponent();
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "SELECT facturas.Num, Articulos.Nombre, Articulos.Marca, facturas.Cantidad, facturas.Fecha FROM facturas, Articulos WHERE IdArticulo = Cod1";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }
        private void ConsultaArticulos_Load(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = LlenarDataGV("facturas").Tables[0];
        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            Form formi13 = new Consultas();
            this.Hide();
            formi13.Show();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
