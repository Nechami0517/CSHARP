namespace UI
{
    partial class Login
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
            send.Location = new Point(307, 191);
            send.Margin = new Padding(3, 2, 3, 2);
            send.Name = "send";
            send.Size = new Size(82, 22);
            send.TabIndex = 0;
            send.Text = "שלח";
            send.UseVisualStyleBackColor = true;
            send.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 45);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "הכנס פרטים";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(291, 87);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(291, 129);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(110, 23);
            textBoxId.TabIndex = 4;
            textBoxId.Text = "1";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(444, 89);
            name.Name = "name";
            name.Size = new Size(24, 15);
            name.TabIndex = 5;
            name.Text = "שם";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(444, 134);
            id.Name = "id";
            id.Size = new Size(25, 15);
            id.TabIndex = 6;
            id.Text = "ת\"ז";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(id);
            Controls.Add(name);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(send);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
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