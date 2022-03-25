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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form formu = new Form1();
            this.Hide();
            formu.Show();
        }

        private void btnRegistro1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion con = new Conexion();
                string codigo = "insert into registro (Nombre,Apellido,Correo,Usuario,Contraseña) values ('" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + TxtCorreo.Text + "','" + TxtUser.Text + "','" + TxtContra.Text + "')";
                con.ejecutar(codigo);
                MessageBox.Show("Registro guardado correctamente");
                TxtNombre.Text = "";
                TxtApellido.Text = "";
                TxtCorreo.Text = "";
                TxtUser.Text = "";
                TxtContra.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido el siguiente error" + error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCorreo.Text = "";
            TxtUser.Text = "";
            TxtContra.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
