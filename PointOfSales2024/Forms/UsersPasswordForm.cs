using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;

namespace PointOfSales2024.Forms
{
    public partial class UsersPasswordForm : Form
    {
        public UsersPasswordForm()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadUsers();
        }

        private async Task LoadUsers()
        {
            using (var context = new PosContext())
            {
                var registeredUsers = await context.AppUsers
                    .ToListAsync();
                //Display data from appusers database.
                dataGridView1.DataSource = registeredUsers;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Empty table");
                return;
            }

            //Select the AppUserId to fill the textbox above.
            int selectedAppUserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["AppUserId"].Value);

            using (var context = new PosContext())
            {

                // get the appuserid into our database.
                var selectedUser = context.AppUsers
                    .FirstOrDefault(x => x.AppUserId == selectedAppUserId);

                lblAppUserId.Text = selectedAppUserId.ToString();
                txtUsername.Text = selectedUser.UserName;
                txtPassword.Text = selectedUser.Password;
            }


        }
        //Update password in database.
        private async void btUpdate_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text == "")
            {
                MessageBox.Show("Empty field", "Fill", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to update the password?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int selectedAppUserId = Convert.ToInt32(lblAppUserId.Text);
                using (var context = new PosContext())
                {
                    //Data type and variables
                    var passwordtoUpdate = context.AppUsers.Find(selectedAppUserId);
                    passwordtoUpdate.Password = txtNewPassword.Text;
                    await context.SaveChangesAsync();
                    MessageBox.Show("Password successfully changed","Success");
                    await LoadUsers();
                }


            }
           
        }
    }
}
