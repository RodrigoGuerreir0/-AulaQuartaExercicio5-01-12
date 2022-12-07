using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoNovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            primeiraMensagem.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botao_Click(object sender, EventArgs e)
        {
            primeiraMensagem.Visible = true;
            primeiraMensagem.Text = "Olá tudo bem, gostaria de realizar o seu cadastro";
        }

        private void primeiraMensagem_Click(object sender, EventArgs e)
        {

        }

        private void segundaMensgem_Click(object sender, EventArgs e)
        {

        }

        private void botao2_Click(object sender, EventArgs e)
        {
            segundaMensgem.Text = "Mais 5 minutinhos";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao3_Click(object sender, EventArgs e)
        {
            terceiraMensagem.Visible = false;
        }
    }
}
