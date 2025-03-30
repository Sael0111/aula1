namespace Samuel_e_Thiago
{
    public partial class frmnum : Form
    {
        public frmnum()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            int[] valor = new int[15];
            int i;
            Random num = new Random();
            for (i = 0; i < 15; i++)
            {
                valor[i] = num.Next(1, 100);
            }
            for (i = 0; i < 15; i++)
            {
                if (valor[i] % 2 == 0)
                {
                    txtnum.Text += valor[i].ToString() + Environment.NewLine;
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
