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
    public partial class Media : Form
    {
        private double n1 = 0;
        private double n2 = 0;
        private double media = 0;
        public Media()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbMedia.Visible = false;
            try
            {
                n1 = double.Parse(txtNota1.Text);
                n2 = double.Parse(txtNota2.Text);

                media = (n1 + n2) / 2;

                lbMedia.Text = media.ToString();
                lbMedia.Visible = true;
            }
            catch
            {
                if (txtNota1.Text == "" && txtNota2.Text == "")
                {
                    MessageBox.Show("Para fazer o calculo informe os Campos");
                }
                else
                if(txtNota1.Text == "")
                {
                    MessageBox.Show("Primeira Nota não Informada");
                }
                else
                if (txtNota2.Text == "")
                {
                    MessageBox.Show("Segundo Nota não Informada");
                }
            }            
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
