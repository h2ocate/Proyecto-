using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ProyectoFacturacion
{
    class Conexion
    {
        public SqlCommand CreateCommand { get; internal set; }

        public void ejecutar(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facturacion2;Integrated Security=True");
            con.Open();
            SqlCommand comando = new SqlCommand(cmd, con);
            comando.ExecuteNonQuery();
            con.Close();
        }
        public DataSet Ejecutar_Ds(string cmd)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Facturacion2;Integrated Security=True");
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, con);
            DA.Fill(DS);
            con.Close();

            return DS;
        }
        public DataSet LlenarDataGV(string tabla)
        {
            DataSet DS;
            string cmd = "select * from " + tabla;
            DS = Ejecutar_Ds(cmd);
            return DS;
        }
    }
}
