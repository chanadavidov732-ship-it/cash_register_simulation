namespace UI
{
    partial class CashierForm
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
            dgvOrderProducts = new DataGridView();
            btnAddProduct = new Button();
            btnRemoveProduct = new Button();
            btnDoOrder = new Button();
            lblTotalPrice = new Label();
            cartOrderLabel = new Label();
            backInCashier = new Button();
            txtCustomerId = new TextBox();
            btnCheckCustomer = new Button();
            lblMemberStatus = new Label();
            lblCustomerIdPrompt = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderProducts
            // 
            dgvOrderProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProducts.Location = new Point(41, 67);
            dgvOrderProducts.Name = "dgvOrderProducts";
            dgvOrderProducts.Size = new Size(578, 279);
            dgvOrderProducts.TabIndex = 0;
            dgvOrderProducts.CellContentClick += dgvOrderProducts_CellContentClick;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(653, 67);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(113, 38);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "הוסף מוצר";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Location = new Point(653, 124);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(113, 38);
            btnRemoveProduct.TabIndex = 2;
            btnRemoveProduct.Text = "מחק מוצר";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // btnDoOrder
            // 
            btnDoOrder.Location = new Point(40, 363);
            btnDoOrder.Name = "btnDoOrder";
            btnDoOrder.Size = new Size(166, 50);
            btnDoOrder.TabIndex = 3;
            btnDoOrder.Text = "בצע הזמנה";
            btnDoOrder.UseVisualStyleBackColor = true;
            btnDoOrder.Click += btnDoOrder_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(520, 366);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(99, 15);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "סה״כ לתשלום: 0₪";
            // 
            // cartOrderLabel
            // 
            cartOrderLabel.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartOrderLabel.Location = new Point(261, 19);
            cartOrderLabel.Name = "cartOrderLabel";
            cartOrderLabel.Size = new Size(126, 38);
            cartOrderLabel.TabIndex = 5;
            cartOrderLabel.Text = "סל קניות \U0001f6d2";
            cartOrderLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // backInCashier
            // 
            backInCashier.Location = new Point(732, 26);
            backInCashier.Name = "backInCashier";
            backInCashier.Size = new Size(34, 23);
            backInCashier.TabIndex = 6;
            backInCashier.Text = "➡️";
            backInCashier.UseVisualStyleBackColor = true;
            backInCashier.Click += backInCashier_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(120, 427);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(120, 23);
            txtCustomerId.TabIndex = 7;
            // 
            // btnCheckCustomer
            // 
            btnCheckCustomer.Location = new Point(250, 425);
            btnCheckCustomer.Name = "btnCheckCustomer";
            btnCheckCustomer.Size = new Size(100, 27);
            btnCheckCustomer.TabIndex = 8;
            btnCheckCustomer.Text = "בדוק לקוח";
            btnCheckCustomer.UseVisualStyleBackColor = true;
            btnCheckCustomer.Click += btnCheckCustomer_Click;
            // 
            // lblMemberStatus
            // 
            lblMemberStatus.AutoSize = true;
            lblMemberStatus.Location = new Point(360, 430);
            lblMemberStatus.Name = "lblMemberStatus";
            lblMemberStatus.Size = new Size(80, 15);
            lblMemberStatus.TabIndex = 0;
            lblMemberStatus.Text = "לא נבדק לקוח";
            // 
            // lblCustomerIdPrompt
            // 
            lblCustomerIdPrompt.AutoSize = true;
            lblCustomerIdPrompt.Location = new Point(41, 430);
            lblCustomerIdPrompt.Name = "lblCustomerIdPrompt";
            lblCustomerIdPrompt.Size = new Size(71, 15);
            lblCustomerIdPrompt.TabIndex = 9;
            lblCustomerIdPrompt.Text = "תעודת זהות:";
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(lblMemberStatus);
            Controls.Add(btnCheckCustomer);
            Controls.Add(txtCustomerId);
            Controls.Add(lblCustomerIdPrompt);
            Controls.Add(backInCashier);
            Controls.Add(cartOrderLabel);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnDoOrder);
            Controls.Add(btnRemoveProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(dgvOrderProducts);
            Name = "CashierForm";
            Text = "CashierForm";
            Load += CashierForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderProducts;
        private Button btnAddProduct;
        private Button btnRemoveProduct;
        private Button btnDoOrder;
        private Label lblTotalPrice;
        private Label cartOrderLabel;
        private Button backInCashier;
        private TextBox txtCustomerId;
        private Button btnCheckCustomer;
        private Label lblMemberStatus;
        private Label lblCustomerIdPrompt;
    }
}