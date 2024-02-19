using System;
using HostelReservation.Applications.Services.Authorization;
using HostelReservation.Infrastructure.Repositories.AuthorizationRepoistory;

namespace HostelReservation.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;
            AuthorizationService authorizationService = new AuthorizationService(new AuthorizationRepoistory(new Context.HostelDbContext()));
            var User = authorizationService.CheckIdentity(UserName, Password);
            if (User == null)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else if (User.Role == "Admin")
            {
                this.Visible = false;
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else if (User.Role == "Reseption")
            {
                this.Visible = false;
                ReseptionForm reseptionForm = new ReseptionForm();
                reseptionForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
