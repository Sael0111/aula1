namespace Samuel_e_Thiago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            int[] valor = new int[15];
            int i;
            for (i = 0; i < 15; i++) 
            {
                Random num = new Random();
                valor[i] = num.Next(1,100);
            }
            for(i=0; i < 15; i++)
            {
                if (valor[i] % 2 == 0)
                {
                    txtnum.Text = valor[i].ToString() + Environment.NewLine;
               }
            }
        }
    }
}
