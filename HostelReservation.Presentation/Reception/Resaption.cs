using HostelReservation.Applications.Services.HotelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Model;
using HostelReservation.Applications.Services.Authorization;
using HostelReservation.Infrastructure.Repositories.AuthorizationRepoistory;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
using HostelReservation.Infrastructure.Repositories.RoomRepository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HostelReservation.Infrastructure.Repositories.CustomerRepository;
using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.Reservations;
using HostelReservation.Infrastructure.Repositories.ReservationRepositary;
using HostelReservation.Applications.Services.Billing;
using HostelReservation.Infrastructure.Repositories.BillingReposatory;
namespace HostelReservation.Presentation.ResaptionForms
{
    public partial class Resaption : Form
    {
        AuthorizationService authorizationService = new AuthorizationService(new AuthorizationRepoistory(new Context.HostelDbContext()));
        HotelServices hotel = new HotelServices(new HotelRepository(new Context.HostelDbContext()));
        RoomService room = new RoomService(new RoomRepository(new Context.HostelDbContext()));
        CustomerServices customer = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
        Reservationservice reserve = new Reservationservice(new ReservationRepositary(new Context.HostelDbContext()));
        BillingServices bill = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));
        int Hotelid, Roomid;
        decimal money;
        public Resaption()
        {
            InitializeComponent();
            //dataGridView1.DataSource = hotel.GetAllHotel();
        }

        private void Resaption_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hotel.GetAllHotel();

            dataGridView1.Columns[0].Width = 156;
            dataGridView1.Columns[1].Width = 156;
            dataGridView1.Columns[2].Width = 156;
            dataGridView1.Columns[3].Width = 156;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);

            //  List<Hotel> list = hotel.GetAllHotel();
            //dataGridView1.DataSource = list;
            //label10.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewRow selectedRow = dgv.SelectedRows[0];
            int hotelid = int.Parse(selectedRow.Cells["HotelID"].Value.ToString()!);
            dataGridView2.DataSource = room.GetRoomsInHotel(hotelid);
            Hotelid = hotelid;

            dataGridView2.Columns[0].Width = 125;
            dataGridView2.Columns[1].Width = 125;
            dataGridView2.Columns[2].Width = 125;
            dataGridView2.Columns[3].Width = 125;
            dataGridView2.Columns[4].Width = 125;
            dataGridView2.Columns[5].Width = 125;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);

        }
        //private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    DataGridView dgv = (DataGridView)sender;
        //    if (dgv.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dgv.SelectedRows[0];
        //        int hotelid = int.Parse(selectedRow.Cells["HotelID"].Value.ToString()!);
        //        dataGridView2.DataSource = room.GetRoomsInHotel(hotelid);
        //    }
        //}

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewRow selectedrow = view.SelectedRows[0];
            Roomid = int.Parse(selectedrow.Cells["RoomId"].Value.ToString()!);
            money = decimal.Parse(selectedrow.Cells["RoomRates"].Value.ToString()!);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Customer c1 = new Customer();
            c1.Name = textBox2.Text;
            c1.City = textBox3.Text;
            c1.Phone = int.Parse(textBox4.Text);
            c1 = customer.CreateCustomer(c1);
            Reservation reservation = new Reservation();
            reservation.CustomerID = c1.ID;
            reservation.ReservationCheckIn = DateTime.Parse(dateTimePicker1.Value.Date.ToString());
            reservation.ReservationCheckOut = DateTime.Parse(dateTimePicker2.Value.Date.ToString());
            reservation.RoomID = Roomid;
            Billings billings = new Billings();
            billings.CustomerId = c1.ID;
            billings.NumberOFDays = (int)(reservation.ReservationCheckOut - reservation.ReservationCheckIn).TotalDays;
            billings.Price = money * billings.NumberOFDays;
            billings.Deposit = billings.Price - decimal.Parse(textBox7.Text);
            billings = bill.CreateBilling(billings);
            reservation.BillingId = billings.BillingId;
            reservation = reserve.CreateReservationl(reservation);
            if (reservation != null && billings != null)
            {
                MessageBox.Show("Successfully SUBMIT");

                this.Visible = false;
                ReseptionForm resaptionForms = new ReseptionForm();
                resaptionForms.ShowDialog();
                return;
            }

            MessageBox.Show("Falid SUBMIT");

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            decimal total = (int)(dateTimePicker2.Value.Date - dateTimePicker1.Value.Date).TotalDays * money;
            label3.Visible = true;
            label3.ForeColor = Color.Red;
            label3.Text = "Total Price is : " + total.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReseptionForm resaptionForms = new ReseptionForm();
            resaptionForms.ShowDialog();
        }
    }
}
