using BO;
using DO;
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
    public partial class CustomerManagment : Form
    {
        BlApi.IBl _bl = BlApi.Factory.GetBl();
        List<BO.Customer> customersList;
        public CustomerManagment()
        {
            InitializeComponent();
            UpdateDetails();
            CustomerManagment_Load();
        }
        private void UpdateDetails()
        {
            customersList = _bl.Customer.ReadAll();
            רשימת_לקוחות.DataSource = customersList;
            updateNameComboBox.DataSource = customersList.Select(c => c.CustomerName).ToList();
            deleteComboBox.DataSource = customersList.Select(c => c.CustomerName).ToList();
        }
        private void CustomerManagment_Load()
        {
            idNumericUpDown.Maximum = 10000000000;
            idNumericUpDown.Minimum = 0;
            numberPhoneNumbernumericUpDown.Maximum = 10000000000;
            numberPhoneNumbernumericUpDown.Minimum = 0;
            updatePhoneNumbernumericUpDown.Maximum = 10000000000;
            updatePhoneNumbernumericUpDown.Minimum = 0;
            searchIdNumericUpDown.Maximum = 1000000000;
            searchIdNumericUpDown.Minimum = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {

                int customerId = (int)idNumericUpDown.Value;
                string customerName = nameTextBox.Text;
                string customerAdress = adressTextBox.Text;
                string customerPhoneNumber = numberPhoneNumbernumericUpDown.Text;
                BO.Customer customer = new BO.Customer(customerId, customerName, customerAdress, customerPhoneNumber);
                _bl.Customer.Create(customer);
            }
            catch (BlIdExist ex)
            {
                MessageBox.Show("Error: Customer ID already exists.");
            }
            catch
            {
                MessageBox.Show("Error: Please check the input values.");
            }

            finally
            {
                customersList = _bl.Customer.ReadAll();

                UpdateDetails();
                idNumericUpDown.Value = 0;
                nameTextBox.Text = "";
                adressTextBox.Text = "";
                numberPhoneNumbernumericUpDown.Text = "";

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {


                string customerName = updateNameComboBox.Text;
                int customerId = _bl.Customer.ReadAll().FirstOrDefault(c => c.CustomerName == customerName).CustomerId;
                string customerAdress = updateAdressTextBox.Text;
                string customerPhoneNumber = updatePhoneNumbernumericUpDown.Text;
                BO.Customer customer = new BO.Customer(customerId, customerName, customerAdress, customerPhoneNumber);
                _bl.Customer.Update(customer);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in updateCustomerUI: " + ex.Message);
            }
            finally
            {
                UpdateDetails();
                updateNameComboBox.Text = "";
                updateAdressTextBox.Text = "";
                updatePhoneNumbernumericUpDown.Text = "";
            }
        }

        private void updateNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string customerName = updateNameComboBox.Text;
                BO.Customer customer = _bl.Customer.ReadAll().FirstOrDefault(c => c.CustomerName == customerName);

                updateNameComboBox.Text = customer.CustomerName;
                updateAdressTextBox.Text = customer.CustomerAdress;
                updatePhoneNumbernumericUpDown.Text = customer.CustomerPhoneNumber;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in updateNameComboBox_SelectedIndexChanged: " + ex.Message);
            }
            finally
            {


            }



        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string customerName = deleteComboBox.Text;
                int customerId = _bl.Customer.ReadAll().FirstOrDefault(c => c.CustomerName == customerName).CustomerId;
                _bl.Customer.Delete(customerId);
            }
            catch (BlIDoesNotExist ex)
            {
                MessageBox.Show("Error: Customer ID does not exist.");
            }
            catch
            {
                MessageBox.Show("Error: Please check the input values.");
            }
            finally
            {
                deleteComboBox.Text = "";
                UpdateDetails();

            }
        }

        private void key_up_searchName(object sender, EventArgs e)
        {
            string search = searchNameTextBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                רשימת_לקוחות.DataSource = customersList;
            }
            else
            {
                var filteredCustomers = customersList.Where(c => c.CustomerName.Contains(search)).ToList();
                רשימת_לקוחות.DataSource = filteredCustomers;
                updateNameComboBox.DataSource = customersList.Where(c => c.CustomerName.Contains(search)).Select(c => c.CustomerName).ToList();
                deleteComboBox.DataSource = customersList.Where(c => c.CustomerName.Contains(search)).Select(c => c.CustomerName).ToList();
            }
        }

        private void key_up_searchIdNumericUpDown(object sender, EventArgs e)
        {
            int search = (int)searchIdNumericUpDown.Value;
            if (search == 0)
            {
                רשימת_לקוחות.DataSource = customersList;
            }
            else
            {
                string searchString = search.ToString();
                var filteredCustomers = customersList.Where(c => c.CustomerId.ToString().Contains(searchString)).ToList();
                רשימת_לקוחות.DataSource = filteredCustomers;
            }
            
           
        }
    }
}
