using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.Reservations;
using HostelReservation.Infrastructure.Repositories.ReservationRepositary;
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
    public partial class UC_ViewReservation : UserControl
    {
        Reservationservice reservationservice = new Reservationservice(new ReservationRepositary(new Context.HostelDbContext()));
        public UC_ViewReservation()
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
    }
}
