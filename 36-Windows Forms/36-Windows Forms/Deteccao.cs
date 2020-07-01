using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_Windows_Forms
{
    public partial class Deteccao : Form
    {
        public Deteccao()
        {
            InitializeComponent();
        }

        private void Deteccao_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = Convert.ToString(e.KeyValue);

            if (e.KeyValue == 38)
                label2.Text = "Seta para cima";
            else if(e.KeyValue == 40)
                label2.Text = "Seta para baixo";
        }
    }
}
