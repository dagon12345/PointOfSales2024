using PointOfSales2024.Forms;
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
    public partial class AdminPopup : Form
    {
        public AdminPopup()
        {
            InitializeComponent();
            txtPassword.Focus();
        }

        UsersPasswordForm userPasswordForm;
        private void btnEnter_Click(object sender, EventArgs e)
        {

            if(txtPassword.Text == "admin12345")
            {
                this.Close();
                if (Application.OpenForms.OfType<UsersPasswordForm>().Any())
                {
                    userPasswordForm.Select();
                    userPasswordForm.BringToFront();
                }
                else
                {
                    userPasswordForm = new UsersPasswordForm();
                    userPasswordForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials, please contact your admin", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
