using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo02.Tabuada
{
    public partial class tabuadaForm : Form
    {
        public tabuadaForm()
        {
            InitializeComponent();
        }

        private void tabuadaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //Permitir apenas NÚMEROS, BACKSPACE e ENTER
                if (
                e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == '\b' || e.KeyChar == '\r')
                {
                    //Se a tecla pressionada for ENTER,
                    //chamar o método CalcularTabuada()
                    if (e.KeyChar == '\r')
                    {
                        CalcularTabuada();
                    }
                }
                else
                {
                    //Caso não seja uma tecla válida,
                    //anular a tecla digitada
                    e.KeyChar = '\0';
                }
            }
        }

        //Definir o método CalcularTabuada() aqui ...
        private void CalcularTabuada()
        {
            //Limpar a lista anterior
            tabuadaListBox.Items.Clear();
            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);
            //Calcular a tabuada
            for (int i = 0; i <= 10; i++)
            {
                tabuadaListBox.Items
                .Add(tabuada + " x " + i + " = " +
                (tabuada * i).ToString("#,##0"));
            }
            tabuadaTextBox.Focus();
            tabuadaTextBox.SelectAll();
        }

        //Definir o método LimparTela() aqui ...
        private void LimparTela()
        {
            tabuadaTextBox.Clear();
            tabuadaListBox.Items.Clear();
            tabuadaTextBox.Focus();
        }
    }
}
