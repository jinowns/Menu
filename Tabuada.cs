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
    public partial class Tabuada : Form
    {
        private int numero1 = 0;
        private int numero2 = 0;
        private int resul = 0;
        private int cont = 100;
        private int resulTabuada = 0;
        public Tabuada()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Int32.Parse(txtN1.Text);
                numero2 = Int32.Parse(txtN2.Text);

                resul = numero1 * numero2;

                lbTabuada.Text = resul.ToString();

                if (numero2 > cont)
                {
                    cont = numero2;
                }
                for (int i = 1; i <= cont; i++)
                {
                    resulTabuada = numero1 * i;
                    if (i == numero2)
                    {
                        box.Items.Add(numero1.ToString() + "x" + i + "=" + resulTabuada + " <=");
                    }
                    else
                    {
                        box.Items.Add(numero1.ToString() + "x" + i + "=" + resulTabuada);
                    }
                }
            }
            catch
            {
                if (txtN1.Text == "" && txtN2.Text == "")
                {
                    MessageBox.Show("Para fazer o calculo informe os Campos");
                }
                else
                if (txtN1.Text == "")
                {
                    MessageBox.Show("Primeiro Campo não Informada");
                }
                else
                if (txtN2.Text == "")
                {
                    MessageBox.Show("Segundo Campo não Informada");
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
