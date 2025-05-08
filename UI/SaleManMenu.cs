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
    public partial class SaleManMenu : Form
    {
        BlApi.IBl _bl = BlApi.Factory.GetBl();
        Order order;
        public SaleManMenu(Order o)
        {


            InitializeComponent();
            this.order = o;
            showProductsCB.DataSource = _bl.Product.ReadAll().Select(p => p.ProductName).ToList();
            /*    chooseProductComboBox.DataSource = order.ProductList;*/


        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void showProductsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ProductName = showProductsCB.SelectedItem.ToString();

            Product product = _bl.Product.Read(p => p.ProductName == ProductName);
            מבצעים_למוצר.DataSource = _bl.Sale.ReadAll(p => p.ProductId == product.ProductId)
                .Select(s => string.Format("{0} in {1}", s.Count, s.PriceInSale))
                .ToList();
            priceTextBox.Text = product.price.ToString() + "שח";
        }

        private void add_Click(object sender, EventArgs e)

        {
            string ProductName = showProductsCB.SelectedItem.ToString();

            Product p = _bl.Product.Read(p => p.ProductName == ProductName);
            int count = (int)(countDitails.Value != 0 ? countDitails.Value : 0);
            if (count == 0)
            {
                MessageBox.Show("אין אפשרות להוסיף מוצר ללא כמות");
            }
            else
            {


                if (count > _bl.Product.Read(p.ProductId).QuantityInStock)
                {
                    MessageBox.Show("אין מספיק במלאי נוסף: " + _bl.Product.Read(p.ProductId).QuantityInStock);
                }
                _bl.Order.AddProductToOrder(order, p.ProductId, count);
                ProductInOrder currentProduct = order.ProductList.FirstOrDefault(prod => prod.ProductId == p.ProductId);
                רשימת_מוצרים_בהזמנה.DataSource = order.ProductList.Select(p => new { name = p.ProductName, price = p.FinalPrice, count = p.ProductCount }).ToList();
                chooseProductComboBox.DataSource = order.ProductList.Select(p => p.ProductName).ToList();
                updateComboBox.DataSource = order.ProductList.Select(p => p.ProductName).ToList(); ;
                updateCount.Value = currentProduct.ProductCount;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string productName = chooseProductComboBox.SelectedItem.ToString();
            Product p = _bl.Product.Read(p => p.ProductName == productName);
            ProductInOrder p1 = order.ProductList.Find(p => p.ProductName == productName);
            order.ProductList.Remove(p1);
            רשימת_מוצרים_בהזמנה.DataSource = order.ProductList.Select(p => new { name = p.ProductName, price = p.FinalPrice, count = p.ProductCount }).ToList();

        }

        private void chooseProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string productName = updateComboBox.Text;
            Product currentProduct = _bl.Product.Read(p => p.ProductName == productName);
            ProductInOrder p = order.ProductList.FirstOrDefault(p => p.ProductName == productName);
            int count = (int)updateCount.Value - p.ProductCount;
            //טיפול במקרה של הפחתה בכמות
            if (count < 0)
            {
                currentProduct.QuantityInStock = currentProduct.QuantityInStock + (p.ProductCount - (int)updateCount.Value);
                p.ProductCount -= count;
                _bl.Product.Update(currentProduct);
            }
            //טיפול במקרה של הוספה בכמות
            else
            {
                if (count > _bl.Product.Read(p.ProductId).QuantityInStock)
                {
                    MessageBox.Show("אין מספיק במלאי נוסף: " + _bl.Product.Read(p.ProductId).QuantityInStock);
                    p.ProductCount += (int)currentProduct.QuantityInStock;
                    currentProduct.QuantityInStock = 0;
                }
                else
                {
                    p.ProductCount += count;
                }

                _bl.Product.Update(currentProduct);
            }

            //מחיקת המוצר
            if (p.ProductCount == 0)
                _bl.Order.deleteProductFromOrder(order, p.ProductId);
            else
            { 
                _bl.Order.CalcTotalPriceForProduct(p);
            _bl.Order.CalcTotalPrice(order);
            }
            //עדכון תצוגה בשינויים

            רשימת_מוצרים_בהזמנה.DataSource = order.ProductList.Select(p => new { name = p.ProductName, price = p.FinalPrice, count = p.ProductCount }).ToList();
            chooseProductComboBox.DataSource = order.ProductList.Select(p => p.ProductName).ToList();
            updateComboBox.DataSource = order.ProductList.Select(p => p.ProductName).ToList(); ;
            updateCount.Value = p.ProductCount;
        }
    }
}
