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
    public partial class Sesion : Form
    {
        public string a, b, c, d;
        public int i;
        public bool color, con, admin;

        public Sesion()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnAceptar, "Aceptar");
            toolTip1.SetToolTip(btnSalir, "Salir");
        }

        private void lblregistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Biblioteca bib = new Biblioteca();

            if (con == false)
            {
                SqlCommand revisar = new SqlCommand(string.Format("select * from Cliente as c where c.correo = '{0}' and c.contraseña = '{1}'", txtCorreo.Text, txtContraseña.Text), conexion.conectar());
                SqlDataReader leer = revisar.ExecuteReader();
                a = null;
                b = null;
                while (leer.Read())
                {
                    a = leer.GetString(6);
                    b = leer.GetString(7);
                    d = leer.GetString(0);
                    bib.Show();
                    if (a == "2468" && b == "itt017")
                    {
                        bib.agregarToolStripMenuItem.Visible = true;
                        admin = true;
                        bib.admin = admin;
                    }
                    bib.lblNombre.Text = leer.GetString(1);
                    bib.correo = a;
                    bib.i = d;
                    this.Hide();
                    i++;
                }
                leer.Close();

                if (a == null && b == null)
                {
                    MessageBox.Show("No se pudo iniciar sesion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string correoelec = "", contra = "";
                SqlCommand correo = new SqlCommand(string.Format("select * from Cliente where correo = '{0}'", txtCorreo.Text), conexion.conectar());
                SqlDataReader lectura = correo.ExecuteReader();

                while (lectura.Read())
                {
                    correoelec = lectura.GetString(6);
                    contra = lectura.GetString(7);
                    correo cr = new correo();
                    SqlCommand contraseña = new SqlCommand(string.Format("select * from Cliente where correo = '{0}'", correoelec), conexion.conectar());
                    SqlDataReader lectura1 = contraseña.ExecuteReader();

                    while (lectura1.Read())
                    {
                        cr.enviarCorreo("gastelumcampeon@hotmail.com", "Hola su contrasena ha sido encontrada y es la siguiente: " + contra + ". Recuerda que eres muy imprtante para nosotros que no queremos que olvides tu contrasena.", "Contraseña usuario", correoelec);
                        lblregistro.Visible = true;
                        txtContraseña.Visible = true;
                        lblrecuperar.Visible = true;
                        label4.Visible = true;
                        btnSalir.Visible = true;
                        label3.Visible = false;
                        con = false;
                        txtCorreo.Clear();
                    }
                    lectura1.Close();
                }
                lectura.Close();
                con = false;
            }
        }

        private void lblregistro_MouseHover(object sender, EventArgs e)
        {
            lblregistro.ForeColor = Color.Blue;
        }

        private void lblregistro_MouseLeave(object sender, EventArgs e)
        {
            lblregistro.ForeColor = Color.Black;
        }

        private void lblrecuperar_Click(object sender, EventArgs e)
        {
            lblregistro.Visible = false;
            txtContraseña.Visible = false;
            lblrecuperar.Visible = false;
            label4.Visible = false;
            btnSalir.Visible = false;
            label3.Visible = true;
            con = true;
            txtCorreo.Clear();
        }

        private void lblrecuperar_MouseHover(object sender, EventArgs e)
        {
            lblrecuperar.ForeColor = Color.Blue;
        }

        private void lblrecuperar_MouseLeave(object sender, EventArgs e)
        {
            lblrecuperar.ForeColor = Color.Black;
        }     
    }
}
