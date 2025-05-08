namespace UI
{
    partial class CustomerManagment
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
            רשימת_לקוחות = new ListBox();
            tabControl1 = new TabControl();
            הוספה = new TabPage();
            nameTextBox = new TextBox();
            numberPhoneNumbernumericUpDown = new NumericUpDown();
            label6 = new Label();
            adressTextBox = new TextBox();
            label5 = new Label();
            idNumericUpDown = new NumericUpDown();
            label4 = new Label();
            label1 = new Label();
            addBtn = new Button();
            עדכון = new TabPage();
            updateNameComboBox = new ComboBox();
            updatePhoneNumbernumericUpDown = new NumericUpDown();
            label2 = new Label();
            updateAdressTextBox = new TextBox();
            label7 = new Label();
            label9 = new Label();
            updateBtn = new Button();
            מחיקה = new TabPage();
            deleteComboBox = new ComboBox();
            label8 = new Label();
            deleteBtn = new Button();
            סינון = new TabPage();
            searchIdNumericUpDown = new NumericUpDown();
            label10 = new Label();
            searchNameTextBox = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            הוספה.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberPhoneNumbernumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            עדכון.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updatePhoneNumbernumericUpDown).BeginInit();
            מחיקה.SuspendLayout();
            סינון.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIdNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // רשימת_לקוחות
            // 
            רשימת_לקוחות.FormattingEnabled = true;
            רשימת_לקוחות.Location = new Point(61, 75);
            רשימת_לקוחות.Name = "רשימת_לקוחות";
            רשימת_לקוחות.Size = new Size(301, 324);
            רשימת_לקוחות.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(הוספה);
            tabControl1.Controls.Add(עדכון);
            tabControl1.Controls.Add(מחיקה);
            tabControl1.Controls.Add(סינון);
            tabControl1.Location = new Point(385, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(354, 361);
            tabControl1.TabIndex = 2;
            // 
            // הוספה
            // 
            הוספה.Controls.Add(nameTextBox);
            הוספה.Controls.Add(numberPhoneNumbernumericUpDown);
            הוספה.Controls.Add(label6);
            הוספה.Controls.Add(adressTextBox);
            הוספה.Controls.Add(label5);
            הוספה.Controls.Add(idNumericUpDown);
            הוספה.Controls.Add(label4);
            הוספה.Controls.Add(label1);
            הוספה.Controls.Add(addBtn);
            הוספה.Location = new Point(4, 29);
            הוספה.Name = "הוספה";
            הוספה.Padding = new Padding(3);
            הוספה.Size = new Size(346, 328);
            הוספה.TabIndex = 0;
            הוספה.Text = "הוספה";
            הוספה.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(50, 42);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(160, 27);
            nameTextBox.TabIndex = 26;
            // 
            // numberPhoneNumbernumericUpDown
            // 
            numberPhoneNumbernumericUpDown.Location = new Point(50, 177);
            numberPhoneNumbernumericUpDown.Name = "numberPhoneNumbernumericUpDown";
            numberPhoneNumbernumericUpDown.Size = new Size(160, 27);
            numberPhoneNumbernumericUpDown.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 184);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 14;
            label6.Text = ":מספר טלפון";
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(50, 134);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(160, 27);
            adressTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 137);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 12;
            label5.Text = ":כתובת";
            // 
            // idNumericUpDown
            // 
            idNumericUpDown.Location = new Point(50, 86);
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Size = new Size(160, 27);
            idNumericUpDown.TabIndex = 11;
            idNumericUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 93);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 10;
            label4.Text = ":Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 1;
            label1.Text = ":שם";
            // 
            // addBtn
            // 
            addBtn.Location = new Point(124, 267);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(107, 45);
            addBtn.TabIndex = 0;
            addBtn.Text = "הוספה";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // עדכון
            // 
            עדכון.Controls.Add(updateNameComboBox);
            עדכון.Controls.Add(updatePhoneNumbernumericUpDown);
            עדכון.Controls.Add(label2);
            עדכון.Controls.Add(updateAdressTextBox);
            עדכון.Controls.Add(label7);
            עדכון.Controls.Add(label9);
            עדכון.Controls.Add(updateBtn);
            עדכון.Location = new Point(4, 29);
            עדכון.Name = "עדכון";
            עדכון.Padding = new Padding(3);
            עדכון.Size = new Size(346, 328);
            עדכון.TabIndex = 1;
            עדכון.Text = "עדכון";
            עדכון.UseVisualStyleBackColor = true;
            // 
            // updateNameComboBox
            // 
            updateNameComboBox.FormattingEnabled = true;
            updateNameComboBox.Location = new Point(41, 42);
            updateNameComboBox.Name = "updateNameComboBox";
            updateNameComboBox.Size = new Size(151, 28);
            updateNameComboBox.TabIndex = 26;
            updateNameComboBox.SelectedIndexChanged += updateNameComboBox_SelectedIndexChanged;
            // 
            // updatePhoneNumbernumericUpDown
            // 
            updatePhoneNumbernumericUpDown.Location = new Point(32, 168);
            updatePhoneNumbernumericUpDown.Name = "updatePhoneNumbernumericUpDown";
            updatePhoneNumbernumericUpDown.Size = new Size(160, 27);
            updatePhoneNumbernumericUpDown.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 175);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 23;
            label2.Text = ":מספר טלפון";
            // 
            // updateAdressTextBox
            // 
            updateAdressTextBox.Location = new Point(32, 125);
            updateAdressTextBox.Name = "updateAdressTextBox";
            updateAdressTextBox.Size = new Size(160, 27);
            updateAdressTextBox.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 128);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 21;
            label7.Text = ":כתובת";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 33);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 17;
            label9.Text = ":שם";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(112, 277);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(107, 45);
            updateBtn.TabIndex = 10;
            updateBtn.Text = "עדכן";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // מחיקה
            // 
            מחיקה.Controls.Add(deleteComboBox);
            מחיקה.Controls.Add(label8);
            מחיקה.Controls.Add(deleteBtn);
            מחיקה.Location = new Point(4, 29);
            מחיקה.Name = "מחיקה";
            מחיקה.Size = new Size(346, 328);
            מחיקה.TabIndex = 2;
            מחיקה.Text = "מחיקה";
            מחיקה.UseVisualStyleBackColor = true;
            // 
            // deleteComboBox
            // 
            deleteComboBox.FormattingEnabled = true;
            deleteComboBox.Location = new Point(83, 95);
            deleteComboBox.Name = "deleteComboBox";
            deleteComboBox.Size = new Size(151, 28);
            deleteComboBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(107, 45);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 27;
            label8.Text = "בחר מוצר למחיקה";
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
            סינון.Controls.Add(searchIdNumericUpDown);
            סינון.Controls.Add(label10);
            סינון.Controls.Add(searchNameTextBox);
            סינון.Controls.Add(label3);
            סינון.Location = new Point(4, 29);
            סינון.Name = "סינון";
            סינון.Size = new Size(346, 328);
            סינון.TabIndex = 3;
            סינון.Text = "סינון";
            סינון.UseVisualStyleBackColor = true;
            // 
            // searchIdNumericUpDown
            // 
            searchIdNumericUpDown.Location = new Point(48, 138);
            searchIdNumericUpDown.Name = "searchIdNumericUpDown";
            searchIdNumericUpDown.Size = new Size(150, 27);
            searchIdNumericUpDown.TabIndex = 3;
            searchIdNumericUpDown.ValueChanged += key_up_searchIdNumericUpDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(204, 140);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 2;
            label10.Text = " Idחיפוש לפי ";
            // 
            // searchNameTextBox
            // 
            searchNameTextBox.AcceptsTab = true;
            searchNameTextBox.Location = new Point(73, 75);
            searchNameTextBox.Name = "searchNameTextBox";
            searchNameTextBox.Size = new Size(125, 27);
            searchNameTextBox.TabIndex = 1;
            searchNameTextBox.TextChanged += key_up_searchName;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 82);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 0;
            label3.Text = "חיפוש לפי שם";
            // 
            // CustomerManagment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(רשימת_לקוחות);
            Controls.Add(tabControl1);
            Name = "CustomerManagment";
            Text = "CustomerManagment";
            tabControl1.ResumeLayout(false);
            הוספה.ResumeLayout(false);
            הוספה.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberPhoneNumbernumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            עדכון.ResumeLayout(false);
            עדכון.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updatePhoneNumbernumericUpDown).EndInit();
            מחיקה.ResumeLayout(false);
            מחיקה.PerformLayout();
            סינון.ResumeLayout(false);
            סינון.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIdNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox רשימת_לקוחות;
        private TabControl tabControl1;
        private TabPage הוספה;
        private Label label1;
        private Button addBtn;
        private TabPage מחיקה;
        private Button deleteBtn;
        private TabPage סינון;
        private NumericUpDown idNumericUpDown;
        private Label label4;
        private NumericUpDown numberPhoneNumbernumericUpDown;
        private Label label6;
        private TextBox adressTextBox;
        private Label label5;
        private TabPage עדכון;
        private Button updateBtn;
        private NumericUpDown updatePhoneNumbernumericUpDown;
        private Label label2;
        private TextBox updateAdressTextBox;
        private Label label7;
        private Label label9;
        private TextBox nameTextBox;
        private ComboBox updateNameComboBox;
        private ComboBox deleteComboBox;
        private Label label8;
        private TextBox searchNameTextBox;
        private Label label3;
        private NumericUpDown searchIdNumericUpDown;
        private Label label10;
    }
}