using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNet.Cap001.Frete
{
    public partial class freteForm : Form
    {
        public freteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();


            if (erros.Count == 0)//para chamar a estrutura do if, digitar if + tab + tab
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, erros),
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);//entregar uma lista em cada linha
            }
        }
        //Método tem de ter o parenteses fechado no final
        //Para chamar a propriedade ctrl + .
        private void Calcular() {
            var percentual = 0m;//inserir o m após o número transforma o var em decimal
            var valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<string> { "BA", "AL", "CE" };

            switch (ufComboBox.Text.ToUpper())//Converter maiúsculas
            {
                case "SP":
                    percentual = 0.2m;
                    break;
                case "RJ":
                case "ES"://EMPILHAMENTO MAIS DE UMA OÇÃO USANDO A MESMA VARIÁVEL

                    percentual = 0.3m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "AM":
                    percentual = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf):
                    percentual = 0.4m;
                    break;


                default:
                    break;
            }

            //if (ufComboBox.Text.ToUpper() == "SP") {
            //    percentual = 0.2m;
            //} else if (ufComboBox.Text.ToUpper() == "RJ" || ufComboBox.Text.ToUpper() == "ES") {
            //    percentual = 0.3m;
            //} else if (ufComboBox.Text.ToUpper() == "MG") {
            //    percentual = 05m;
            //} else {
            //    percentual = 0.5m
            //}
      

            freteTextBox.Text = percentual.ToString("p2");//p2 significa percentual de duas casas
            totalTextBox.Text = ((1 + percentual) * valor).ToString("C");//C representa moeda com duas casas decimais defaut

        }

        private List<string> ValidarFormulario()//List é genérica posso inserir
        {
            var erros = new List<string>();

            //if (clienteTextBox.Text == string.Empty)
            if (clienteTextBox.Text.Trim() == string.Empty)//.Trim remove espaços das extremidades
                {
                erros.Add("O campo Cliente é obrigatório!");
                clienteTextBox.Focus();
                }
            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione a UF!");
                ufComboBox.Focus();
            }
            if (string.IsNullOrEmpty(valorTextBox.Text.Trim()))
            {
                erros.Add("Insira o valor!");
                valorTextBox.Focus();
            }
            else
            {
                if (!decimal.TryParse(valorTextBox.Text.Trim(), out decimal valorConvertido))//Se não for númerico entra no laço
                {
                    erros.Add("O campo Valor deve ser númerico.");
                }
            }

            return erros;
        }

        private void limparButton_Click(object sender, EventArgs e) {
            clienteTextBox.Clear();
            valorTextBox.Text = "";
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Text = null;
            totalTextBox.Text = string.Empty;
            clienteTextBox.Focus();

        }
    }
}
