using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Galgotube
{
    public class correo
    {
        MailMessage correos = new MailMessage();
        SmtpClient envio = new SmtpClient("smtp-mail.outlook.com", 587);

        public void enviarCorreo(string origen, string mensaje, string asunto, string destino)
        {
            try
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add(destino.Trim());
                correos.From = new MailAddress(origen);
                envio.Credentials = new NetworkCredential(origen, "chivas");
                envio.EnableSsl = true;
                envio.Send(correos);
                MessageBox.Show("Tu contraseña ha sid enviada a tu correo", "RECUPERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RECUPERAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
