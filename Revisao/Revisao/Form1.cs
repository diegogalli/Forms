using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string nome = Microsoft.VisualBasic.Interaction.InputBox("Informe o nome", "", "");
            //string Sobrenome = Microsoft.VisualBasic.Interaction.InputBox("Informe o sobrenome", "", "");
            //label1.Text = "Olá tudo bem? " + nome + " " + Sobrenome; 

            int qtde = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite um numero: "));
            for (int i = 1; i <= qtde; i++)
            {
                //string nome = Microsoft.VisualBasic.Interaction.InputBox("Entre com o seu nome: ","","");
                //listView1.Items.Add(nome + "--" + Convert.ToString(nota));
                //listView1.Items.Add("");
                int numero = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Entre com um numero: ", "", ""));
                if (numero % 2 == 0)
                {
                    listView1.Items.Add(Convert.ToString(numero) + "-" + "Par");
                    listView1.Items.Add("");

                }
                else
                {
                    listView1.Items.Add(Convert.ToString(numero) + "-" + "Impar");
                    listView1.Items.Add("");

                }

            }
            label1.Text = "Quantidade de nmeros digitados";
            label2.Text = Convert.ToString(listView1.Items.Count / 2);

        }
    }
}
