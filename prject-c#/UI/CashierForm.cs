using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CashierForm : Form
    {
        private readonly BlApi.IBl _bl = BlApi.Factory.Get();

        private BO.Order _currentOrder = new BO.Order
        {
            ProductListInOrder = new List<BO.ProductInOrder>()
        };

        private BO.Customer? _currentCustomer;

        public CashierForm()
        {
            InitializeComponent();
            txtCustomerId.KeyDown += TxtCustomerId_KeyDown;
        }

        private Index _parentForm;

        public CashierForm(Index parentForm)
        {
            InitializeComponent();
            txtCustomerId.KeyDown += TxtCustomerId_KeyDown;
            _parentForm = parentForm;
        }

        private void backInSubMenu_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }
        private void TxtCustomerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckCustomer_Click(sender, e);
            }
        }
        private void RefreshOrderGrid()
        {
            dgvOrderProducts.DataSource = null;
            dgvOrderProducts.DataSource = _currentOrder.ProductListInOrder
                .Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.ProductOrderCount,
                    AppliedSales =
                        p.ListSaleInProductOrder != null && p.ListSaleInProductOrder.Any()
                            ? string.Join(", ", p.ListSaleInProductOrder.Select(s => $"{s.SaleCount} יח' ב-{s.SalePrice}₪"))
                            : "ללא מבצע",
                    p.ProductTotalPrice
                }).ToList();

            dgvOrderProducts.Columns["ProductId"].HeaderText = "קוד מוצר";
            dgvOrderProducts.Columns["ProductName"].HeaderText = "שם מוצר";
            dgvOrderProducts.Columns["ProductOrderCount"].HeaderText = "כמות";
            dgvOrderProducts.Columns["AppliedSales"].HeaderText = "מבצעים שהופעלו";
            dgvOrderProducts.Columns["ProductTotalPrice"].HeaderText = "מחיר סופי";
            dgvOrderProducts.Columns["AppliedSales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lblTotalPrice.Text = $"סה״כ לתשלום: {_currentOrder.TotalPrice:F2} ₪";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ProductSelectionForm(this))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _bl.Order.AddProductToOrder(_currentOrder, form.SelectedProductId, 1);
                        RefreshOrderGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrderProducts.CurrentRow == null)
                {
                    MessageBox.Show("יש לבחור מוצר להסרה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int productId = (int)dgvOrderProducts.CurrentRow.Cells["ProductId"].Value;

                _bl.Order.AddProductToOrder(_currentOrder, productId, -1);

                var product = _currentOrder.ProductListInOrder.FirstOrDefault(p => p.ProductId == productId);
                if (product != null && product.ProductOrderCount == 0)
                    _currentOrder.ProductListInOrder.Remove(product);

                RefreshOrderGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_currentOrder.ProductListInOrder.Any())
                {
                    MessageBox.Show("אין מוצרים בהזמנה.", "הזמנה ריקה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _bl.Order.DoOrder(_currentOrder);

                MessageBox.Show("ההזמנה בוצעה בהצלחה!", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _currentOrder = new BO.Order
                {
                    ProductListInOrder = new List<BO.ProductInOrder>()
                };

                RefreshOrderGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustomerId.Text, out int customerId))
            {
                lblMemberStatus.Text = "יש להזין מספר תקין";
                lblMemberStatus.ForeColor = Color.Red;
                return;
            }

            try
            {
                var customer = _bl.Customer.Read(customerId);
                if (customer != null)
                {
                    _currentCustomer = customer;
                    lblMemberStatus.Text = $"חבר מועדון ✔ | {customer.CustomerName}";
                    lblMemberStatus.ForeColor = Color.Green;
                    _currentOrder.member = true;
                }
                else
                {
                    _currentCustomer = null;
                    lblMemberStatus.Text = "לקוח לא נמצא / לא חבר מועדון";
                    lblMemberStatus.ForeColor = Color.Red;
                    _currentOrder.member = false;
                }
            }
            catch
            {
                _currentCustomer = null;
                lblMemberStatus.Text = "לקוח לא נמצא / לא חבר מועדון";
                lblMemberStatus.ForeColor = Color.Red;
                _currentOrder.member = false;
            }

            foreach (var item in _currentOrder.ProductListInOrder)
            {
                _bl.Order.SearchSaleForProduct(item, _currentOrder.member);
                _bl.Order.CalcTotalPriceForProduct(item);
            }
            _bl.Order.CalcTotalPrice(_currentOrder);
            RefreshOrderGrid();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            dgvOrderProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _currentOrder.member = false;
            lblMemberStatus.Text = "לא נבדק לקוח";
            lblMemberStatus.ForeColor = Color.Gray;
        }

        private void dgvOrderProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backInCashier_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }
    }
}
