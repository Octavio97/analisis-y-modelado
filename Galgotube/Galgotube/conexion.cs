using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Galgotube
{
    public class conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection conection = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = BibliotecaPeliculas; Integrated Security = true");
            try { conection.Open(); }
            catch (Exception ex) { MessageBox.Show("Error al conectar con el servidor" + ex.Message); }
            return conection;
        }
    }
}
