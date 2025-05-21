namespace UI
{
    partial class SaleManagement
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
            רשימת_מבצעים = new ListBox();
            tabControl1 = new TabControl();
            הוספה = new TabPage();
            addComboBox = new ComboBox();
            dateBeginSale = new DateTimePicker();
            dateEndSale = new DateTimePicker();
            IsClubCheckBox = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            QuantityInStockNumericUpDown = new NumericUpDown();
            PriceNumericUpDown = new NumericUpDown();
            CountSaleInStockNumericUpDown = new NumericUpDown();
            QuantityInStock = new Label();
            Price = new Label();
            Categories = new Label();
            label1 = new Label();
            add = new Button();
            עדכון = new TabPage();
            updateComboBox = new ComboBox();
            dateBeginSale1 = new DateTimePicker();
            dateEndSale1 = new DateTimePicker();
            IsClubCheckBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            PriceNumericUpDown1 = new NumericUpDown();
            CountSaleInStockNumericUpDown1 = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            updateButton = new Button();
            updateButton.Click += updateButton_Click;
            מחיקה = new TabPage();
            chooseProduct = new Label();
            deleteComboBox = new ComboBox();
            deleteBtn = new Button();
            סינון = new TabPage();
            isClub = new CheckBox();
            label13 = new Label();
            label12 = new Label();
            tabControl1.SuspendLayout();
            הוספה.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInStockNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountSaleInStockNumericUpDown).BeginInit();
            עדכון.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CountSaleInStockNumericUpDown1).BeginInit();
            מחיקה.SuspendLayout();
            סינון.SuspendLayout();
            SuspendLayout();
            // 
            // רשימת_מבצעים
            // 
            רשימת_מבצעים.FormattingEnabled = true;
            רשימת_מבצעים.Location = new Point(61, 75);
            רשימת_מבצעים.Name = "רשימת_מבצעים";
            רשימת_מבצעים.Size = new Size(301, 324);
            רשימת_מבצעים.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(הוספה);
            tabControl1.Controls.Add(עדכון);
            tabControl1.Controls.Add(מחיקה);
            tabControl1.Controls.Add(סינון);
            tabControl1.Location = new Point(385, 45);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(354, 361);
            tabControl1.TabIndex = 2;
            // 
            // הוספה
            // 
            הוספה.Controls.Add(addComboBox);
            הוספה.Controls.Add(dateBeginSale);
            הוספה.Controls.Add(dateEndSale);
            הוספה.Controls.Add(IsClubCheckBox);
            הוספה.Controls.Add(label4);
            הוספה.Controls.Add(label3);
            הוספה.Controls.Add(label2);
            הוספה.Controls.Add(QuantityInStockNumericUpDown);
            הוספה.Controls.Add(PriceNumericUpDown);
            הוספה.Controls.Add(CountSaleInStockNumericUpDown);
            הוספה.Controls.Add(QuantityInStock);
            הוספה.Controls.Add(Price);
            הוספה.Controls.Add(Categories);
            הוספה.Controls.Add(label1);
            הוספה.Controls.Add(add);
            הוספה.Location = new Point(4, 29);
            הוספה.Name = "הוספה";
            הוספה.Padding = new Padding(3);
            הוספה.Size = new Size(346, 328);
            הוספה.TabIndex = 0;
            הוספה.Text = "הוספה";
            הוספה.UseVisualStyleBackColor = true;
            // 
            // addComboBox
            // 
            addComboBox.FormattingEnabled = true;
            addComboBox.Location = new Point(42, 32);
            addComboBox.Name = "addComboBox";
            addComboBox.Size = new Size(151, 28);
            addComboBox.TabIndex = 19;
            addComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateBeginSale
            // 
            dateBeginSale.Location = new Point(43, 193);
            dateBeginSale.Name = "dateBeginSale";
            dateBeginSale.Size = new Size(150, 27);
            dateBeginSale.TabIndex = 18;
            // 
            // dateEndSale
            // 
            dateEndSale.Location = new Point(43, 229);
            dateEndSale.Name = "dateEndSale";
            dateEndSale.Size = new Size(150, 27);
            dateEndSale.TabIndex = 16;
            // 
            // IsClubCheckBox
            // 
            IsClubCheckBox.AutoSize = true;
            IsClubCheckBox.Location = new Point(175, 165);
            IsClubCheckBox.Name = "IsClubCheckBox";
            IsClubCheckBox.Size = new Size(18, 17);
            IsClubCheckBox.TabIndex = 14;
            IsClubCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 234);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 13;
            label4.Text = "תאריך סיום";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 203);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 12;
            label3.Text = "תאריך התחלה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 171);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 11;
            label2.Text = "למועדון?";
            // 
            // QuantityInStockNumericUpDown
            // 
            QuantityInStockNumericUpDown.Location = new Point(43, 132);
            QuantityInStockNumericUpDown.Name = "QuantityInStockNumericUpDown";
            QuantityInStockNumericUpDown.Size = new Size(150, 27);
            QuantityInStockNumericUpDown.TabIndex = 10;
            // 
            // PriceNumericUpDown
            // 
            PriceNumericUpDown.Location = new Point(43, 99);
            PriceNumericUpDown.Name = "PriceNumericUpDown";
            PriceNumericUpDown.Size = new Size(150, 27);
            PriceNumericUpDown.TabIndex = 8;
            // 
            // CountSaleInStockNumericUpDown
            // 
            CountSaleInStockNumericUpDown.Location = new Point(43, 66);
            CountSaleInStockNumericUpDown.Name = "CountSaleInStockNumericUpDown";
            CountSaleInStockNumericUpDown.Size = new Size(150, 27);
            CountSaleInStockNumericUpDown.TabIndex = 7;
            CountSaleInStockNumericUpDown.ValueChanged += PriceNumericUpDown_ValueChanged;
            // 
            // QuantityInStock
            // 
            QuantityInStock.AutoSize = true;
            QuantityInStock.Location = new Point(199, 132);
            QuantityInStock.Name = "QuantityInStock";
            QuantityInStock.Size = new Size(87, 20);
            QuantityInStock.TabIndex = 6;
            QuantityInStock.Text = "כמות במלאי";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(199, 99);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 5;
            Price.Text = "מחיר";
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.Location = new Point(199, 66);
            Categories.Name = "Categories";
            Categories.Size = new Size(141, 20);
            Categories.TabIndex = 4;
            Categories.Text = "כמות מוצרים במבצע";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 36);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "קוד מוצר";
            // 
            // add
            // 
            add.Location = new Point(120, 277);
            add.Name = "add";
            add.Size = new Size(107, 45);
            add.TabIndex = 0;
            add.Text = "הוספה";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // עדכון
            // 
            עדכון.Controls.Add(updateComboBox);
            עדכון.Controls.Add(dateBeginSale1);
            עדכון.Controls.Add(dateEndSale1);
            עדכון.Controls.Add(IsClubCheckBox1);
            עדכון.Controls.Add(label5);
            עדכון.Controls.Add(label6);
            עדכון.Controls.Add(label7);
            עדכון.Controls.Add(numericUpDown1);
            עדכון.Controls.Add(PriceNumericUpDown1);
            עדכון.Controls.Add(CountSaleInStockNumericUpDown1);
            עדכון.Controls.Add(label8);
            עדכון.Controls.Add(label9);
            עדכון.Controls.Add(label10);
            עדכון.Controls.Add(label11);
            עדכון.Controls.Add(updateButton);
            עדכון.Location = new Point(4, 29);
            עדכון.Name = "עדכון";
            עדכון.Padding = new Padding(3);
            עדכון.Size = new Size(346, 328);
            עדכון.TabIndex = 1;
            עדכון.Text = "עדכון";
            עדכון.UseVisualStyleBackColor = true;
            // 
            // updateComboBox
            // 
            updateComboBox.FormattingEnabled = true;
            updateComboBox.Location = new Point(31, 19);
            updateComboBox.Name = "updateComboBox";
            updateComboBox.Size = new Size(151, 28);
            updateComboBox.TabIndex = 34;
            // 
            // dateBeginSale1
            // 
            dateBeginSale1.Location = new Point(32, 180);
            dateBeginSale1.Name = "dateBeginSale1";
            dateBeginSale1.Size = new Size(150, 27);
            dateBeginSale1.TabIndex = 33;
            // 
            // dateEndSale1
            // 
            dateEndSale1.Location = new Point(32, 216);
            dateEndSale1.Name = "dateEndSale1";
            dateEndSale1.Size = new Size(150, 27);
            dateEndSale1.TabIndex = 32;
            // 
            // IsClubCheckBox1
            // 
            IsClubCheckBox1.AutoSize = true;
            IsClubCheckBox1.Location = new Point(164, 152);
            IsClubCheckBox1.Name = "IsClubCheckBox1";
            IsClubCheckBox1.Size = new Size(18, 17);
            IsClubCheckBox1.TabIndex = 31;
            IsClubCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 221);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 30;
            label5.Text = "תאריך סיום";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 190);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 29;
            label6.Text = "תאריך התחלה";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 158);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 28;
            label7.Text = "למועדון?";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(32, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 27;
            // 
            // PriceNumericUpDown1
            // 
            PriceNumericUpDown1.Location = new Point(32, 86);
            PriceNumericUpDown1.Name = "PriceNumericUpDown1";
            PriceNumericUpDown1.Size = new Size(150, 27);
            PriceNumericUpDown1.TabIndex = 25;
            // 
            // CountSaleInStockNumericUpDown1
            // 
            CountSaleInStockNumericUpDown1.Location = new Point(32, 53);
            CountSaleInStockNumericUpDown1.Name = "CountSaleInStockNumericUpDown1";
            CountSaleInStockNumericUpDown1.Size = new Size(150, 27);
            CountSaleInStockNumericUpDown1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 119);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 23;
            label8.Text = "כמות במלאי";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(188, 86);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 22;
            label9.Text = "מחיר";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 53);
            label10.Name = "label10";
            label10.Size = new Size(141, 20);
            label10.TabIndex = 21;
            label10.Text = "כמות מוצרים במבצע";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(188, 23);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 20;
            label11.Text = "קוד מוצר";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(109, 264);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(107, 45);
            updateButton.TabIndex = 19;
            updateButton.Text = "עדכן";
            updateButton.UseVisualStyleBackColor = true;
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
            chooseProduct.Location = new Point(228, 98);
            chooseProduct.Name = "chooseProduct";
            chooseProduct.Size = new Size(71, 20);
            chooseProduct.TabIndex = 25;
            chooseProduct.Text = "בחר מוצר";
            // 
            // deleteComboBox
            // 
            deleteComboBox.FormattingEnabled = true;
            deleteComboBox.Location = new Point(47, 90);
            deleteComboBox.Name = "deleteComboBox";
            deleteComboBox.Size = new Size(151, 28);
            deleteComboBox.TabIndex = 24;
            deleteComboBox.SelectedIndexChanged += deleteComboBox_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(107, 210);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 29);
            deleteBtn.TabIndex = 23;
            deleteBtn.Text = "מחק";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // סינון
            // 
            סינון.Controls.Add(isClub);
            סינון.Controls.Add(label13);
            סינון.Controls.Add(label12);
            סינון.Location = new Point(4, 29);
            סינון.Name = "סינון";
            סינון.Size = new Size(346, 328);
            סינון.TabIndex = 3;
            סינון.Text = "סינון";
            סינון.UseVisualStyleBackColor = true;
            סינון.Click += סינון_Click;
            // 
            // isClub
            // 
            isClub.AutoSize = true;
            isClub.Location = new Point(134, 136);
            isClub.Name = "isClub";
            isClub.Size = new Size(18, 17);
            isClub.TabIndex = 32;
            isClub.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(202, 133);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 18;
            label13.Text = "למועדון?";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(98, 133);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 17;
            // 
            // SaleManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(רשימת_מבצעים);
            Controls.Add(tabControl1);
            Name = "SaleManagement";
            Text = "SaleManagement";
            tabControl1.ResumeLayout(false);
            הוספה.ResumeLayout(false);
            הוספה.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityInStockNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountSaleInStockNumericUpDown).EndInit();
            עדכון.ResumeLayout(false);
            עדכון.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CountSaleInStockNumericUpDown1).EndInit();
            מחיקה.ResumeLayout(false);
            מחיקה.PerformLayout();
            סינון.ResumeLayout(false);
            סינון.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox רשימת_מבצעים;
        private TabControl tabControl1;
        private TabPage הוספה;
        private NumericUpDown PriceNumericUpDown;
        private NumericUpDown CountSaleInStockNumericUpDown;
        private Label QuantityInStock;
        private Label Price;
        private Label Categories;
        private Label label1;
        private Button add;
        private TabPage עדכון;
        private TabPage מחיקה;
        private TabPage סינון;
        private NumericUpDown QuantityInStockNumericUpDown;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox IsClubCheckBox;
        private DateTimePicker dateBeginSale;
        private DateTimePicker dateEndSale;
        private DateTimePicker dateBeginSale1;
        private DateTimePicker dateEndSale1;
        private CheckBox IsClubCheckBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private NumericUpDown PriceNumericUpDown1;
        private NumericUpDown CountSaleInStockNumericUpDown1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button updateButton;
        private Label chooseProduct;
        private ComboBox deleteComboBox;
        private Button deleteBtn;
        private Label label12;
        private ComboBox addComboBox;
        private ComboBox updateComboBox;
        private Label label13;
        private CheckBox isClub;
    }
}