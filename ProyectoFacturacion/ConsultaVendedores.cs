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
    public partial class ConsultaVendedores : Form
    {
        Conexion con = new Conexion();
        public ConsultaVendedores()
        {
            InitializeComponent();
        }

        private void ConsultaVendedores_Load(object sender, EventArgs e)
        {
            dgvReporte.DataSource = LlenarDataGV("Vendedores").Tables[0];
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "SELECT CONCAT(Vendedores.nombre,' ', Vendedores.apellido) as Nombre_Completo, facturas.Num, facturas.Fecha FROM Vendedores, facturas WHERE Codigo = IdEmpleado" +
                "" +
                "";
   
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }

        private void TxtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            Form formi3 = new Consultas();
            this.Hide();
            formi3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
