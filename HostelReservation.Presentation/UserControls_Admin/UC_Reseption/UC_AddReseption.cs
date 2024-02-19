using HostelReservation.Applications.Services.Authorization;
using HostelReservation.Infrastructure.Repositories.AuthorizationRepoistory;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelReservation.Presentation.UserControls_Admin.UC_Reseption
{
    public partial class UC_AddReseption : UserControl
    {
        public UC_AddReseption()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsertextBox.Text != "" && PasstextBox.Text != "")
            {
                AuthorizationService authorizationService = new AuthorizationService(new AuthorizationRepoistory(new Context.HostelDbContext()));
                Authorizations User = new Authorizations();
                User.UserName = UsertextBox.Text;
                User.Password = PasstextBox.Text;
                User.Role = "Reseption";
                authorizationService.CreateUser(User);
                MessageBox.Show("Successfully Added");

                UsertextBox.Text = "";
                PasstextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter UserName and Password");
            }
           
        }
    }
}
