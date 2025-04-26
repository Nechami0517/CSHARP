namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saleMan = new Button();
            management = new Button();
            SuspendLayout();
            // 
            // saleMan
            // 
            saleMan.Location = new Point(460, 138);
            saleMan.Name = "saleMan";
            saleMan.Size = new Size(192, 87);
            saleMan.TabIndex = 0;
            saleMan.Text = "saleMan";
            saleMan.UseVisualStyleBackColor = true;
            saleMan.Click += saleMan_Click;
            // 
            // management
            // 
            management.Location = new Point(205, 138);
            management.Name = "management";
            management.Size = new Size(192, 87);
            management.TabIndex = 1;
            management.Text = "management";
            management.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(management);
            Controls.Add(saleMan);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button saleMan;
        private Button management;
    }
}
