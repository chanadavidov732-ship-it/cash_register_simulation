namespace UI
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubMenu f = new SubMenu(this);
            this.Hide();
            f.Show();
        }

        private void H_cashierButton_Click(object sender, EventArgs e)
        {
            CashierForm f = new CashierForm(this);
            this.Hide();
            f.Show();
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}
