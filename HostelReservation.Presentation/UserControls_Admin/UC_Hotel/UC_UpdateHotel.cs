using HostelReservation.Applications.Services.Authorization;
using HostelReservation.Applications.Services.HotelServices;
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

namespace HostelReservation.Presentation.UserControls_Admin.UC_Hotel
{
    public partial class UC_UpdateHotel : UserControl
    {
        HotelServices hotelServices = new HotelServices(new HotelRepository(new Context.HostelDbContext()));

        public UC_UpdateHotel()
        {
            InitializeComponent();
            dataGridView1.DataSource = hotelServices.GetAllHotel().ToList();
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
                Hotel hotel = new Hotel();

                int HotelID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()!);
                string HotelName = dataGridView1.Rows[i].Cells[1].Value.ToString()!;
                string HotelPhone = dataGridView1.Rows[i].Cells[2].Value.ToString()!;
                int HotelZIP = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()!);

                hotel = hotelServices.GetHotelByID(HotelID);

                hotel.HotelName = HotelName;
                hotel.HotelPhone = HotelPhone;
                hotel.HotelZipCode = HotelZIP;
                hotelServices.UpdateHotel(hotel);
            }
            MessageBox.Show("Successfully Updated");
        }
    }
}
