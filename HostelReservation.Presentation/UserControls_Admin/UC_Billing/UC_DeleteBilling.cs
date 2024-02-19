using HostelReservation.Applications.Services.Billing;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Infrastructure.Repositories.BillingReposatory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelReservation.Presentation.UserControls_Admin.UC_Billing
{
    public partial class UC_DeleteBilling : UserControl
    {
        BillingServices billingServices = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));

        public UC_DeleteBilling()
        {
            InitializeComponent();
            dataGridView1.DataSource = billingServices.GetAllBilling().ToList();
            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].Width = 270;
            dataGridView1.Columns[2].Width = 270;
            dataGridView1.Columns[3].Width = 270;
            dataGridView1.Columns[4].Width = 270;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BillingIdDtextBox.Text != "")
            {
                int BillingID = int.Parse(BillingIdDtextBox.Text);
                billingServices.DeleteBilling(BillingID);
                MessageBox.Show("Successfully Deleted");
                BillingIdDtextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Id to Delete");
            }
        }
    }
}
