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

namespace Galgotube
{
    public partial class Registro : Form
    {
        public string mess;
        public string i;

        #region Forma
        public Registro()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnAceptar, "Registrarse");
            toolTip1.SetToolTip(btnCancelar, "Cancelar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Sesion inicio = new Sesion();
            inicio.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();
            bool existe = false;
            SqlCommand reco = new SqlCommand(string.Format("select correo from Cliente where correo = '{0}'", txtCorreo.Text), conexion.conectar());
            SqlDataReader leer2 = reco.ExecuteReader();

            while (leer2.Read())
            {
                existe = true;
            }
            leer2.Close();
            if (existe == false)
            {
                string id = "";
                int i2;
                SqlCommand rec = new SqlCommand(string.Format("select id_cliente from Cliente"), conexion.conectar());
                SqlDataReader leer = rec.ExecuteReader();

                while (leer.Read())
                {
                    id = leer.GetString(0);
                    if (id == i)
                    {
                        i2 = Convert.ToInt32(i);
                        i = i2.ToString();
                    }
                }
                leer.Close();

                if (rdbMasculino.Checked == true && txtContraseña.Text == txtRcontraseña.Text && txtNombre.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && txtFecha.Text != "" && txtTelefono.Text != "")
                {
                    MessageBox.Show(alta(i, txtNombre.Text, txtApellidos.Text, rdbMasculino.Text, txtFecha.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text), "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    biblioteca.Show();
                    biblioteca.i = i;
                    biblioteca.lblNombre.Text = txtNombre.Text;
                    MessageBox.Show("Bienvenido a GalgoTube", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else if (rdbFemenino.Checked == true && txtContraseña.Text == txtRcontraseña.Text && txtNombre.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && txtFecha.Text != "" && txtTelefono.Text != "")
                {
                    MessageBox.Show(alta(i, txtNombre.Text, txtApellidos.Text, rdbFemenino.Text, txtFecha.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text), "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    biblioteca.Show();
                    biblioteca.lblNombre.Text = txtNombre.Text;
                    MessageBox.Show("Bienvenido a GalgoTube", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El correo que ingresaste ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Metodos BD
        public string alta(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            try
            {
                SqlCommand altas = new SqlCommand("Insert into Cliente(id_cliente, nombre, apellidos, genero, nacimiento, telefono, correo, contraseña) values(" + a + ", '" + b + "', '" + c + "', '" + d + "', '" + e + "', '" + f + "', '" + g + "', '" + h + "')", conexion.conectar());
                altas.ExecuteNonQuery();
                mess = "Su cuenta ha sido agregada exitosamente";
            }
            catch (Exception ex)
            {
                mess = ex.Message;
            }
            conexion.conectar().Close();
            return mess;
        }
        #endregion
    }
}
