namespace PointOfSales2024.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }


        private void instanceHasBeenClosed(object sender, FormClosedEventArgs e)
        {
            _currentInstance = null;
            _transactionFormCurrentInstance = null;
            _salesFormCurrentInstance = null;
        }

        //Open form and prevent the form from opening again once the instance is not null.

        private ProductForm _currentInstance = null;
        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            if (_currentInstance == null)
            {
                _currentInstance = new ProductForm();
                _currentInstance.FormClosed += instanceHasBeenClosed;
                _currentInstance.Show();
            }
            _currentInstance.BringToFront();
        }



        private TransactionForm _transactionFormCurrentInstance = null;
        private void btnTransact_Click(object sender, EventArgs e)
        {
            if (_transactionFormCurrentInstance == null)
            {
                _transactionFormCurrentInstance = new TransactionForm();
                _transactionFormCurrentInstance.FormClosed += instanceHasBeenClosed;
                _transactionFormCurrentInstance.Show();
            }
            _transactionFormCurrentInstance.BringToFront();
        }

        private SalesForm _salesFormCurrentInstance = null;
        private void btnSales_Click(object sender, EventArgs e)
        {
            if (_salesFormCurrentInstance == null)
            {
                _salesFormCurrentInstance = new SalesForm();
                _salesFormCurrentInstance.FormClosed += instanceHasBeenClosed;
                _salesFormCurrentInstance.Show();
            }
            _salesFormCurrentInstance.BringToFront();
        }

        private void clicked()
        {

            productForm.txt_barcodenumber.Enabled = false;
            productForm.check_barcode.Enabled = false;
            productForm.txt_productName.Enabled = false;
            productForm.txt_price.Enabled = false;
            productForm.btn_remove.Enabled = false;
            productForm.btn_save.Text = "Add Stocks";
            productForm.lblStatus.Text = "Status: Adding Stocks";
            productForm.txt_quantity.Text = "0";
        }
        ProductForm productForm;
        private void btnAddStocks_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<ProductForm>().Any())
            {
                productForm.Select();
                productForm.BringToFront();
            }
            else
            {
                productForm = new ProductForm();
                clicked();
                productForm.ShowDialog();

            }

        }
    }
}
