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
    public partial class CelciusaKelvin : Form
    {
        public CelciusaKelvin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double c = double.Parse(CAK.Text);
                double k = c + 273.15;
                label3.Text = $"{k:F2} K";
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
