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
    public partial class Exemplo06 : Form
    {
        public Exemplo06()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int quantidade = Convert.ToInt32(nud_Quantidade1.Value);
                double valor = Convert.ToDouble(mtb_Valor1.Text);
                double valorTotal = quantidade * valor;
                lb_ValorTotal1.Text = Convert.ToString(valorTotal);
                btn_Execultar.PerformClick();
            }
            else if (e.KeyCode != Keys.NumPad9 && e.KeyCode != Keys.NumPad8)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
