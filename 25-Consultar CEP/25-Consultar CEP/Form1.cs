using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_Consultar_CEP
{
    public partial class frmConsultarCEPs : Form
    {
        public frmConsultarCEPs()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCEP.Text))
            {
                using (var ws = new wsCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtCEP.Text.Trim());

                        txtEstado.Text = endereco.uf;
                        txtCidade.Text = endereco.cidade;
                        txtBairro.Text = endereco.bairro;
                        txtRua.Text = endereco.end;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Informe um CEP válido!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCEP.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtEstado.Text = String.Empty;
            txtRua.Text = String.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
