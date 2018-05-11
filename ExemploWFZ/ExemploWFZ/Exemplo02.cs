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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text.Trim();
            int QuantidadedeHoras = Convert.ToInt32(txtQuantidadeHora.Text);
            double ValorHora = Convert.ToDouble(txtValorHora.Text);
            double Salario = QuantidadedeHoras * ValorHora;

            string UnidadeFederativa = cbUnidadeFederativa.SelectedItem.ToString();
            string Cidade = txtCidade.Text.Trim(); 
            string Bairro = txtBairro.Text.Trim();
            string Logadouro = txtLogadouro.Text.Trim();
            string Complemento = txtCpmplemento.Text.Trim();
            string Numero = txtNumero.Text.Trim();
            bool ehFemea = RbFemea.Checked;
            string DataNascimento = dtpDataNascimento.Text;

            if (Salario < 1000)
            {
                MessageBox.Show("Professor de LoL");
            }
            else if (Salario < 10000)
            {
                MessageBox.Show("Professor de Fortnite");
            }
            else if (Salario < 100000)
            {
                MessageBox.Show("Professor de Dota 2");
            }
            else if (Salario < 500000)
            {
                MessageBox.Show("Mestre Junia de Tibia");
            }
            else
            {
                MessageBox.Show("Mestre Pleno de Tibia");
            }
           

        }
    }
}
