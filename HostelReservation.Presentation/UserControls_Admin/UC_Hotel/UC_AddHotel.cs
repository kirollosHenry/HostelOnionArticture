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
    public partial class UC_AddHotel : UserControl
    {
        public UC_AddHotel()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (HNametextBox.Text != "" && HPhonetextBox.Text != "" && HZiptextBox.Text != "")
            {
                HotelServices hotelServices = new HotelServices(new HotelRepository(new Context.HostelDbContext()));
                Hotel hotel = new Hotel();
                hotel.HotelName = HNametextBox.Text;
                hotel.HotelPhone = HPhonetextBox.Text;
                hotel.HotelZipCode = int.Parse(HPhonetextBox.Text);
                hotelServices.CreateHotel(hotel);
                MessageBox.Show("Successfully Added");
                HNametextBox.Text = "";
                HPhonetextBox.Text = "";
                HZiptextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Valid Hotel Name and Hotle Phone and Hotel Zip");
            }
        }
    }
}
