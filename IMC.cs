using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Menu
{
    public partial class IMC : Form
    {
        private double peso = 0;
        private double altura = 0;
        private double resultado = 0;
        private int alxiliar = 0;
        public IMC()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lbMuitoAbaixo.Visible = false;
                lbAbaixa.Visible = false;
                lbNormal.Visible = false;
                lbAcimadoPeso.Visible = false;
                lbOb1.Visible = false;
                lbOb2.Visible = false;
                lbOb3.Visible = false;
                alxiliar = 1;

                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);

                resultado = peso / Math.Pow(altura, 2);
                resultado = Math.Round(resultado, 2);

                lbIMC.Text = resultado.ToString();
                if (resultado < 17)
                {
                    timer1.Enabled = true;
                }
                else if (resultado >= 17 && resultado <= 18.49)
                {
                    timer1.Enabled = true;
                }
                else if (resultado >= 18.5 && resultado <= 24.99)
                {
                    timer1.Enabled = true;
                }
                else if (resultado >= 25 && resultado <= 29.99)
                {
                    timer1.Enabled = true;
                }
                else if (resultado >= 30 && resultado <= 34.99)
                {
                    timer1.Enabled = true;
                }
                else if (resultado >= 35 && resultado <= 39.99)
                {
                    timer1.Enabled = true;
                }
                else if (resultado > 40)
                {
                    timer1.Enabled = true;
                }
            }
            catch
            {
                if(txtPeso.Text == "" && txtAltura.Text == "")
                {
                    MessageBox.Show("Peso e Alturanão informado");
                }
                else if (txtPeso.Text == "")
                {
                    MessageBox.Show("Peso não informado");
                }
                else if (txtAltura.Text == "")
                {
                    MessageBox.Show("Altura não informado");
                }
            }
        }
        private int auxBreak = 0;
        bool desligaTimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            auxBreak++;
            if (desligaTimer)
            {
                lbMuitoAbaixo.Visible = false;
                lbAbaixa.Visible = false;
                lbNormal.Visible = false;
                lbAcimadoPeso.Visible = false;
                lbOb1.Visible = false;
                lbOb2.Visible = false;
                lbOb3.Visible = false;
                desligaTimer = false;
            }
            else if (resultado < 17)
            {
                lbMuitoAbaixo.Visible = true;
                desligaTimer = true;


            }
            else if (resultado >= 17 && resultado <= 18.49)
            {
                lbAbaixa.Visible = true;
                desligaTimer = true;
            }
            else if (resultado >= 18.5 && resultado <= 24.99)
            {
                lbNormal.Visible = true;
                desligaTimer = true;
            }
            else if (resultado >= 25 && resultado <= 29.99)
            {
                lbAcimadoPeso.Visible = true;
                desligaTimer = true;
            } 
            else if (resultado >= 30 && resultado <= 34.99)
            {
                lbOb1.Visible = true;
                desligaTimer = true;
            }
            else if (resultado >= 35 && resultado <= 39.99)
            {
                lbOb2.Visible = true;
                desligaTimer = true;
            }
            else
            {
                lbOb3.Visible = true;
                desligaTimer = true;
            }

            if (auxBreak > 100)
                timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            lbMuitoAbaixo.Visible = false;
            lbAbaixa.Visible = false;
            lbNormal.Visible = false;
            lbAcimadoPeso.Visible = false;
            lbOb1.Visible = false;
            lbOb2.Visible = false;
            lbOb3.Visible = false;
            desligaTimer = false;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs tecla)
        {
            if (!char.IsNumber(tecla.KeyChar) && !(tecla.KeyChar == ',') && !(tecla.KeyChar == Convert.ToChar(8)))
            {
                tecla.Handled = true;
            }
        }
    }
}
