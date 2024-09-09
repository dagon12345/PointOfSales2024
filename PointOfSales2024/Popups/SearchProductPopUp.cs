using PointOfSales2024.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales2024.Popups
{
    public partial class SearchProductPopUp : Form
    {
        private PosContext _dbContext;
        public SearchProductPopUp()
        {
            InitializeComponent();
        }

        private void SearchProductPopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
