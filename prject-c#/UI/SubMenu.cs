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
    public partial class SubMenu : Form
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public SubMenu()
        {
            InitializeComponent();
        }
        private Index _parentForm;

        public SubMenu(Index parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        private void ShowError(string message) =>
            MessageBox.Show(message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void ShowValidationWarning(string message) =>
            MessageBox.Show(message, "שגיאת קלט", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void backInSubMenu_Click(object sender, EventArgs e)
        {
            _parentForm.Show();
            this.Close();
        }



        ///////////////////////////////////////////////////////////////////////////
        ///CUSTOMERS/////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////


        private void RefreshGridCustomer()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = s_bl.Customer.ReadAll().ToList();
        }
        private void SM_ButtonAddCus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxId.Text, out int cusId))
                { ShowValidationWarning("יש להזין ערכים מספריים תקינים"); return; }
                s_bl.Customer.Create(new BO.Customer(cusId, SM_TextBoxName.Text,
                    SM_TextBoxAdress.Text, SM_TextBoxPhone.Text, DateTime.Now));
                RefreshGridCustomer();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }
        private void SM_ButtonUpdateCus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxId.Text, out int cusId))
                { ShowValidationWarning("יש להזין ערכים מספריים תקינים"); return; }
                s_bl.Customer.UpDate(new BO.Customer(cusId, SM_TextBoxName.Text,
                    SM_TextBoxAdress.Text, SM_TextBoxPhone.Text, DateTime.Now));
                RefreshGridCustomer();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem != null)
                {
                    BO.Customer selectedCustomer = (BO.Customer)dataGridView1.CurrentRow.DataBoundItem;
                    SM_TextBoxId.Text = selectedCustomer.CustomerId.ToString();
                    SM_TextBoxName.Text = selectedCustomer.CustomerName;
                    SM_TextBoxAdress.Text = selectedCustomer.CustomerAdress;
                    SM_TextBoxPhone.Text = selectedCustomer.CustomerPhone;
                }
            }
            catch { }
        }

        private void SM_ButtonDeleteCus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxId.Text, out int cusId))
                { ShowValidationWarning("יש להזין ערכים מספריים תקינים"); return; }
                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "אישור מחיקה",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                s_bl.Customer.Delete(cusId);
                RefreshGridCustomer();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }
        ///////////////////////////////////////////////////////////////////////////
        ///PRODUCTS/////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////


        private void RefreshGridProduct()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = s_bl.Product.ReadAll().ToList();
        }
        private void SubMenu_Load(object sender, EventArgs e)
        {
            SM_ComboBoxCatPro.Items.Clear();

            SM_ComboBoxCatPro.Items.Add("בחר קטגוריה");

            SM_ComboBoxCatPro.Items.AddRange(Enum.GetNames(typeof(BO.Category)));

            SM_ComboBoxCatPro.SelectedIndex = 0;

        }

        private void SM_ButtonAddPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (SM_ComboBoxCatPro.SelectedIndex == 0)
                { ShowValidationWarning("אנא בחר קטגוריה תקינה מתוך הרשימה"); return; }
                if (!int.TryParse(SM_TextBoxQnttyPro.Text, out int qty) ||
                    !double.TryParse(SM_TextBoxPricePro.Text, out double price))
                { ShowValidationWarning("יש להזין ערכים מספריים תקינים"); return; }
                s_bl.Product.Create(new BO.Product(0, SM_TextBoxNamePro.Text,
                    (BO.Category)Enum.Parse(typeof(BO.Category), SM_ComboBoxCatPro.SelectedItem.ToString()),
                    qty, price, DateTime.Now));
                RefreshGridProduct();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void SM_ButtonUpdatePro_Click(object sender, EventArgs e)
        {
            try
            {
                if (SM_ComboBoxCatPro.SelectedIndex == 0)
                { ShowValidationWarning("אנא בחר קטגוריה תקינה מתוך הרשימה"); return; }
                if (!int.TryParse(SM_TextBoxIdPro.Text, out int proId) ||
                    !int.TryParse(SM_TextBoxQnttyPro.Text, out int qty) ||
                    !double.TryParse(SM_TextBoxPricePro.Text, out double price))
                { ShowValidationWarning("יש להזין ערכים מספריים תקינים"); return; }
                s_bl.Product.UpDate(new BO.Product(proId, SM_TextBoxNamePro.Text,
                    (BO.Category)Enum.Parse(typeof(BO.Category), SM_ComboBoxCatPro.SelectedItem.ToString()),
                    qty, price, DateTime.Now));
                RefreshGridProduct();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void SM_ButtonDeletePro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxIdPro.Text, out int proId))
                { ShowValidationWarning("יש להזין ערכים מספריים תקינים"); return; }
                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "אישור מחיקה",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                s_bl.Product.Delete(proId);
                RefreshGridProduct();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow != null && dataGridView2.CurrentRow.DataBoundItem != null)
                {
                    BO.Product selectedProduct = (BO.Product)dataGridView2.CurrentRow.DataBoundItem;
                    SM_TextBoxIdPro.Text = selectedProduct.ProductId.ToString();
                    SM_TextBoxNamePro.Text = selectedProduct.ProductName;
                    SM_TextBoxPricePro.Text = selectedProduct.ProductPrice.ToString();
                    SM_TextBoxQnttyPro.Text = selectedProduct.ProductQuntity.ToString();
                    SM_ComboBoxCatPro.SelectedItem = selectedProduct.ProductCategory.ToString();
                }
            }
            catch { }
        }

        ///////////////////////////////////////////////////////////////////////////
        ///SALES/////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        private void RefreshGridSale()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = s_bl.Sale.ReadAll().ToList();
        }

        private void SM_ButtonAddSales_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxProIdSale.Text, out int saleProId) ||
                    !int.TryParse(SM_TextBoxCountSale.Text, out int saleCount) ||
                    !int.TryParse(SM_TextBoxPriceSale.Text, out int salePrice))
                { ShowValidationWarning("יש להזין מספרים תקינים"); return; }
                if (SM_DateTimeEndSale.Value < SM_DateTimeStartSale.Value)
                { ShowValidationWarning("תאריך הסיום חייב להיות מאוחר מתאריך ההתחלה"); return; }
                s_bl.Sale.Create(new BO.Sale(0, saleProId, saleCount, salePrice,
                    SM_CheckBoxForMemberSale.Checked, SM_DateTimeStartSale.Value, SM_DateTimeEndSale.Value));
                RefreshGridSale();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void SM_ButtonUpdetaSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxIdSale.Text, out int saleId) ||
                    !int.TryParse(SM_TextBoxProIdSale.Text, out int saleProId) ||
                    !int.TryParse(SM_TextBoxCountSale.Text, out int saleCount) ||
                    !int.TryParse(SM_TextBoxPriceSale.Text, out int salePrice))
                { ShowValidationWarning("יש להזין מספרים תקינים"); return; }
                if (SM_DateTimeEndSale.Value < SM_DateTimeStartSale.Value)
                { ShowValidationWarning("תאריך הסיום חייב להיות מאוחר מתאריך ההתחלה"); return; }
                s_bl.Sale.UpDate(new BO.Sale(saleId, saleProId, saleCount, salePrice,
                    SM_CheckBoxForMemberSale.Checked, SM_DateTimeStartSale.Value, SM_DateTimeEndSale.Value));
                RefreshGridSale();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void SM_ButtonDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(SM_TextBoxIdSale.Text, out int saleId))
                { ShowValidationWarning("יש להזין מספרים תקינים"); return; }
                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק?", "אישור מחיקה",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                s_bl.Sale.Delete(saleId);
                RefreshGridSale();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.CurrentRow != null && dataGridView3.CurrentRow.DataBoundItem != null)
                {
                    BO.Sale selectedSale = (BO.Sale)dataGridView3.CurrentRow.DataBoundItem;
                    SM_TextBoxIdSale.Text = selectedSale.SaleId.ToString();
                    SM_TextBoxProIdSale.Text = selectedSale.ProductId.ToString();
                    SM_TextBoxCountSale.Text = selectedSale.Count.ToString();
                    SM_TextBoxPriceSale.Text = selectedSale.Price.ToString();
                    SM_CheckBoxForMemberSale.Checked = selectedSale.ForCustomerMember;
                    SM_DateTimeStartSale.Value = selectedSale.SaleDateStart;
                    SM_DateTimeEndSale.Value = selectedSale.SaleDateEnd;
                }
            }
            catch { }
        }

    }
}
