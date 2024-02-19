using HostelReservation.Applications.Services.Billing;
using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Infrastructure.Repositories.BillingReposatory;
using HostelReservation.Infrastructure.Repositories.CustomerRepository;
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

namespace HostelReservation.Presentation.UserControls_Admin.UC_Billing
{
    public partial class UC_UpdateBilling : UserControl
    {
        BillingServices billingServices = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));
        CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));

        public UC_UpdateBilling()
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Customer customer = new Customer();
                Billings billings = new Billings();

                int BillingID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()!);
                decimal Price = decimal.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()!);
                decimal Deposit = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()!);
                int NumberOfDays = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()!);
                int CustomerID = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()!);

                customer = customerServices.GetCustomerByID(CustomerID);
                if (customer != null)
                {
                    billings = billingServices.GetBillingByID(BillingID);

                    billings.Price = Price;
                    billings.Deposit = Deposit;
                    billings.NumberOFDays = NumberOfDays;
                    billings.CustomerId = CustomerID;
                    billingServices.UpdateBilling(billings);
                }
                else
                {
                    MessageBox.Show("Not Found Customer");
                    return;
                }
            }
            MessageBox.Show("Successfully Updated");
        }
    }
}
