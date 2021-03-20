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
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                CF = double.Parse(txtCentigradosF.Text);

                F = (CF * 1.8) + 32;

                lbFarenheit.Text = F.ToString();
                lbFarenheit.Visible = true;
            }
            catch
            {
                if (txtCentigradosF.Text == "")
                {
                    MessageBox.Show("Informe o valor de Celsius para fazer a conversão");
                }
            }            
        }
        private void apenasNumerosVirgulas(object sender, KeyPressEventArgs tecla)//para evitar que digite letras e caracteres não usadas no campo de celsius
        {
            if (!char.IsNumber(tecla.KeyChar) && !(tecla.KeyChar == ',') && !(tecla.KeyChar == Convert.ToChar(8)) && !(tecla.KeyChar == '-'))
            {
                tecla.Handled = true;
            }
        }

        private void bntCalcularK_Click(object sender, EventArgs e)
        {
            try
            {
                CK = double.Parse(txtCentigradosK.Text);

                K = CK + 273.15;

                lbKelvin.Text = K.ToString();
                lbKelvin.Visible = true;
            }
            catch
            {
                MessageBox.Show("Informe o valor de Celsius para fazer a conversão");
            }
        }
    }
}
