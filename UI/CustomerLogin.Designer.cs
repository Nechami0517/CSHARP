namespace UI
{
    partial class CustomerLogin
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
            send = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            name = new Label();
            id = new Label();
            SuspendLayout();
            // 
            // send
            // 
            send.Location = new Point(351, 255);
            send.Name = "send";
            send.Size = new Size(94, 29);
            send.TabIndex = 0;
            send.Text = "שלח";
            send.UseVisualStyleBackColor = true;
            send.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 60);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "הכנס פרטים";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(333, 116);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 3;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(333, 172);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(125, 27);
            textBoxId.TabIndex = 4;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(508, 119);
            name.Name = "name";
            name.Size = new Size(31, 20);
            name.TabIndex = 5;
            name.Text = "שם";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(508, 179);
            id.Name = "id";
            id.Size = new Size(31, 20);
            id.TabIndex = 6;
            id.Text = "ת\"ז";
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(id);
            Controls.Add(name);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(send);
            Name = "CustomerLogin";
            Text = "CustomerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button send;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label name;
        private Label id;
    }
}