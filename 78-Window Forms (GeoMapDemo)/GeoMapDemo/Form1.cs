using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoMapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            keyValues["CN"] = 81285;
            keyValues["US"] = 75066;
            keyValues["IT"] = 74384;
            keyValues["ES"] = 56196;
            keyValues["IR"] = 29046;
            keyValues["FR"] = 25233;
            keyValues["UK"] = 9849;
            keyValues["CA"] = 3579;
            keyValues["PK"] = 1179;
            keyValues["IN"] = 719;

            geoMap.HeatMap = keyValues;

            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}
