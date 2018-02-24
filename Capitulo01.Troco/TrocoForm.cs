using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void TrocoForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
           

            //Definir as variáveis e inicializá-las
            decimal valorCompra = 0;
            decimal valorPago = 0;
            decimal troco = 0;

            //Converter os valores de tela para os tipos
            //correspondentes das variáveis
            valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            //Calcular a diferença a ser devolvida
            //troco, que foi chamado de resto
            troco = valorPago - valorCompra;

            //Passa o valor do calculo para o textbox
            valorTrocoTextBox.Text = troco.ToString("c");


            //Definir e atribuir o cálculo de moedas à variável
            int moedas1 = (int)(troco / 1);
            troco = troco % 1;

            int moedas50 = (int)(troco / 0.50m);
            troco = troco % 0.50m;

            int moedas25 = (int)(troco / 0.25m);
            troco = troco % 0.25m;

            int moedas10 = (int)(troco / 0.10m);
            troco = troco % 0.10m;

            int moedas05 = (int)(troco / 0.05m);
            troco = troco % 0.05m;

            int moedas01 = (int)(troco / 0.01m);
            troco = troco % 0.01m;

            moedasListView.Items[0].Text = moedas1.ToString();
            moedasListView.Items[1].Text = moedas50.ToString();
            moedasListView.Items[2].Text = moedas25.ToString();
            moedasListView.Items[3].Text = moedas10.ToString();
            moedasListView.Items[4].Text = moedas05.ToString();
            moedasListView.Items[5].Text = moedas01.ToString();


        }
    }
}
