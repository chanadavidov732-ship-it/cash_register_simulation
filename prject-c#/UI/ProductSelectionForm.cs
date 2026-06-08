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
    public partial class ProductSelectionForm : Form
    {
        private readonly BlApi.IBl _bl = BlApi.Factory.Get();

        public int SelectedProductId { get; private set; }

        public ProductSelectionForm()
        {
            InitializeComponent();
        }

        private CashierForm _parentForm;

        public ProductSelectionForm(CashierForm parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ProductSelectionForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = _bl.Product.ReadAll()
                .Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.ProductPrice,
                    p.ProductQuntity,
                    p.ProductCategory
                }).ToList();

            dgvProducts.ReadOnly = true;
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            SelectedProductId = (int)dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backInSelection_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }
    }
}
