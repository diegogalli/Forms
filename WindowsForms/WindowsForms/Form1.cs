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

            string nome = Microsoft.VisualBasic.Interaction.InputBox("Informe o nome", "nome", "");
            label1.Text = "Olá " + nome;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float a = Convert.ToInt32(textBox1.Text);
            //float b = Convert.ToInt32(textBox2.Text);
            //float c = a + b;
            //label1.Text = Convert.ToString(c);
        }
    }
}
