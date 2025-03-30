using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samuel_e_Thiago
{
    public partial class frmnota : Form
    {
        int[] notas = new int[5];
        int i, soma = 0, x;
        public frmnota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 30; i++)
            {
                x = Convert.ToInt32(txtnota.Text);
                notas[i] = x;
                soma = soma + notas[i];
                txtnota.Clear();
                txtnota.Focus();
                break;
            }
        }
        private void btnmedia_Click(object sender, EventArgs e)
        {
            txtmedia.Text = (soma / 30).ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota.Clear();
            txtmedia.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
