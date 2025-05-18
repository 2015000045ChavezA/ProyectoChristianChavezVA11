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
    public partial class RankineaFahrenheit : Form
    {
        public RankineaFahrenheit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(RAF.Text);
                double f = r - 459.67;
                label10.Text = $"{f:F2} °F";
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
