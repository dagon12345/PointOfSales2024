using Microsoft.EntityFrameworkCore;
using PointOfSales2024.Data;
using System.Data;
using System.Diagnostics;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;

namespace PointOfSales2024.Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new PosContext())
            {
                var loginForm = await context.AppUsers.Where(login => login.UserName == txtUsername.Text.ToLower() && login.Password == txtPassword.Text)
                    .FirstOrDefaultAsync();

                if (loginForm != null)
                {

                    int appUserId = loginForm.AppUserId;
                    string Name = loginForm.Name.ToString();
                    bool IsAdmin = loginForm.IsAdmin;

                    //Sucessful login, open dashboard
                    DashboardForm dashboardForm = new DashboardForm(Name, IsAdmin, appUserId);

                    dashboardForm.Show();
                    //Hide or close the current login form
                    this.Hide();//You can also use this.Close() to close the form entirely which is not proper.
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void updater()
        {
            WebClient webClient = new WebClient();
            var client = new WebClient();

            if (!webClient.DownloadString("https://www.dropbox.com/s/62hfq7ylzn480sv/Update.txt?dl=1").Contains("4.0.5"))
            {


                if (MessageBox.Show("New update available! Do you want to install it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {


                        if (File.Exists(@".\QueueInstaller.msi")) { File.Delete(@".\QueueInstaller.msi"); }
                        client.DownloadFile("https://www.dropbox.com/s/pa8ydxmxgud2926/QueueInstaller.zip?dl=1", @"QueueInstaller.zip");
                        string zipPath = @".\QueueInstaller.zip";
                        string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);






                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = String.Format("/i QueueInstaller.msi");



                        process.Start();

                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //updater();
        }
    }
}
