using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Base = Convert.ToInt32(textBox1.Text);
            float Altura = Convert.ToInt32(textBox2.Text);
            float area = Base * Altura;
            label3.Text = " A área do retangulo é: " + Convert.ToString(area);
        }
    }
}
