using System;
using System.Drawing;
using System.Windows.Forms;

namespace _22_Paletas_de_Cores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCorTexto_Click(object sender, EventArgs e)
        {
            ColorDialog cdgCaixaCores2 = new ColorDialog();
            cdgCaixaCores2.AllowFullOpen = false;
            cdgCaixaCores2.AnyColor = true;
            cdgCaixaCores2.SolidColorOnly = false;
            cdgCaixaCores2.Color = Color.Blue;

            //Quando apertar "OK", vai alterar a cor do texto
            if (cdgCaixaCores2.ShowDialog() == DialogResult.OK)
            {
                txtCores.ForeColor = cdgCaixaCores2.Color;
            }
        }

        private void btnCorFundo_Click_1(object sender, EventArgs e)
        {
            //Quando apertar "OK", vai alterar a cor de fundo
            if (cdgCaixaCores.ShowDialog() == DialogResult.OK)
            {
                txtCores.BackColor = cdgCaixaCores.Color;
            }
        }
    }
}
