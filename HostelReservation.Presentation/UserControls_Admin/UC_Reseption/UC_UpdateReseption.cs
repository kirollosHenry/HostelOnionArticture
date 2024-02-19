using HostelReservation.Applications.Services.Authorization;
using HostelReservation.Infrastructure.Repositories.AuthorizationRepoistory;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelReservation.Presentation.UserControls_Admin.UC_Reseption
{
    public partial class UC_UpdateReseption : UserControl
    {
        AuthorizationService authorizationService = new AuthorizationService(new AuthorizationRepoistory(new Context.HostelDbContext()));
        
        public UC_UpdateReseption()
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Authorizations authorizations = new Authorizations();
                int UserID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()!);
                string UserName = dataGridView1.Rows[i].Cells[1].Value.ToString()!;
                string Role = dataGridView1.Rows[i].Cells[2].Value.ToString()!;
                string Password = dataGridView1.Rows[i].Cells[3].Value.ToString()!;

                authorizations = authorizationService.GetUserId(UserID);

                authorizations.UserName = UserName;
                authorizations.Role = Role;
                authorizations.Password = Password;
                authorizationService.UpdateUser(authorizations);
            }
            MessageBox.Show("Successfully Updated");

        }
    }
}
