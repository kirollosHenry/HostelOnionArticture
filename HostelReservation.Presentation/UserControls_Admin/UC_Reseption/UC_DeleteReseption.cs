using HostelReservation.Applications.Services.Authorization;
using HostelReservation.Infrastructure.Repositories.AuthorizationRepoistory;
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
    public partial class UC_DeleteReseption : UserControl
    {
        AuthorizationService authorizationService = new AuthorizationService(new AuthorizationRepoistory(new Context.HostelDbContext()));
        public UC_DeleteReseption()
        {
            InitializeComponent();
            dataGridView1.DataSource = authorizationService.GetReseptions().ToList();
            //dataGridView1.Columns.Add("", "Id");
            //dataGridView1.Columns.Add("", "USerName");
            //dataGridView1.Columns.Add("", "Role");
            //dataGridView1.Columns.Add("", "Password");
            dataGridView1.Columns[0].Width = 320;
            dataGridView1.Columns[1].Width = 320;
            dataGridView1.Columns[2].Width = 320;
            dataGridView1.Columns[3].Width = 320;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ReseptionIDtextBox.Text != "")
            {
                int UserId = int.Parse(ReseptionIDtextBox.Text);
                authorizationService.DeleteUser(UserId);
                MessageBox.Show("Successfully Deleted");
                ReseptionIDtextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Id to Delete");
            }
        }
    }
}
