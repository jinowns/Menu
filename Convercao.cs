using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Convercao : Form
    {
        private double CF = 0;
        private double CK = 0;
        private double F = 0;
        private double K = 0;
        public Convercao()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            CK = double.Parse(txtCentigradosK.Text);

            K = CK + 273.15;

            lbKelvin.Text = K.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CF = double.Parse(txtCentigradosF.Text);

            F = (CF * 1.8) + 32;

            lbFarenheit.Text = F.ToString();
        }
        private void apenasNumerosVirgulas(object sender, KeyPressEventArgs tecla)
        {
            if (!char.IsNumber(tecla.KeyChar) && !(tecla.KeyChar == ',') && !(tecla.KeyChar == Convert.ToChar(8)))
            {
                tecla.Handled = true;
            }
        }
    }
}
