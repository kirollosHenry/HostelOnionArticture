using HostelReservation.Applications.Services.Billing;
using HostelReservation.Applications.Services.CustomerService;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.Reservations;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Infrastructure.Repositories.BillingReposatory;
using HostelReservation.Infrastructure.Repositories.CustomerRepository;
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

namespace HostelReservation.Presentation.UserControls_Admin.UC_Reservation
{
    public partial class UC_AddReservation : UserControl
    {
        Reservationservice reservationservice = new Reservationservice(new ReservationRepositary(new Context.HostelDbContext())); 
        RoomService roomService = new RoomService(new RoomRepository(new Context.HostelDbContext()));
        CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
        BillingServices billingServices = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));
        
        Customer customer = new Customer();
        Room room = new Room();
        Billings billings = new Billings();
        Reservation reservation = new Reservation();    
        public UC_AddReservation()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (BillingIDtextBox.Text != "" && CustomerIdtextBox.Text != "" && RoomIDtextBox.Text != "")
            {
                int CustomerID = int.Parse(CustomerIdtextBox.Text);
                int RoomID = int.Parse(RoomIDtextBox.Text);
                int BillingID = int.Parse(BillingIDtextBox.Text);

                customer = customerServices.GetCustomerByID(CustomerID);
                room = roomService.GetRoomByID(RoomID);
                billings = billingServices.GetBillingByID(BillingID);

                if(customer != null)
                {
                    if(room != null)
                    {
                        if(billings != null)
                        {
                            reservation.ReservationCheckIn = DateTime.Parse(dateTimePicker1.Value.Date.ToString());
                            reservation.ReservationCheckOut = DateTime.Parse(dateTimePicker2.Value.Date.ToString());
                            reservation.BillingId = BillingID;
                            reservation.CustomerID = CustomerID;
                            reservation.RoomID = RoomID;
                            reservationservice.CreateReservationl(reservation);
                            MessageBox.Show("Successfully Added");
                            BillingIDtextBox.Text = "";
                            CustomerIdtextBox.Text = "";
                            RoomIDtextBox.Text = "";
                            dateTimePicker1.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Not Found Billing");
                            BillingIDtextBox.Text = "";
                            CustomerIdtextBox.Text = "";
                            RoomIDtextBox.Text = "";
                            dateTimePicker1.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Found Room");
                        BillingIDtextBox.Text = "";
                        CustomerIdtextBox.Text = "";
                        RoomIDtextBox.Text = "";
                        dateTimePicker1.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Not Found Customer");
                    BillingIDtextBox.Text = "";
                    CustomerIdtextBox.Text = "";
                    RoomIDtextBox.Text = "";
                    dateTimePicker1.Text = "";
                    return;
                }
            }
        }
    }
}
