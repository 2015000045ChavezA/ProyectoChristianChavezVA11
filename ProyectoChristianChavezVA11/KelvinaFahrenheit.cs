using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoChristianChavezVA11
{
    public partial class KelvinaFahrenheit : Form
    {
        public KelvinaFahrenheit()
        {
            InitializeComponent();
        }

        private void KAF_Click(object sender, EventArgs e)
        {
            try
            {
                double k = double.Parse(KAF.Text);
                double f = (k - 273.15) * 9 / 5 + 32;
                label6.Text = $"{f:F2} °F";
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
