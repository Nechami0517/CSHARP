using BlApi;
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
    public partial class SaleManagement : Form
    {
        List<BO.Sale> salesList;
        List<BO.Product> productsList;
        BlApi.IBl _bl = BlApi.Factory.GetBl();
        public SaleManagement()
        {
            InitializeComponent();
            רשימת_מבצעים.DataSource = _bl.Sale.ReadAll();
            updateDetails();
        }


        private void PriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            int productId = (int)(addComboBox.SelectedItem);
            int countSaleInStock = (int)(CountSaleInStockNumericUpDown.Value);
            double price = (double)(PriceNumericUpDown.Value);
            int quantityInStock = (int)(QuantityInStockNumericUpDown.Value);
            bool IsClub = IsClubCheckBox.Checked;
            DateTime dateBeginSail = (DateTime)dateBeginSale.Value;
            DateTime dateEndSail = (DateTime)dateEndSale.Value;
            BO.Sale sale = new BO.Sale(0, productId, countSaleInStock, price, IsClub, dateBeginSail, dateEndSail);
            _bl.Sale.Create(sale);
            רשימת_מבצעים.DataSource = _bl.Sale.ReadAll();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //int productId = (int)(ProductIdNumericUpDown1.Value);
                int productId = (int)(updateComboBox.SelectedItem);
                int countSaleInStock = (int)(CountSaleInStockNumericUpDown1.Value);
                double price = (double)(PriceNumericUpDown1.Value);
                bool IsClub = IsClubCheckBox1.Checked;
                DateTime dateBeginSail = (DateTime)dateBeginSale1.Value;
                DateTime dateEndSail = (DateTime)dateEndSale1.Value;

                // קריאה למוצר הקיים

                BO.Sale sale = _bl.Sale.Read(productId);

                // בדוק אם המוצר קיים
                if (sale != null)
                {
                    // יצירת מוצר חדש עם שינויים
                    BO.Sale updateSale = new BO.Sale(
                        sale.SaleId,
                        productId, // שמירה על ה-ID
                        countSaleInStock, // עדכון שם המוצר
                        price, // עדכון מחיר
                        IsClub, // עדכון קטגוריה
                        dateBeginSail, // עדכון כמות במלאי
                        dateEndSail // עדכון תאריך סיום
                    );
                    _bl.Sale.Update(updateSale);

                }
                else
                {
                    // טיפול במקרה שבו המוצר לא נמצא
                    Console.WriteLine("המוצר לא נמצא.");
                }




            }
            catch (Exception ex)
            {
                throw new Exception(ex + "faild update sale");
            }
            finally
            {
                // עדכון תצוגה בשינויים
                updateDetails();
            }
        }
        private void updateDetails()
        {
            salesList = _bl.Sale.ReadAll().OrderBy(s => s.ProductId).ToList();
            productsList = _bl.Product.ReadAll().OrderBy(p => p.ProductId).ToList();
            רשימת_מבצעים.DataSource = salesList;
            deleteComboBox.DataSource = salesList.Select(s => s.SaleId).ToList();
            addComboBox.DataSource = productsList.Select(p => p.ProductId).ToList();
            updateComboBox.DataSource = salesList.Select(s => s.SaleId).ToList();
            //searchIdNumericUpDown.Maximum = 1000000000;
            //searchIdNumericUpDown.Minimum = 0;

        }



        private void deleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string saleId = deleteComboBox.Text;
            BO.Sale sale = _bl.Sale.Read(p => p.SaleId == int.Parse(saleId));
            if (sale != null)
            {
                _bl.Sale.Delete(sale.ProductId ?? 100);
                updateDetails();
            }
        }



        private void key_up_searchIdNumericUpDown(object sender, EventArgs e)
        {
            bool search = isClub.Checked;
            if (search == null)
            {
                רשימת_מבצעים.DataSource = salesList;
            }
            else
            {
                //string searchString = search.ToString();
                var filteredSales = salesList.Where(s => s.IsClub == search).ToList();
                רשימת_מבצעים.DataSource = filteredSales;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void סינון_Click(object sender, EventArgs e)
        {

        }

        private void isClub_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }

}
