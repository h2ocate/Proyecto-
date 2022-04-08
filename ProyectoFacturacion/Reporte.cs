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
    public partial class Reporte : Form
    {
        Conexion con = new Conexion();
        public Reporte()
        {
            InitializeComponent();
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "SELECT  F.idCLiente,C.Nombre, F.Fecha FROM facturas F, Clientes C  where  idCliente = CodCliente;";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }
        private void Reporte_Load(object sender, EventArgs e)
        {
            dgvReporte.DataSource = LlenarDataGV("facturas").Tables[0];
        }

        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            Form formi3 = new Consultas();
            this.Hide();
            formi3.Show();
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
