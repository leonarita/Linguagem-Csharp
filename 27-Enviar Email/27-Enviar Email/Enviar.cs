using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Enviar_Email
{
    class Enviar
    {
        public static bool erro;

        public object Envio(bool arq, string email, string senha, string para, string Cc, string Cco, string assunto, string mensagem, bool op)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                MailMessage mail = new MailMessage();

                System.Net.NetworkCredential credenciais = new System.Net.NetworkCredential();
                credenciais.UserName = email;
                credenciais.Password = senha;

                if (op == false)
                {
                    smtp.Host = "smtp.live.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credenciais;
                }
                else
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credenciais;
                }

                mail.IsBodyHtml = true;

                mail.From = new MailAddress(email);

                if (string.IsNullOrEmpty(para))
                {
                    return erro = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(Cc))
                    {
                        mail.CC.Add(new MailAddress(Cc));
                    }

                    if (!string.IsNullOrEmpty(Cco))
                    {
                        mail.Bcc.Add(new MailAddress(Cco));
                    }

                    if (arq == true)
                    {
                        foreach (var a in Form1.anexo.Items)
                        {
                            mail.Attachments.Add(new Attachment(a.ToString()));
                        }
                    }

                    mail.To.Add(new MailAddress(para));
                    mail.Subject = assunto;
                    mail.Body = mensagem;
                    smtp.Send(mail);
                }

                return erro = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + Environment.NewLine + Environment.NewLine + ex.Message);
                return erro = true;
            }
        }
    }
}
