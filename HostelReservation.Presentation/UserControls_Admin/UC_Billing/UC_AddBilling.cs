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
    public partial class UC_AddBilling : UserControl
    {
        public UC_AddBilling()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            BillingServices billingServices = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));
            CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
            Customer customer = new Customer();
            Billings billings = new Billings();
            if (PricetestextBox.Text != "" && DeposittextBox.Text != "" && NumOfDaystextBox.Text != "" && customerIDDtextBox.Text != "")
            {
                int CustomerID = int.Parse(customerIDDtextBox.Text);

                customer = customerServices.GetCustomerByID(CustomerID);
                if (customer != null)
                {
                    billings.Price = decimal.Parse(PricetestextBox.Text);
                    billings.Deposit = decimal.Parse(DeposittextBox.Text);
                    billings.NumberOFDays = int.Parse(NumOfDaystextBox.Text);
                    billings.CustomerId = CustomerID;
                    billingServices.CreateBilling(billings);
                    MessageBox.Show("Successfully Added");
                    PricetestextBox.Text = "";
                    DeposittextBox.Text = "";
                    NumOfDaystextBox.Text = "";
                    customerIDDtextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Not Found Customer");
                    PricetestextBox.Text = "";
                    DeposittextBox.Text = "";
                    NumOfDaystextBox.Text = "";
                    customerIDDtextBox.Text = "";
                    return;
                }
            }
        }
    }
}
