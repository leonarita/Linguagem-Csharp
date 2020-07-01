using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Enviar_Email
{
    public partial class Form1 : Form
    {
        public static ListBox anexo = new ListBox();
        bool arq, op;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRevelar.Checked)
                txtSenha.UseSystemPasswordChar = false;
            else
                txtSenha.UseSystemPasswordChar = true;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                listBox1.Items.Add(file);
                anexo.Items.Add(file);
                arq = true;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            anexo.Items.Remove(listBox1.SelectedItem);
            btnRemover.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Endereço de Email é obrigatório!", "Email inválido");
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("A senha é obrigatória!", "Senha inválida");
                return;
            }

            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Gmail")
                op = true;
            else
                op = false;
        }

        private void compactarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.SelectedPath;
                string zip = file + ".zip";
                ZipFile.CreateFromDirectory(file, zip);
            }
        }

        private void copyrightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Leonardo Narita" + Environment.NewLine + Environment.NewLine + "Last Version: March, 2020", "Copyright", MessageBoxButtons.OK);
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"contato.txt";

            try
            {
                LerArquivo(file);
            }
            catch
            {
                using (StreamWriter reader = new StreamWriter(file))
                {
                    reader.WriteLine("Nome: Leonardo Narita \nEmail: leo_narita@hotmail.com");
                }

                LerArquivo(file);
            }
            
        }

        private void LerArquivo(string file)
        {
            System.Diagnostics.Process.Start(file);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Enviar send = new Enviar();
            send.Envio(arq, txtEmail.Text, txtSenha.Text, txtPara.Text, txtCc.Text, txtCco.Text, txtAssunto.Text, txtMensagem.Text, op);

            if (Enviar.erro == false)
                MessageBox.Show("Email enviado com sucesso!", "Êxito");
        }
    }
}
