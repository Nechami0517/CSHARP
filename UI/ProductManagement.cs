

using System.Data;


namespace UI
{
    public partial class ProductManagement : Form
    {
        BlApi.IBl _bl = BlApi.Factory.GetBl();
        List<BO.Product> productsList;
        public ProductManagement()
        {
            InitializeComponent();
            //אתחול של נתוני המסך

            updateDetails();
            updateFirstDetails();

        }

        private void updateFirstDetails()
        {
            var categoryValues = Enum.GetValues(typeof(DO.Categories));
            filterComboBox.Items.Add("כל הקטגוריות");
            foreach (var category in categoryValues)
            {
                CategoriesCM.Items.Add(category);
                updateCategoriesComboBox1.Items.Add(category);
                filterComboBox.Items.Add(category);
            }

        }
        private void updateDetails()
        {
            productsList = _bl.Product.ReadAll().OrderBy(p => p.ProductId).ToList();
            רשימת_מוצרים.DataSource = productsList;
            ProductcomboBox.DataSource = productsList.Select(p => p.ProductName).ToList();
            deleteComboBox.DataSource = productsList.Select(p => p.ProductName).ToList();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            try
            {
                string productName = nameTextBox.Text;
                double price = (double)(PriceNumericUpDown.Value);
                string category = CategoriesCM.SelectedItem.ToString();
                int QuantityInStock = (int)(QuantityInStockNumericUpDown.Value);
                if (Enum.TryParse<DO.Categories>(CategoriesCM.SelectedItem.ToString(), out DO.Categories categorySelected))
                { }
                BO.Product product = new BO.Product(0, productName, categorySelected, price, QuantityInStock);
                _bl.Product.Create(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex + "faild add product");
            }
            finally
            {
                // עדכון תצוגה בשינויים
                updateDetails();
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = ProductcomboBox.Text;
                string newName = updateNametextBox.Text;
                double price = (double)(updateNumericUpDown.Value);
                string category = updateCategoriesComboBox1.SelectedItem.ToString();
                int QuantityInStock = (int)(updateQuantityInStockNumericUpDown.Value);
                if (Enum.TryParse<DO.Categories>(updateCategoriesComboBox1.SelectedItem.ToString(), out DO.Categories categorySelected))
                { }
                // קריאה למוצר הקיים

                BO.Product product = _bl.Product.Read(p => p.ProductName == productName);

                // בדוק אם המוצר קיים
                if (product != null)
                {
                    // יצירת מוצר חדש עם שינויים
                    BO.Product updateProduct = new BO.Product(
                        product.ProductId, // שמירה על ה-ID
                        newName,
                        categorySelected,
                        price,
                        QuantityInStock
                    );
                    _bl.Product.Update(updateProduct);
                   
                }
                else
                {
                    // טיפול במקרה שבו המוצר לא נמצא
                    Console.WriteLine("המוצר לא נמצא.");
                }




            }
            catch (Exception ex)
            {
                throw new Exception(ex + "faild update product");
            }
            finally
            {
                // עדכון תצוגה בשינויים
                updateDetails();
            }
        }

        //עדכון נתונים בהתאם למוצר שנבחר
        private void ProductcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productName = ProductcomboBox.Text;
            BO.Product product = _bl.Product.Read(p => p.ProductName == productName);
            if (product != null)
            {
                try
                {
                    ProductcomboBox.SelectedItem = product.ProductName;

                    updateNametextBox.Text = productName;
                    updateNumericUpDown.Maximum = 10000;
                    updateNumericUpDown.Value = (decimal)product.price;
                    updateCategoriesComboBox1.SelectedItem = product.Category;
                    updateQuantityInStockNumericUpDown.Maximum = 1000;
                    updateQuantityInStockNumericUpDown.Value = (decimal)product.QuantityInStock;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex + "");
                }

            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string productName = deleteComboBox.Text;
            BO.Product product = _bl.Product.Read(p => p.ProductName == productName);
            if (product != null)
            {
                _bl.Product.Delete(product.ProductId);
                updateDetails();
            }

        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(filterComboBox.SelectedItem.ToString() == "כל הקטגוריות")
            {
                רשימת_מוצרים.DataSource = _bl.Product.ReadAll();
            }
            else { 
            if (!Enum.TryParse<DO.Categories>(filterComboBox.SelectedItem.ToString(), out DO.Categories categorySelected))
            {
                categorySelected = DO.Categories.bags;
            }
            
            רשימת_מוצרים.DataSource = _bl.Product.ReadAll(p => p.Category == categorySelected).ToList();
                ProductcomboBox.DataSource = productsList.Where(p => p.Category == categorySelected).Select(p => p.ProductName).ToList();
                deleteComboBox.DataSource = productsList.Where(p => p.Category == categorySelected).Select(p => p.ProductName).ToList();
            }
        }
    }
}

