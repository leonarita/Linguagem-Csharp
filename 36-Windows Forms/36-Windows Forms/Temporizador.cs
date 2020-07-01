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
    public partial class Temporizador : Form
    {
        int tempo = 0, minuto = 0, segundo = 0;

        public Temporizador()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            tempo = Convert.ToInt16(txtTempo.Text);

            if (tempo >= 60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }

            label2.Text = "0" + minuto + ":" + segundo;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;

            if (minuto>0)
            {
                if (segundo<0)
                {
                    segundo = 59;
                    minuto--;
                }
            }

            label2.Text = "0" + minuto + ":" + segundo;

            if (minuto==0 && segundo==0)
            {
                timer1.Enabled = false;
                pictureBox1.Visible = true;
            }
        }

        private void Temporizador_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
