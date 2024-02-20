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
    public partial class UC_UpdateReservation : UserControl
    {
        Reservationservice reservationservice = new Reservationservice(new ReservationRepositary(new Context.HostelDbContext()));
        RoomService roomService = new RoomService(new RoomRepository(new Context.HostelDbContext()));
        CustomerServices customerServices = new CustomerServices(new CustomerRepository(new Context.HostelDbContext()));
        BillingServices billingServices = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));

        public UC_UpdateReservation()
        {
            InitializeComponent();
            dataGridView1.DataSource = reservationservice.GetAllReservation().ToList();
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                Customer customer = new Customer();
                Room room = new Room();
                Billings billings = new Billings();
                Reservation reservation = new Reservation();

                int ReservationId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()!);
                DateTime ReservationcheckIn = DateTime.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()!);
                DateTime ReservationcheckOut = DateTime.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()!);
                int BillingID = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()!);
                int RoomID = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()!);
                int CustomerID = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()!);

                customer = customerServices.GetCustomerByID(CustomerID);
                room = roomService.GetRoomByID(RoomID);
                billings = billingServices.GetBillingByID(BillingID);

                if (customer != null)
                {
                    if (room != null)
                    {
                        if (billings != null)
                        {
                            reservation = reservationservice.GetReservationID(ReservationId);

                            reservation.ReservationCheckIn = ReservationcheckIn;
                            reservation.ReservationCheckOut = ReservationcheckOut;
                            reservation.BillingId = BillingID;
                            reservation.CustomerID = CustomerID;
                            reservation.RoomID = RoomID;
                            reservationservice.UpdateReservation(reservation);
                        }
                        else
                        {
                            MessageBox.Show("Not Found Billing");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Found Room");
                        return;
                    }
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
