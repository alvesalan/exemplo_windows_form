using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";
            if (!cb_leu.AutoCheck)
            {
                texto += "Você foi verdadeiro\n";
            }
            else
            {
                texto += "Você acaba de vender seu tempo\n";
            }

            if (cb_comprou.Checked)
            {
                texto += "Parabens tem o 7zip open source\n";
            }
            else
            {
                texto += "Vai comprar o Winrar menino(a) malandrinho(a)\n";
            }
            MessageBox.Show(texto);
        }
    }
}
