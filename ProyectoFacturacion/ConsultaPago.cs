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
    public partial class ConsultaPago : Form
    {
        public ConsultaPago()
        {
            InitializeComponent();
        }
        public DataSet LlenarDataGV(string tabla)
        {
            Conexion con = new Conexion();
            DataSet DS;
            string cmd = "SELECT IDPago, CONCAT(Clientes.nombre,' ', Clientes.apellidos) as 'Nombre Completo', Clientes.Cedula, Articulos.Nombre as 'Articulo', Pago.Monto, facturas.FormaPago, Pago.Plazo FROM clientes, pago, facturas, Articulos WHERE Codi2 = CodCliente AND IdArticulo = Cod1 AND num = IDPago";
            DS = con.Ejecutar_Ds(cmd);
            return DS;
        }
        private void ConsultaPago_Load(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = LlenarDataGV("Pago").Tables[0];
        }


        private void btnRegresar4_Click(object sender, EventArgs e)
        {
            Form furmu = new Consultas();
            this.Hide();
            furmu.Show();
        }
        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
