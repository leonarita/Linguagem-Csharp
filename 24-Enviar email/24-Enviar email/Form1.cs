using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace _24_Enviar_email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_enviar_Click(object sender, EventArgs e)
        {
            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //Definir as configurações do cliente
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //Definir as credenciais de acesso ao email
            credenciais.UserName = txtEmail.Text;
            credenciais.Password = txtSenha.Text;

            //Define as credenciais no cliente
            cliente.Credentials = credenciais;

            //Preparar a mensagem a enviar
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(txtDestino.Text);
            mensagem.Subject = txtAssunto.Text;
            mensagem.IsBodyHtml = true;
            mensagem.Body = txtMensagem.Text;
            mensagem.To.Add(txtDestino.Text);

            //Envio da mensagem de email
            try
            {
                cliente.Send(mensagem);
                MessageBox.Show("Mensagem enviada com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível enviar o email" + Environment.NewLine + Environment.NewLine + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAssunto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtDestino.Text;
            bool resultado = true;


            Regex reg = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");

            //Verificação do endereço de email
            if (reg.IsMatch(email)==false)
            {
                resultado = false;
            }

            //Verifica se o email tem mais do que um @
            int num_ats = 0;
            foreach(char c in email)
            {
                if (c == '@')
                    num_ats++;
            }
            if (num_ats!=1)
            {
                resultado = false;
            }

            //Verifica se o email é correto
            if (!resultado)
            {
                MessageBox.Show("Email inválido!");
            }
            else
            {
                MessageBox.Show("Email válido!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
