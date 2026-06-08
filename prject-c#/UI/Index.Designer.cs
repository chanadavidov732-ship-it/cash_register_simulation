namespace UI
{
    partial class Index
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
            H_managerButton = new Button();
            H_cashierButton = new Button();
            SuspendLayout();
            // 
            // H_managerButton
            // 
            H_managerButton.Location = new Point(159, 171);
            H_managerButton.Name = "H_managerButton";
            H_managerButton.Size = new Size(214, 94);
            H_managerButton.TabIndex = 0;
            H_managerButton.Text = "מנהל";
            H_managerButton.UseVisualStyleBackColor = true;
            H_managerButton.Click += button1_Click;
            // 
            // H_cashierButton
            // 
            H_cashierButton.Location = new Point(431, 171);
            H_cashierButton.Name = "H_cashierButton";
            H_cashierButton.Size = new Size(214, 94);
            H_cashierButton.TabIndex = 1;
            H_cashierButton.Text = "קופאי";
            H_cashierButton.UseVisualStyleBackColor = true;
            H_cashierButton.Click += H_cashierButton_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(H_cashierButton);
            Controls.Add(H_managerButton);
            Name = "Index";
            Text = "Form1";
            Load += Index_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button H_managerButton;
        private Button H_cashierButton;
    }
}
