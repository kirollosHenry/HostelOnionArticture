using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.HotelServices;
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

namespace HostelReservation.Presentation.UserControls_Admin.UC_Customer
{
    public partial class UC_UpdateCustomer : UserControl
    {
        CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));

        public UC_UpdateCustomer()
        {
            InitializeComponent();
            dataGridView1.DataSource = customerServices.GetAllCustomer().ToList();
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
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Customer customer = new Customer();

                int CustomerID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()!);
                string CustomerName = dataGridView1.Rows[i].Cells[1].Value.ToString()!;
                string CustomerCity = dataGridView1.Rows[i].Cells[2].Value.ToString()!;
                int CustomerPhone = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()!);

                customer = customerServices.GetCustomerByID(CustomerID);

                customer.Name = CustomerName;
                customer.City = CustomerCity;
                customer.Phone = CustomerPhone;
                customerServices.UpdateCustomer(customer);
            }
            MessageBox.Show("Successfully Updated");
        }
    }
}
