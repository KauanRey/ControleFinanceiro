using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            * 
            * O que é uma variável?
            * Tipos de variáveis 
            * Declarar ou omitir o tipo var
            * 
            * var email = "ceci@gmail.com";
            *  int senha = 123456;
            */

            string email, senha;
            email = textBox1.Text;
            senha = textBox2.Text;

            MessageBox.Show($"Vó Cecilia seu email {email} esta correto?");


            MessageBox.Show("Olá C#");
        }
    }
}
