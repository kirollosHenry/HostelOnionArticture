using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Infrastructure.Repositories.CustomerRepository;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
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

namespace HostelReservation.Presentation.UserControls_Admin.UC_Customer
{
    public partial class UC_AddCustomer : UserControl
    {

        public UC_AddCustomer()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CNametextBox.Text != "" && CCitytextBox.Text != "" && CPhonetextBox.Text != "")
            {
                CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
                Customer customer = new Customer();

                customer.Name = CNametextBox.Text;
                customer.City = CCitytextBox.Text;
                customer.Phone = int.Parse(CPhonetextBox.Text);
                customerServices.CreateCustomer(customer);
                MessageBox.Show("Successfully Added");
                CNametextBox.Text = "";
                CCitytextBox.Text = "";
                CPhonetextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Valid Hotel Name and Hotle Phone and Hotel Zip");
            }
        }
    }
}
