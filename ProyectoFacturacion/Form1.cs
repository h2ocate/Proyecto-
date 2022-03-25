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

namespace ProyectoFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            this.Hide();
            formulario.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = string.Format("select * from  Registro where Usuario = '{0}' and Contraseña='{1}'", TxtUsuario.Text, TxtContraseña.Text);
                Conexion con = new Conexion();
                DataSet DS = con.Ejecutar_Ds(codigo);
                var Usuario = DS.Tables[0].Rows[0]["Usuario"].ToString();
                string Contraseña = DS.Tables[0].Rows[0]["Contraseña"].ToString();
                if (Usuario == TxtUsuario.Text && Contraseña == TxtContraseña.Text)
                {
                    Form form3 = new Inicio();
                    this.Hide();
                    form3.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o Contraseña invalido");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
