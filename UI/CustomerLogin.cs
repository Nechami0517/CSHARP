﻿using BlApi;
using BO;
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
    public partial class CustomerLogin : Form
    {
        BlApi.IBl _bl = BlApi.Factory.GetBl();

        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerId = (int.TryParse(textBoxId.Text, out int temp) && temp != 0) ? temp : 0;
            Customer customer = null;
            Order order = new Order(false);
            try
            {
                customer = _bl.Customer.Read(customerId);
            }
            catch
            {
               // MessageBox.Show("Customer not found");
                order.IsPreferredCustomer = false;
            }
           
            if (customer != null)
            {
                order.IsPreferredCustomer = true;
            }
            SaleManMenu form = new SaleManMenu(order);
            form.ShowDialog();
        }
    }
}
