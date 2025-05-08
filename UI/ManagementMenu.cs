using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagementMenu : Form
    {
        public ManagementMenu()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            ProductManagement form = new ProductManagement();
            form.ShowDialog();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            CustomerManagment from = new CustomerManagment();
            from.ShowDialog();
        }

        private void sales_Click(object sender, EventArgs e)
        {

        }
    }
}
