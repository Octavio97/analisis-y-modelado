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
    public partial class Cuenta : Form
    {
        public string i;
        public bool admin;

        public Cuenta()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnRegresar, "Ir a biblioteca");
            toolTip1.SetToolTip(btnModificar, "Modificar");
            toolTip1.SetToolTip(btnAcepta, "Aceptar");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
            biblioteca.lblNombre.Text = txtNombre.Text;
            if (admin == true)
            {
                biblioteca.agregarToolStripMenuItem.Visible = true;
                biblioteca.admin = true;
            }
            biblioteca.i = i;
            this.Hide();
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {
            SqlCommand cuentas = new SqlCommand(string.Format("select * from Cliente where id_cliente = '{0}'", i), conexion.conectar());
            SqlDataReader leer = cuentas.ExecuteReader();

            while (leer.Read())
            {
                txtNombre.Text = leer.GetString(1);
                txtApellidos.Text = leer.GetString(2);
                txtFecha.Text = leer.GetDateTime(4).ToString();
                txtTelefono.Text = leer.GetString(5);
                txtCorreo.Text = leer.GetString(6);
                txtContraseña.Text = leer.GetString(7);

                if (leer.GetString(3) == "Masculino")
                {
                    rdbMasculino.Checked = true;
                }
                else
                {
                    rdbFemenino.Checked = true;
                }

                txtNombre.Enabled = false;
                txtApellidos.Enabled = false;
                txtFecha.Enabled = false;
                txtTelefono.Enabled = false;
                txtCorreo.Enabled = false;
                txtContraseña.Enabled = false;
                rdbMasculino.Enabled = false;
                rdbFemenino.Enabled = false;
            }
            leer.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtContraseña.Enabled = true;
            txtCorreo.Enabled = true;
            txtFecha.Enabled = true;
            rdbFemenino.Enabled = true;
            rdbMasculino.Enabled = true;
            txtTelefono.Enabled = true;
            btnAcepta.Visible = true;
        }

       /*private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellidos.Text != "" && txtContraseña.Text != "" && txtCorreo.Text != "" && txtFecha.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && rdbMasculino.Checked)
                {
                    MessageBox.Show(modificar(txtNombre.Text, txtApellidos.Text, rdbMasculino.Text, txtFecha.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text, i), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtApellidos.Text != "" && txtContraseña.Text != "" && txtCorreo.Text != "" && txtFecha.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && rdbFemenino.Checked)
                {
                    MessageBox.Show(modificar(txtNombre.Text, txtApellidos.Text, rdbFemenino.Text, txtFecha.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text, i), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Completa tus datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btnAcepta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellidos.Text != "" && txtContraseña.Text != "" && txtCorreo.Text != "" && txtFecha.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && rdbMasculino.Checked)
                {
                    MessageBox.Show(modificar(txtNombre.Text, txtApellidos.Text, rdbMasculino.Text, txtFecha.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text, i), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtApellidos.Text != "" && txtContraseña.Text != "" && txtCorreo.Text != "" && txtFecha.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && rdbFemenino.Checked)
                {
                    MessageBox.Show(modificar(txtNombre.Text, txtApellidos.Text, rdbFemenino.Text, txtFecha.Text, txtTelefono.Text, txtCorreo.Text, txtContraseña.Text, i), "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Completa tus datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string modificar(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            string arg = "Error al modificar";
            try
            {
                SqlCommand modi = new SqlCommand(string.Format("update Cliente set nombre ='{0}', apellidos = '{1}', genero = '{2}', nacimiento = '{3}', telefono = '{4}', correo = '{5}', contraseña = '{6}' where id_cliente = '{7}'", a, b, c, d, e, f, g, h), conexion.conectar());
                modi.ExecuteNonQuery();
                arg = "Sus datos fueron modificados exitosamente";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arg;
        }       
    }
}
