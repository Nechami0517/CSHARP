namespace UI
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            הוספה = new TabPage();
            nameTextBox = new TextBox();
            QuantityInStockNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            QuantityInStock = new Label();
            Price = new Label();
            Categories = new Label();
            CategoriesCM = new ComboBox();
            label1 = new Label();
            add = new Button();
            עדכון = new TabPage();
            label2 = new Label();
            ProductcomboBox = new ComboBox();
            updateNametextBox = new TextBox();
            updateQuantityInStockNumericUpDown = new NumericUpDown();
            updateNumericUpDown = new NumericUpDown();
            QuantityInStock2 = new Label();
            price2 = new Label();
            Categorie = new Label();
            updateCategoriesComboBox1 = new ComboBox();
            name = new Label();
            update = new Button();
            מחיקה = new TabPage();
            chooseProduct = new Label();
            deleteComboBox = new ComboBox();
            deleteBtn = new Button();
            סינון = new TabPage();
            label3 = new Label();
            filterComboBox = new ComboBox();
            רשימת_מוצרים = new ListBox();
            tabControl1.SuspendLayout();
            הוספה.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInStockNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            עדכון.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateQuantityInStockNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updateNumericUpDown).BeginInit();
            מחיקה.SuspendLayout();
            סינון.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(הוספה);
            tabControl1.Controls.Add(עדכון);
            tabControl1.Controls.Add(מחיקה);
            tabControl1.Controls.Add(סינון);
            tabControl1.Location = new Point(365, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(354, 361);
            tabControl1.TabIndex = 0;
            // 
            // הוספה
            // 
            הוספה.Controls.Add(nameTextBox);
            הוספה.Controls.Add(QuantityInStockNumericUpDown);
            הוספה.Controls.Add(PriceNumericUpDown);
            הוספה.Controls.Add(QuantityInStock);
            הוספה.Controls.Add(Price);
            הוספה.Controls.Add(Categories);
            הוספה.Controls.Add(CategoriesCM);
            הוספה.Controls.Add(label1);
            הוספה.Controls.Add(add);
            הוספה.Location = new Point(4, 29);
            הוספה.Name = "הוספה";
            הוספה.Padding = new Padding(3);
            הוספה.Size = new Size(346, 328);
            הוספה.TabIndex = 0;
            הוספה.Text = "הוספה";
            הוספה.UseVisualStyleBackColor = true;
            הוספה.Click += tabPage1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(85, 35);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(125, 27);
            nameTextBox.TabIndex = 9;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // QuantityInStockNumericUpDown
            // 
            QuantityInStockNumericUpDown.Location = new Point(60, 202);
            QuantityInStockNumericUpDown.Name = "QuantityInStockNumericUpDown";
            QuantityInStockNumericUpDown.Size = new Size(150, 27);
            QuantityInStockNumericUpDown.TabIndex = 8;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Location = new Point(60, 147);
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(150, 27);
            PriceNumericUpDown.TabIndex = 7;
            // 
            // QuantityInStock
            // 
            QuantityInStock.AutoSize = true;
            QuantityInStock.Location = new Point(216, 202);
            QuantityInStock.Name = "QuantityInStock";
            QuantityInStock.Size = new Size(87, 20);
            QuantityInStock.TabIndex = 6;
            QuantityInStock.Text = "כמות במלאי";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(262, 149);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 5;
            Price.Text = "מחיר";
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.Location = new Point(241, 98);
            Categories.Name = "Categories";
            Categories.Size = new Size(62, 20);
            Categories.TabIndex = 4;
            Categories.Text = "קטגוריה";
            // 
            // CategoriesCM
            // 
            CategoriesCM.FormattingEnabled = true;
            CategoriesCM.Location = new Point(59, 90);
            CategoriesCM.Name = "CategoriesCM";
            CategoriesCM.Size = new Size(151, 28);
            CategoriesCM.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 35);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = ":שם";
            // 
            // add
            // 
            add.Location = new Point(124, 267);
            add.Name = "add";
            add.Size = new Size(107, 45);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // עדכון
            // 
            עדכון.Controls.Add(label2);
            עדכון.Controls.Add(ProductcomboBox);
            עדכון.Controls.Add(updateNametextBox);
            עדכון.Controls.Add(updateQuantityInStockNumericUpDown);
            עדכון.Controls.Add(updateNumericUpDown);
            עדכון.Controls.Add(QuantityInStock2);
            עדכון.Controls.Add(price2);
            עדכון.Controls.Add(Categorie);
            עדכון.Controls.Add(updateCategoriesComboBox1);
            עדכון.Controls.Add(name);
            עדכון.Controls.Add(update);
            עדכון.Location = new Point(4, 29);
            עדכון.Name = "עדכון";
            עדכון.Padding = new Padding(3);
            עדכון.Size = new Size(346, 328);
            עדכון.TabIndex = 1;
            עדכון.Text = "עדכון";
            עדכון.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 26);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 20;
            label2.Text = "בחר מוצר";
            // 
            // ProductcomboBox
            // 
            ProductcomboBox.FormattingEnabled = true;
            ProductcomboBox.Location = new Point(52, 26);
            ProductcomboBox.Name = "ProductcomboBox";
            ProductcomboBox.Size = new Size(151, 28);
            ProductcomboBox.TabIndex = 19;
            ProductcomboBox.SelectedIndexChanged += ProductcomboBox_SelectedIndexChanged;
            // 
            // updateNametextBox
            // 
            updateNametextBox.Location = new Point(77, 69);
            updateNametextBox.Name = "updateNametextBox";
            updateNametextBox.Size = new Size(125, 27);
            updateNametextBox.TabIndex = 18;
            // 
            // updateQuantityInStockNumericUpDown
            // 
            updateQuantityInStockNumericUpDown.Location = new Point(52, 221);
            updateQuantityInStockNumericUpDown.Name = "updateQuantityInStockNumericUpDown";
            updateQuantityInStockNumericUpDown.Size = new Size(150, 27);
            updateQuantityInStockNumericUpDown.TabIndex = 17;
            // 
            // updateNumericUpDown
            // 
            updateNumericUpDown.Location = new Point(52, 166);
            updateNumericUpDown.Name = "updateNumericUpDown";
            updateNumericUpDown.Size = new Size(150, 27);
            updateNumericUpDown.TabIndex = 16;
            // 
            // QuantityInStock2
            // 
            QuantityInStock2.AutoSize = true;
            QuantityInStock2.Location = new Point(208, 223);
            QuantityInStock2.Name = "QuantityInStock2";
            QuantityInStock2.Size = new Size(87, 20);
            QuantityInStock2.TabIndex = 15;
            QuantityInStock2.Text = "כמות במלאי";
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Location = new Point(254, 168);
            price2.Name = "price2";
            price2.Size = new Size(41, 20);
            price2.TabIndex = 14;
            price2.Text = "מחיר";
            // 
            // Categorie
            // 
            Categorie.AutoSize = true;
            Categorie.Location = new Point(233, 117);
            Categorie.Name = "Categorie";
            Categorie.Size = new Size(62, 20);
            Categorie.TabIndex = 13;
            Categorie.Text = "קטגוריה";
            // 
            // updateCategoriesComboBox1
            // 
            updateCategoriesComboBox1.FormattingEnabled = true;
            updateCategoriesComboBox1.Location = new Point(51, 109);
            updateCategoriesComboBox1.Name = "updateCategoriesComboBox1";
            updateCategoriesComboBox1.Size = new Size(151, 28);
            updateCategoriesComboBox1.TabIndex = 12;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(254, 76);
            name.Name = "name";
            name.Size = new Size(34, 20);
            name.TabIndex = 11;
            name.Text = ":שם";
            // 
            // update
            // 
            update.Location = new Point(112, 277);
            update.Name = "update";
            update.Size = new Size(107, 45);
            update.TabIndex = 10;
            update.Text = "עדכן";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // מחיקה
            // 
            מחיקה.Controls.Add(chooseProduct);
            מחיקה.Controls.Add(deleteComboBox);
            מחיקה.Controls.Add(deleteBtn);
            מחיקה.Location = new Point(4, 29);
            מחיקה.Name = "מחיקה";
            מחיקה.Size = new Size(346, 328);
            מחיקה.TabIndex = 2;
            מחיקה.Text = "מחיקה";
            מחיקה.UseVisualStyleBackColor = true;
            // 
            // chooseProduct
            // 
            chooseProduct.AutoSize = true;
            chooseProduct.Location = new Point(228, 86);
            chooseProduct.Name = "chooseProduct";
            chooseProduct.Size = new Size(71, 20);
            chooseProduct.TabIndex = 22;
            chooseProduct.Text = "בחר מוצר";
            // 
            // deleteComboBox
            // 
            deleteComboBox.FormattingEnabled = true;
            deleteComboBox.Location = new Point(47, 78);
            deleteComboBox.Name = "deleteComboBox";
            deleteComboBox.Size = new Size(151, 28);
            deleteComboBox.TabIndex = 21;
            deleteComboBox.SelectedIndexChanged += deleteComboBox_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(107, 198);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 0;
            deleteBtn.Text = "מחק";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // סינון
            // 
            סינון.Controls.Add(label3);
            סינון.Controls.Add(filterComboBox);
            סינון.Location = new Point(4, 29);
            סינון.Name = "סינון";
            סינון.Size = new Size(346, 328);
            סינון.TabIndex = 3;
            סינון.Text = "סינון";
            סינון.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 61);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 15;
            label3.Text = "בחר קטגוריה להצגה";
            // 
            // filterComboBox
            // 
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(106, 96);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(151, 28);
            filterComboBox.TabIndex = 14;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // רשימת_מוצרים
            // 
            רשימת_מוצרים.FormattingEnabled = true;
            רשימת_מוצרים.Location = new Point(41, 82);
            רשימת_מוצרים.Name = "רשימת_מוצרים";
            רשימת_מוצרים.Size = new Size(301, 324);
            רשימת_מוצרים.TabIndex = 1;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(רשימת_מוצרים);
            Controls.Add(tabControl1);
            Name = "ProductManagement";
            Text = "ProductManagement";
            tabControl1.ResumeLayout(false);
            הוספה.ResumeLayout(false);
            הוספה.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInStockNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            עדכון.ResumeLayout(false);
            עדכון.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateQuantityInStockNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)updateNumericUpDown).EndInit();
            מחיקה.ResumeLayout(false);
            מחיקה.PerformLayout();
            סינון.ResumeLayout(false);
            סינון.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage הוספה;
        private TabPage עדכון;
        private TabPage מחיקה;
        private TabPage סינון;
        private ListBox רשימת_מוצרים;
        private Button add;
        private Label label1;
        private Label Categories;
        private ComboBox CategoriesCM;
        private TextBox nameTextBox;
        private NumericUpDown QuantityInStockNumericUpDown;
        private NumericUpDown PriceNumericUpDown;
        private Label QuantityInStock;
        private Label Price;
        private TextBox updateNametextBox;
        private NumericUpDown updateQuantityInStockNumericUpDown;
        private NumericUpDown updateNumericUpDown;
        private Label QuantityInStock2;
        private Label price2;
        private Label Categorie;
        private ComboBox updateCategoriesComboBox1;
        private Label name;
        private Button update;
        private Label label2;
        private ComboBox ProductcomboBox;
        private Button deleteBtn;
        private Label chooseProduct;
        private ComboBox deleteComboBox;
        private Label label3;
        private ComboBox filterComboBox;
    }
}