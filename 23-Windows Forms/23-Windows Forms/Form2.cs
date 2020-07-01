using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_Windows_Forms
{
    public partial class janela : Form
    {
        public janela()
        {
            InitializeComponent();
        }

        private void janela_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Se não tiver nenhuma janela aberta, sai da aplicação
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }

            //Caso haja alguma janela aberta, mostre-a
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    formAberto.Show();
                    break;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
