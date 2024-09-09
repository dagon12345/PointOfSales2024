using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
