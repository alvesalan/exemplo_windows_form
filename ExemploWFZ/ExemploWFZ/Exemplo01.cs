using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFZ
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
            MessageBox.Show("A soma é: " + (2 + 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txtNota1.Text;
            string sobrenomeDoUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + " " + sobrenomeDoUsuario);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;

            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);


            }
            catch (Exception)
            {

                MessageBox.Show("Nota 1 so deve conter somente numeros reais");
                return;
            }

            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nota 2 so deve conter somente numeros reais");
                return;
            }

            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nota 3 so deve conter somente numeros reais");
                return;
            }

            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nota 4 so deve conter somente numeros reais");
                return;
            }
            double Nota1 = Convert.ToDouble(txtNota1.Text);
            double Nota2 = Convert.ToDouble(txtNota2.Text);
            double Nota3 = Convert.ToDouble(txtNota3.Text);
            double Nota4 = Convert.ToDouble(txtNota4.Text);

            double Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;


            string textao = string.Format("Nota 1: {0}\r\nNota2: {1}\r\nNota3: {2}\r\nNota4: {3}\r\nMedia: {4}", nota1, nota2, nota3, nota4, Media);

            txtResultado.Text = textao;
           // MessageBox.Show(string.Format("A média e: {0:n}", Media));

        }

        private void tetNota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int Idade = Convert.ToInt32(txtIdade.Text);
                if (Idade < 0)
                {
                    MessageBox.Show("Idade não pode ser menor que 0");
                    txtIdade.Focus();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
