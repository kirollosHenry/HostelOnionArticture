using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Infrastructure.Repositories.CustomerRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostelReservation.Presentation.UserControls_Admin.UC_Customer
{
    public partial class UC_DeleteCustomercs : UserControl
    {
        CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));

        public UC_DeleteCustomercs()
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDtextBox.Text != "")
            {
                int CustomerID = int.Parse(CustomerIDtextBox.Text);
                customerServices.DeleteCustomer(CustomerID);
                MessageBox.Show("Successfully Deleted");
                CustomerIDtextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Id to Delete");
            }
        }
    }
}
