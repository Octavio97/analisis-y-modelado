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
    public partial class Biblioteca : Form
    {
        public string correo, i;
        public bool admin;
        public int sr;
        public PictureBox[] peliculas = new PictureBox[10000];
        public PictureBox[] peliculas2 = new PictureBox[10000];

        public Biblioteca()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Sesion inicio = new Sesion();
            inicio.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar ag = new Agregar();
            ag.Show();
            ag.admin = admin;
            ag.correo = correo;
            ag.nom = lblNombre.Text;
            this.Hide();
        }

        private void cuenta_Click(object sender, EventArgs e)
        {
            Cuenta cuentas = new Cuenta();
            cuentas.i = i;
            cuentas.Show();
            cuentas.admin = admin;
            this.Hide();
        }

        private void contacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Progtoid Inc. \r\nCorreo: proctoid_inc@hotmail.com", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            this.cargarEstrenos();
            this.cargarPeliculas();
        }

        private void peliculas_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Pelicula peli = new Pelicula();
            peli.peli = lblNombre.Text;
            SqlCommand pelicula = new SqlCommand(string.Format("select * from Pelicula where imagen = '{0}'", pb.ImageLocation), conexion.conectar());
            SqlDataReader leer22 = pelicula.ExecuteReader();

            while (leer22.Read())
            {
                peli.Show();
                peli.portada.Load(peli.portada.ImageLocation = leer22.GetString(6));
                peli.lblCat.Text = "Categoria: " + leer22.GetString(2);
                peli.lblAño.Text = "Año: " + leer22.GetString(3);
                peli.txtSin.Text = leer22.GetString(4);
                peli.lblNom.Text = leer22.GetString(1);
                peli.portada.BackgroundImageLayout = ImageLayout.Stretch;
                peli.rep1.Size = peli.reproductor.Size;
                peli.rep1.URL = leer22.GetString(7);
                peli.admin = admin;
                this.Hide();
            }
            leer22.Close();
        }

        public void cargarEstrenos()
        {
            sr = 0;
            SqlCommand pelicula = new SqlCommand(string.Format("select * from Pelicula where estreno = '2017'"), conexion.conectar());
            SqlDataReader leer = pelicula.ExecuteReader();

            while (leer.Read())
            {
                this.peliculas[sr] = new PictureBox();
                this.peliculas[sr].Name = leer.GetString(0);
                toolTip1.SetToolTip(this.peliculas[sr], leer.GetString(1));
                this.peliculas[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas[sr].Load(peliculas[sr].ImageLocation = leer.GetString(6));
                this.peliculas[sr].Size = new Size(124, 160);
                this.estrenos.Controls.Add(peliculas[sr]);
                this.peliculas[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
            leer.Close();
        }

        public void cargarPeliculas()
        {
            sr = 0;
            SqlCommand pelicula = new SqlCommand(string.Format("select * from Pelicula"), conexion.conectar());
            SqlDataReader leer = pelicula.ExecuteReader();

            while (leer.Read())
            {
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = leer.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], leer.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = leer.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
            leer.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand(string.Format("select * from Pelicula where nombre = '{0}'", txtBuscar.Text), conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Fantasia_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Fantasia'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Acción_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Accion'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Aventura_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Aventura'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void cienciaFiccion_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Ciencia ficcion'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Comedia_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Comedia'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Documental_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Documental'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Drama_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Drama'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Infantil_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Infantil'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Romance_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Romance'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Terror_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Terror'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Suspenso_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Suspenso'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }

        private void Musica_Click(object sender, EventArgs e)
        {
            sr = 0;
            SqlCommand busqueda = new SqlCommand("select * from Pelicula where categoria = 'Musica'", conexion.conectar());
            SqlDataReader lectura = busqueda.ExecuteReader();

            while (lectura.Read())
            {
                this.peliculasCat.Controls.Clear();
                this.peliculas2[sr] = new PictureBox();
                this.peliculas2[sr].Name = lectura.GetString(0);
                toolTip1.SetToolTip(this.peliculas2[sr], lectura.GetString(1));
                this.peliculas2[sr].SizeMode = PictureBoxSizeMode.StretchImage;
                this.peliculas2[sr].Load(peliculas2[sr].ImageLocation = lectura.GetString(6));
                this.peliculas2[sr].Size = new Size(124, 177);
                this.peliculasCat.Controls.Add(peliculas2[sr]);
                this.peliculas2[sr].Click += new EventHandler(peliculas_Click);
                sr++;
            }
        }
    }
}
