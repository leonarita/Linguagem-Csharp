using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_Windows_Forms
{
    public partial class Form1 : Form
    {
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNome.Text;
            DateTime dataNascimento = dateDNasc.Value;
            string cidade = comboBox1.Text;
            bool generoM = radioButton1.Checked;
            bool generoF = radioButton2.Checked;

            int numeroCadastro = Convert.ToInt32(txtNumero.Text);

            int i = CalculateIdade(dataNascimento);

            MessageBox.Show(nomeUsuario + ", você tem " + i + " anos.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (i == numeroCadastro)
                MessageBox.Show("Conta bem sucedida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Você informou sua idade correta?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        public static int CalculateIdade(DateTime DataNascimento)
        {
            int anos = DateTime.Now.Year - DataNascimento.Year;

            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
                anos--;

            return anos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Temporizador());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm2()
        {
            Application.Run(new Deteccao());
        }
    }
}
