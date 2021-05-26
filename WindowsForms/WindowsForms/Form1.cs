using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //String Mensagem;
            //Mensagem = "Bem vindo DG Informática";
            //label1.Text = Mensagem;

            //int hora = DateTime.Now.Hour;
            //int minuto = DateTime.Now.Minute;
            //label1.Text = hora + ":" + minuto;

            //string VarEscreve;
            //VarEscreve = "Teste de variavel";
            //MessageBox.Show(VarEscreve);

            //int[] numeros = new int[5];
            //numeros[0] = 1;
            //numeros[1] = 100;
            //numeros[2] = 200;
            //numeros[3] = 400;
            //numeros[4] = 800;
            //MessageBox.Show("Numero = " + numeros[3]);

            //string nome = Microsoft.VisualBasic.Interaction.InputBox("Informe o nome", "nome", "");
            //string sobrenome = Microsoft.VisualBasic.Interaction.InputBox("Informe o sobrenome", "nome", "");
            //label1.Text = "Olá " + nome + " " +sobrenome + " Bem vindo";

            //string nome = Microsoft.VisualBasic.Interaction.InputBox("Informe o nome", "", "");
            //string sobrenome = Microsoft.VisualBasic.Interaction.InputBox("Informe o sobrenome", "", "");
            //string idade = Microsoft.VisualBasic.Interaction.InputBox("Informe a idade", "", "");

            //listView1.Items.Add(nome);
            //listView1.Items.Add("");
            //listView1.Items.Add(sobrenome);
            //listView1.Items.Add("");
            //listView1.Items.Add(idade);
            //listView1.Items.Add("");

            //int hora = DateTime.Now.Hour;
            //int minuto = DateTime.Now.Minute;

            //label1.Text = hora + ":" + minuto;
            //if (hora < 12)
            //{
            //    label2.Text = "Bom dia";
            //}
            //else if (hora >= 12 && hora < 18)
            //{
            //    label2.Text = "Boa tarde";
            //}
            //else if (hora >= 18)
            //{
            //    label2.Text = "Boa noite";
            //}

            for(int i = 1; i<= 10; i++)
            {
                listView1.Items.Add("Linha - " + Convert.ToString(i));
                listView1.Items.Add("");
            }
            label1.Text = Convert.ToString(listView1.Items.Count / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float a = Convert.ToInt32(textBox1.Text);
            //float b = Convert.ToInt32(textBox2.Text);
            //float soma = a + b;
            //float sub = a - b;
            //float prod = a * b;
            //float div = a / b;
            //float media = (a + b) / 2;
            //listView1.Items.Add("Soma: " + Convert.ToString(soma));
            //listView1.Items.Add("");
            //listView1.Items.Add("Subtração: " + Convert.ToString(sub));
            //listView1.Items.Add("");
            //listView1.Items.Add("Produto: " + Convert.ToString(prod));
            //listView1.Items.Add("");
            //listView1.Items.Add("Divisão: " + Convert.ToString(div));
            //listView1.Items.Add("");
            //listView1.Items.Add("Média: " + Convert.ToString(media));
            //listView1.Items.Add("");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string a = textBox1.Text;
            //string b = textBox2.Text;
            //float res = a / b;
            //MessageBox.Show(Convert.ToString(res));            
            //if (a == b)
            //{
            //    MessageBox.Show("Iguais");
            //}
            //else
            //{
            //    MessageBox.Show("Diferentes");
            //}

        
        }
        
    }
}
