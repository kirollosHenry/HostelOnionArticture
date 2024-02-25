using HostelReservation.Applications;
using HostelReservation.Applications.Contracts;
using HostelReservation.Applications.Services.Billing;
using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.Reservations;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Context;
using HostelReservation.Infrastructure.Repositories.BillingReposatory;
using HostelReservation.Infrastructure.Repositories.CustomerRepository;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
using HostelReservation.Infrastructure.Repositories.ReservationRepositary;
using HostelReservation.Infrastructure.Repositories.RoomRepository;
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

namespace HostelReservation.Presentation.AdminReseption
{
    public partial class CheckOutFrm : Form
    {
        public CheckOutFrm()
        {
            InitializeComponent();
        }
        RoomService room = new RoomService(new RoomRepository(new Context.HostelDbContext()));
        //CustomerServices customer = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
        Reservationservice reserve = new Reservationservice(new ReservationRepositary(new Context.HostelDbContext()));
        BillingServices bill = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));

        CustomerServices customerService = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
        string value;
        int v;
        CustomerDto cc = new CustomerDto();
        Customer cu = new Customer();
        private void SearchBtn_Click(object sender , EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // function (get data using name (name) searchtxt.text)
                value = searchtxt.Text;
                var customer= customerService.SerachByName(value).ToList();

                if (customer.Count == 0)
                {
                    
                    MessageBox.Show("No customers found with the specified name.");
                 
                }
                else if (customer.Count >= 1)
                {
                    
                    
                    cu = customer.FirstOrDefault();
                    v = cu.ID;
                    var r = reserve.GetCustomerReservationById(v);
                    var b = bill.SerachCustomerById(v);
                    var c = customerService.GetCustomerByID(v);
                    cc.Name = c.Name;
                    cc.ReservationCheckOut = r.ReservationCheckOut;
                    cc.ReservationCheckIn = r.ReservationCheckIn;
                    cc.Price = b.Price;
                    cc.NumberOFDays = b.NumberOFDays;
                    cc.Deposit = b.Deposit;
                    cc.City = c.City;
                    cc.Phone = c.Phone;

                    var customerList = new List<CustomerDto> { cc };

                    dataGridView1.DataSource = customerList;

                    dataGridView1.Columns[0].Width = 172;
                    dataGridView1.Columns[1].Width = 172;
                    dataGridView1.Columns[2].Width = 172;
                    dataGridView1.Columns[3].Width = 172;
                    dataGridView1.Columns[4].Width = 172;
                    dataGridView1.Columns[5].Width = 172;
                    dataGridView1.Columns[6].Width = 172;
                    dataGridView1.Columns[7].Width = 172;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);

                }
            }
            if (radioButton2.Checked)
            {
                // function (get data using id  (id) serchtxt.text)
                CustomerDto cc= new CustomerDto();

               // value =searchtxt.Text;
                int value;
                if (int.TryParse(searchtxt.Text, out value))
                {
                    var r = reserve.GetCustomerReservationById(value);
                    var b = bill.SerachCustomerById(value);
                    var c = customerService.GetCustomerByID(value);
                    cc.Name = c.Name;
                    cc.ReservationCheckOut = r.ReservationCheckOut;
                    cc.ReservationCheckIn = r.ReservationCheckIn;
                    cc.Price = b.Price;
                    cc.NumberOFDays = b.NumberOFDays;
                    cc.Deposit = b.Deposit;
                    cc.City = c.City;
                    cc.Phone = c.Phone;

                    var customerList = new List<CustomerDto> { cc };
                    dataGridView1.DataSource = customerList;

                    dataGridView1.Columns[0].Width = 172;
                    dataGridView1.Columns[1].Width = 172;
                    dataGridView1.Columns[2].Width = 172;
                    dataGridView1.Columns[3].Width = 172;
                    dataGridView1.Columns[4].Width = 172;
                    dataGridView1.Columns[5].Width = 172;
                    dataGridView1.Columns[6].Width = 172;
                    dataGridView1.Columns[7].Width = 172;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
                }
                else
                {
                    MessageBox.Show("please enter An integr number ");
                }
                //v =int.Parse(value);
                
            }

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
          this.Hide();
          ReseptionForm reseptionForm = new ReseptionForm();
          reseptionForm.ShowDialog();
        }
        private void CheckOutFrm_Load(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchtxt.PlaceholderText = "Customer Name";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchtxt.PlaceholderText = "Customer ID";
        }
    }
}
