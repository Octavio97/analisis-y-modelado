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
    public partial class Pelicula : Form
    {
        public string peli;
        public bool admin;

        public Pelicula()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnRegresar, "Ir a biblioteca");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Biblioteca bib = new Biblioteca();
            rep1.close();
            bib.lblNombre.Text = peli;
            if (admin == true)
            {
                bib.agregarToolStripMenuItem.Visible = true;
                bib.admin = true;
            }
            bib.Show();
            this.Hide();
        }
    }
}
