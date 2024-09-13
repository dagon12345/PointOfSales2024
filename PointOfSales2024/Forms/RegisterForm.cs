using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using PointOfSales2024.Models;

namespace PointOfSales2024.Forms
{
    public partial class RegisterForm : Form
    {
        private AppUser _appUser;
        public RegisterForm()
        {
            InitializeComponent();
        }

        public async Task validation()
        {
            using (var context = new PosContext())
            { 
                var validation = await context.AppUsers.Where(u => u.UserName == txtUsername.Text.ToLower())
                    .FirstOrDefaultAsync();

                if (validation != null)
                {
                    MessageBox.Show("Username already exist. Please try again","Existed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await register();
            }
        }

        private async Task register()
        {

            using (var context = new PosContext())
            {


                _appUser = new AppUser
                {
                    Name = txtFullname.Text,
                    UserName = txtUsername.Text.ToLower(),
                    Password = txtPass.Text,
                    IsAdmin = checkAdmin.Checked,

                };

            
                context.AppUsers.Add(_appUser);
                context.SaveChangesAsync();

                MessageBox.Show("User registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPass.Text == "" || txtConfirmPassword.Text == "" || txtFullname.Text == "")
            {
                MessageBox.Show("Please fill all the fields before you continue.", "Fill all the Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPass.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password don't match please try again.", "Password did not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await validation();
        }
    }
}
