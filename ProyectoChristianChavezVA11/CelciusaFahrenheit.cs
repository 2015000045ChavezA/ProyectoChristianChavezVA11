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
    public partial class CelciusaFahrenheit : Form
    {
        public CelciusaFahrenheit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(textBox1.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                label3.Text = $"{fahrenheit:F2} °F";
            }
            catch
            {
                MessageBox.Show("Por favor ingresa un número válido.");
            }
        }
    }
}
