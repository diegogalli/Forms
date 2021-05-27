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

            int qtde = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Entre com a quantidade de alunos: "));
            for (int i = 1; i <= qtde; i++)
            {

            }

        }
    }
}
