using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo04
{
    public partial class Exemplo04 : Form
    {
        public Exemplo04()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_sim.Checked)
            {
                rb_sim.ForeColor = Color.Green;
                rb_nao.ForeColor = Color.Black;
                gb_nomedojogo.Visible = true;
            }
            else
            {
                rb_sim.ForeColor = Color.Black;
                rb_nao.ForeColor = Color.Red;
                gb_nomedojogo.Visible = false;
            }
        }






        private void gb_gostadejogo_Enter(object sender, EventArgs e)
        {

        }
    }
}
