namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saleMan_Click(object sender, EventArgs e)
        {
            Login form = new Login(false);
            form.ShowDialog();




        }

        private void management_Click(object sender, EventArgs e)
        {
            Login form = new Login(true);
            form.ShowDialog();
        }
    }
}
