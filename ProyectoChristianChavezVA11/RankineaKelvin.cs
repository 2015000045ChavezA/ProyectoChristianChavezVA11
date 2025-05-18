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
    public partial class RankineaKelvin : Form
    {
        public RankineaKelvin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(RAK.Text);
                double k = r * 5 / 9;
                label12.Text = $"{k:F2} K";
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
