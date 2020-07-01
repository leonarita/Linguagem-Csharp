using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace _23_Windows_Forms
{
    public partial class Form1 : Form
    {
        Thread t1;

        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre a segunda janela
            janela Tela = new janela();
            Tela.Show();

            //Esconde essa janela atual -> Não é recomendável usar
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Solução 1
            //    NovaJanela j2 = new NovaJanela();
            //    j2.Show();

            //Solução 2
            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);         //Configura a thread (STA -> Single Thread, para janela única)
            t1.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new NovaJanela());
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdicionaItem.Text))
            {
                MessageBox.Show("Digite um item para selecionar à lista", "Caixa Vazia");
            }
            else
            {
                lstAnimais.Items.Add(txtAdicionaItem.Text);
                txtAdicionaItem.Clear();
                txtAdicionaItem.Focus();
            }
        }

        private void btnPreenche_Click(object sender, EventArgs e)
        {
            if (lstAnimais.Items.Count == 0)
            {
                string[] bichos = new string[10] { "Jacaré", "Onça", "Elefante", "Gato", "Cão", "Papagaio", "Lontra", "Golfinho", "Foca", "Tatu" };
                lstAnimais.Items.AddRange(bichos);
            }
            else
            {
                MessageBox.Show("Lista está preenchida!", "Lista preenchida");
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            lstAnimais.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lstAnimais.SelectedIndices.Count - 1; i>=0; i--)
            {
                lstAnimais.Items.RemoveAt(lstAnimais.SelectedIndices[i]);
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            //Se nada for selecionado
            if (lstAnimais.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um item da lista", "Item não selecionado");
            }

            //Se algo for selecionado
            else
            {
                string item = lstAnimais.SelectedItem.ToString();
                MessageBox.Show("Item selecionado: " + item, "Item selecionado");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstAnimais.Sorted = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.microsoft.com/pt-br/dotnet");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
