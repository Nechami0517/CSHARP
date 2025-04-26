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
            CustomerLogin form = new CustomerLogin();
            form.ShowDialog();



          
        }
    }
}
