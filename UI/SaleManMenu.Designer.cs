namespace UI
{
    partial class SaleManMenu
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
            רשימת_מוצרים_בהזמנה = new ListBox();
            deleteProduct = new TabControl();
            tabPage1 = new TabPage();
            priceTextBox = new TextBox();
            price = new Label();
            salesForProduct = new Label();
            מבצעים_למוצר = new ListBox();
            add = new Button();
            count = new Label();
            countDitails = new NumericUpDown();
            chooseProduct = new Label();
            showProductsCB = new ComboBox();
            tabPage2 = new TabPage();
            button1 = new Button();
            chooseProductComboBox = new ComboBox();
            chooseProdToDelete = new Label();
            tabPage3 = new TabPage();
            updateCount = new NumericUpDown();
            updateBtn = new Button();
            updateComboBox = new ComboBox();
            update = new Label();
            deleteProduct.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)countDitails).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateCount).BeginInit();
            SuspendLayout();
            // 
            // רשימת_מוצרים_בהזמנה
            // 
            רשימת_מוצרים_בהזמנה.FormattingEnabled = true;
            רשימת_מוצרים_בהזמנה.Location = new Point(38, 37);
            רשימת_מוצרים_בהזמנה.Name = "רשימת_מוצרים_בהזמנה";
            רשימת_מוצרים_בהזמנה.Size = new Size(340, 384);
            רשימת_מוצרים_בהזמנה.TabIndex = 3;
            // 
            // deleteProduct
            // 
            deleteProduct.Controls.Add(tabPage1);
            deleteProduct.Controls.Add(tabPage2);
            deleteProduct.Controls.Add(tabPage3);
            deleteProduct.Location = new Point(409, 37);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.SelectedIndex = 0;
            deleteProduct.Size = new Size(340, 384);
            deleteProduct.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(priceTextBox);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(salesForProduct);
            tabPage1.Controls.Add(מבצעים_למוצר);
            tabPage1.Controls.Add(add);
            tabPage1.Controls.Add(count);
            tabPage1.Controls.Add(countDitails);
            tabPage1.Controls.Add(chooseProduct);
            tabPage1.Controls.Add(showProductsCB);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(332, 351);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספת מוצר";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click_1;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(55, 112);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(150, 27);
            priceTextBox.TabIndex = 8;
            priceTextBox.Text = " 0 ש\"ח";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(274, 115);
            price.Name = "price";
            price.Size = new Size(44, 20);
            price.TabIndex = 7;
            price.Text = ":מחיר";
            // 
            // salesForProduct
            // 
            salesForProduct.AutoSize = true;
            salesForProduct.Location = new Point(212, 213);
            salesForProduct.Name = "salesForProduct";
            salesForProduct.Size = new Size(106, 20);
            salesForProduct.TabIndex = 6;
            salesForProduct.Text = ":מבצעים למוצר";
            // 
            // מבצעים_למוצר
            // 
            מבצעים_למוצר.FormattingEnabled = true;
            מבצעים_למוצר.Location = new Point(54, 236);
            מבצעים_למוצר.Name = "מבצעים_למוצר";
            מבצעים_למוצר.Size = new Size(240, 64);
            מבצעים_למוצר.TabIndex = 5;
            // 
            // add
            // 
            add.Location = new Point(129, 316);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 4;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(245, 171);
            count.Name = "count";
            count.Size = new Size(73, 20);
            count.TabIndex = 3;
            count.Text = "בחר כמות";
            // 
            // countDitails
            // 
            countDitails.Location = new Point(55, 171);
            countDitails.Name = "countDitails";
            countDitails.Size = new Size(150, 27);
            countDitails.TabIndex = 2;
            // 
            // chooseProduct
            // 
            chooseProduct.AutoSize = true;
            chooseProduct.Location = new Point(247, 66);
            chooseProduct.Name = "chooseProduct";
            chooseProduct.Size = new Size(71, 20);
            chooseProduct.TabIndex = 1;
            chooseProduct.Text = "בחר מוצר";
            // 
            // showProductsCB
            // 
            showProductsCB.FormattingEnabled = true;
            showProductsCB.Location = new Point(54, 58);
            showProductsCB.Name = "showProductsCB";
            showProductsCB.Size = new Size(151, 28);
            showProductsCB.TabIndex = 0;
            showProductsCB.SelectedIndexChanged += showProductsCB_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(chooseProductComboBox);
            tabPage2.Controls.Add(chooseProdToDelete);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(332, 351);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "מחיקת מוצר";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(127, 204);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chooseProductComboBox
            // 
            chooseProductComboBox.FormattingEnabled = true;
            chooseProductComboBox.Location = new Point(99, 117);
            chooseProductComboBox.Name = "chooseProductComboBox";
            chooseProductComboBox.Size = new Size(151, 28);
            chooseProductComboBox.TabIndex = 1;
            chooseProductComboBox.SelectedIndexChanged += chooseProductComboBox_SelectedIndexChanged;
            // 
            // chooseProdToDelete
            // 
            chooseProdToDelete.AutoSize = true;
            chooseProdToDelete.Location = new Point(126, 63);
            chooseProdToDelete.Name = "chooseProdToDelete";
            chooseProdToDelete.Size = new Size(124, 20);
            chooseProdToDelete.TabIndex = 0;
            chooseProdToDelete.Text = "בחר מוצר לבחירה";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(updateCount);
            tabPage3.Controls.Add(updateBtn);
            tabPage3.Controls.Add(updateComboBox);
            tabPage3.Controls.Add(update);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(332, 351);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "עדכון כמות";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // updateCount
            // 
            updateCount.Location = new Point(114, 144);
            updateCount.Name = "updateCount";
            updateCount.Size = new Size(150, 27);
            updateCount.TabIndex = 5;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(163, 187);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(63, 33);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "עדכן";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // updateComboBox
            // 
            updateComboBox.FormattingEnabled = true;
            updateComboBox.Location = new Point(114, 110);
            updateComboBox.Name = "updateComboBox";
            updateComboBox.Size = new Size(151, 28);
            updateComboBox.TabIndex = 3;
            // 
            // update
            // 
            update.AutoSize = true;
            update.Location = new Point(141, 56);
            update.Name = "update";
            update.Size = new Size(119, 20);
            update.TabIndex = 2;
            update.Text = "בחר מוצר לעידכון";
            // 
            // SaleManMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteProduct);
            Controls.Add(רשימת_מוצרים_בהזמנה);
            Name = "SaleManMenu";
            Text = "SaleManMenu";
            deleteProduct.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)countDitails).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateCount).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox רשימת_מוצרים_בהזמנה;
        private TabControl deleteProduct;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label count;
        private NumericUpDown numericUpDown1;
        private Label chooseProduct;
        private ComboBox showProductsCB;
        private Button add;
        private NumericUpDown countDitails;
        private Label salesForProduct;
        private ListBox מבצעים_למוצר;
        private Label price;
        private TextBox priceTextBox;
        private ComboBox chooseProductComboBox;
        private Label chooseProdToDelete;
        private Button button1;
        private ComboBox updateComboBox;
        private Label update;
        private Button updateBtn;
        private NumericUpDown updateCount;
    }
}