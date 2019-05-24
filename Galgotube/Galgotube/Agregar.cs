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
    public partial class Agregar : Form
    {
        public int i;
        public bool admin;
        public string correo, nom;

        public Agregar()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnAceptar, "Aceptar");
            toolTip1.SetToolTip(btnRegresar, "Regresar");
            toolTip1.SetToolTip(btnExaminar, "Buscar cartel");
            toolTip1.SetToolTip(btnExaminarpeli, "Buscar pelicula");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string id = "";
            bool esta = false; 
            SqlCommand rec = new SqlCommand(string.Format("select * from Pelicula"), conexion.conectar());
            SqlDataReader leer = rec.ExecuteReader();

            while (leer.Read())
            {
                id = leer.GetString(0);
                if (id == i.ToString())
                {
                    i++;
                }
                if (txtNombre.Text == leer.GetString(1))
                { esta = true; }
            }
            leer.Close();
            if (esta == false)
            {
                if (txtNombre.Text != "" && txtCategoria.Text != "" && txtAño.Text != "" && txtSinopsis.Text != "" && txtURL.Text != "" && txtArchivo.Text != "")
                {
                    MessageBox.Show(altas(i, txtNombre.Text, txtCategoria.Text, txtAño.Text, txtSinopsis.Text, correo, txtURL.Text, txtArchivo.Text));
                }
                else
                {
                    MessageBox.Show("Corriga sus datos", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La pelicula ya esta en biblioteca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Biblioteca bib = new Biblioteca();
            bib.Show();
            if (admin == true)
            {
                bib.agregarToolStripMenuItem.Visible = true;
            }
            bib.admin = admin;
            bib.lblNombre.Text = nom;
            this.Hide();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Archivo jpg(*.jpg) | *.jpg | Archivo png(*.png) | *.png | Archivo jpeg(*.jpeg) | *.jpg";
                openFileDialog1.Title = "Archivos jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtURL.Text = openFileDialog1.FileName.ToString();
                }
                openFileDialog1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExaminarpeli_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo mp4(*.mp4)|*.mp4";
            openFileDialog1.Title = "Archivos mp4";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = openFileDialog1.FileName.ToString();
            }
            openFileDialog1.Dispose();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand categoria = new SqlCommand(string.Format("select nombre from Categoria"), conexion.conectar());
                SqlDataReader leer = categoria.ExecuteReader();

                while (leer.Read())
                {
                    txtCategoria.Items.Add(leer.GetString(0));
                }
                leer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string altas(int a, string b, string c, string d, string e, string f, string g, string h)
        {
            string arg = "No se pudo agregar";
            try
            {
                SqlCommand alta = new SqlCommand("insert into Pelicula(id_pelicula, nombre, categoria, estreno, sinopsis, cliente, imagen, pelicula) values(" + a + ", '" + b + "', '" + c + "', '" + d + "', '" + e + "', '" + f + "', '" + g + "', '" + h + "')", conexion.conectar());
                alta.ExecuteNonQuery();
                arg = "Pelicula agregada exitosamente";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.conectar().Close();
            return arg;
        }      
    }
}
