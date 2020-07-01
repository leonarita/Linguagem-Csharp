using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_Validar_CNPJ
{
    public partial class Form1 : Form
    {
        //83.196.414/0001-65

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validacao valid = new Validacao();

            mskCNPJ.TextMaskFormat = MaskFormat.IncludeLiterals;
            string cnpj = mskCNPJ.Text;
            bool verFal = valid.validarCNPJ(cnpj);

            if (verFal)
                MessageBox.Show("CNPJ Válido!");
            else
                MessageBox.Show("CNPJ Inválido!");
        }
    }
}
