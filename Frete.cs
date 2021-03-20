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
    public partial class Frete : Form
    {
        private double valorFrete = 0;
        private int quantidade = 0;
        private double peso = 0;
        public Frete()
        {
            InitializeComponent();
        }
        private void calcularFrete()
        {
            if (comboEstados.Text == "Amazonas (AM)" || comboEstados.Text == "Roraima (RR)" || comboEstados.Text == "Amapá (AP)" || comboEstados.Text == "Pará (PA)" || comboEstados.Text == "Tocantins (TO)" || comboEstados.Text == "Rondônia (RO)" || comboEstados.Text == "Acre (AC)")
            {
                //Norte 5 reais
                valorFrete = 5 * quantidade;
            }
            else
                if (comboEstados.Text == "Maranhão (MA)" || comboEstados.Text == "Piauí (PI)" || comboEstados.Text == "Ceará (CE)" || comboEstados.Text == "Rio Grande do Norte (RN)" || comboEstados.Text == "Pernambuco (PE)" || comboEstados.Text == "Paraíba (PB)" || comboEstados.Text == "Sergipe (SE)" || comboEstados.Text == "Alagoas (AL)" || comboEstados.Text == "Bahia (BA)")
            {
                //Nordeste 4 reais
                valorFrete = 4;
                valorFrete = 4 * quantidade;
            }
            else
                if (comboEstados.Text == "Mato Grosso (MT)" || comboEstados.Text == "Mato Grosso do Sul (MS)" || comboEstados.Text == "Goiás (GO)")
            {
                //Centro-Oeste 3 reais
                valorFrete = 3;
                valorFrete = 3 * quantidade;
            }
            else
                if (comboEstados.Text == "Paraná (PR)" || comboEstados.Text == "Rio Grande do Sul (RS)" || comboEstados.Text == "Santa Catarina (SC)")
            {
                //Sul 1 real
                valorFrete = 1;
                valorFrete = 1 * quantidade;
            }
            else
                if (comboEstados.Text == "São Paulo (SP)" || comboEstados.Text == "Rio de Janeiro (RJ)" || comboEstados.Text == "Espírito Santo (ES)" || comboEstados.Text == "Minas Gerais (MG)")
            {
                //Sudeste 2 reais
                valorFrete = 2;
                valorFrete = 2 * quantidade;
            }
            if (peso >= 0.1)
            {
                peso = peso / 0.1;
                valorFrete += peso * 0.25;
            }
            else
            {
                valorFrete += 0.25;
            }
            valorFrete = Math.Round(valorFrete, 2);//como trabalha com centavo tem que aredondar para 2 casas
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            lbresulfrete.Visible = false;
            try
            {
                quantidade = Int32.Parse(comboQuantidade.Text);                
                peso = double.Parse(txtpeso.Text);
                calcularFrete();
                lbresulfrete.Text = valorFrete.ToString();
                lbresulfrete.Visible = true;
            }
            catch
            {
                if (comboQuantidade.Text == "" && comboEstados.Text == "" && txtpeso.Text == "")
                {
                    MessageBox.Show("Nenhuma informação adicinada");
                }
                else
                if (comboQuantidade.Text == "")
                {
                    MessageBox.Show("Informe Quantidade a ser enviada");
                }
                else
                if (comboEstados.Text == "")
                {
                    MessageBox.Show("Informe o Estado a ser enviado");
                }
                else
                if(txtpeso.Text == "")
                {
                    MessageBox.Show("Informe o Peso total do Produto");
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
        private void naoPodeDigitar(object sender, KeyPressEventArgs tecla)
        {
            tecla.Handled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 1; i <= 100; i++ )
            {
                comboQuantidade.Items.Add(i);
            }
        }
    }
}
