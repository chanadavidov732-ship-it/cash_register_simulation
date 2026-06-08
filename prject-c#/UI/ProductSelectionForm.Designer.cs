namespace UI
{
    partial class ProductSelectionForm
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
            dgvProducts = new DataGridView();
            backInSelection = new Button();
            ListProducts = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(28, 67);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(685, 346);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // backInSelection
            // 
            backInSelection.Location = new Point(737, 26);
            backInSelection.Name = "backInSelection";
            backInSelection.Size = new Size(34, 23);
            backInSelection.TabIndex = 7;
            backInSelection.Text = "➡️";
            backInSelection.UseVisualStyleBackColor = true;
            backInSelection.Click += backInSelection_Click;
            // 
            // ListProducts
            // 
            ListProducts.AutoSize = true;
            ListProducts.Font = new Font("Agency FB", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListProducts.Location = new Point(249, 19);
            ListProducts.Name = "ListProducts";
            ListProducts.Size = new Size(280, 32);
            ListProducts.TabIndex = 8;
            ListProducts.Text = "רשימת מוצרים להוספה לסל";
            // 
            // ProductSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListProducts);
            Controls.Add(backInSelection);
            Controls.Add(dgvProducts);
            Name = "ProductSelectionForm";
            Text = "ProductSelectionForm";
            Load += ProductSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button backInSelection;
        private Label ListProducts;
    }
}