using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
                
    {
        int _x = 32;
        int _y = 32;
        int _z = 32;
        int _w = 45;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            int d = 13;

            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("b = " + b);
            resultadoListBox.Items.Add("c = " + c);
            resultadoListBox.Items.Add("d = " + d);

            resultadoListBox.Items.Add(new string('-',50));

            resultadoListBox.Items.Add("c * d = " + (c * d));
            resultadoListBox.Items.Add("c / a = " + (c / a));
            resultadoListBox.Items.Add("d % a = " + (d % a));

            //decimal valor = 40;
            //string nomeCliente = "Marcelo";
            //bool habilidado = false;
            //var dataNascimento = new DateTime(1985,09,16); 

            //if (a == 14)
            //{

            //}
            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("x = " + x);

            //x = x -3;
            x -= 3;

            resultadoListBox.Items.Add("x = " + x);

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void incrementaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pré-Incremental");
            resultadoListBox.Items.Add("a = " +a);
            resultadoListBox.Items.Add("2 + ++a = " + (2 + ++a));

            a = 5;
            resultadoListBox.Items.Add("Exemplo de Pros-Incremental");
            resultadoListBox.Items.Add("a = " + a);
            resultadoListBox.Items.Add("2 + a++ = " + (2 + a++));

        }

        private void boleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

            resultadoListBox.Items.Add("w <= x = " + (_y <= _x)); // W é Menos ou Igual a X
            resultadoListBox.Items.Add("x == z = " + (_x == _z)); // X é igual a Z
            resultadoListBox.Items.Add("x != z = " + (_x != _z)); // X é Diferente de Z



        }

        private void MostrarVariaveis()
        {
            resultadoListBox.Items.Add("x =" + _x);
            resultadoListBox.Items.Add("y =" + _y);
            resultadoListBox.Items.Add("z =" + _z);
            resultadoListBox.Items.Add("w =" + _w);
        }

        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVariaveis();

            resultadoListBox.Items.Add("Y <= X || y == 16 = " + (_y <= _x || _y == 16 ));
            resultadoListBox.Items.Add("_x == _z && _x != _x = " + (_x == _z && _x != _x));
            resultadoListBox.Items.Add("_y > _w = " + (_y > _w));

        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2014;

            resultadoListBox.Items.Add("Ano = " + ano);
            resultadoListBox.Items.Add(string.Format("O ano (0) é Bissesto? (1)",ano,
                ano % 4 == 0 ? "Sim" : "Não"));

        }
    }
}
