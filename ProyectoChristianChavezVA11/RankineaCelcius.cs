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
    public partial class RankineaCelcius : Form
    {
        public RankineaCelcius()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double r = double.Parse(RAC.Text);
                double c = (r - 491.67) * 5 / 9;
                label8.Text = $"{c:F2} °C";
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
    }
}
