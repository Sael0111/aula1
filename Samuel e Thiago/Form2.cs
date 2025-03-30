using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samuel_e_Thiago
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numerosAleatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmnum menu = new frmnum();
            menu.Show();
        }

        private void mediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmnota menu = new frmnota();
            menu.Show();
        }
    }
}
