using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo02.Fretes
{
    public partial class fretesForm : Form
    {
        public fretesForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            //Limpar os resultados do cálculo anterior
            percentualTextBox.Text = string.Empty;
            totalTextBox.Text = string.Empty;
            //Consistir os dados
            if (clienteTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome é obrigatório", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                clienteTextBox.Focus();
                return;
            }
            else if (valorTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Valor da compra é obrigatório", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valorTextBox.Focus();
                return;
            }
            else if (ufComboBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Selecione um estado na lista", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ufComboBox.Focus();
                return;
            }
            //Chamar o método Calcular()
            Calcular();
        
    }

        private void Calcular()
        {
            //Definir variáveis
            decimal valor = 0;
            decimal perc = 0;
            valor = Convert.ToDecimal(valorTextBox.Text);


            //Definir o percentual de acordo com o Estado
            switch (ufComboBox.Text.ToUpper())
            {
                case "MG":
                    perc = 0.6m; break;
                case "SP":
                    perc = 0.35m; break;
                case "RJ":
                    perc = 0.3m; break;
                case "RS":
                    perc = 0.2m; break;
                default:
                    perc = 0.75m; break;
            }
            //Devolver na tela o valor da textbox formatado
            valorTextBox.Text = valor.ToString("N2");
            //Devolver na tela o valor do frete calculado
            percentualTextBox.Text = perc.ToString("P1");
            totalTextBox.Text = (valor * (1 + perc)).ToString("C2");
        }

        //Definir o método LimparTela() aqui ...
        private void LimparTela()
        {
            clienteTextBox.Clear();
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            percentualTextBox.Text = string.Empty;
            totalTextBox.Text = string.Empty;
            clienteTextBox.Focus();
        }

        private void fretesForm_Load(object sender, EventArgs e)
        {
            ufComboBox.SelectedIndex = -1;
        }
    }
}
