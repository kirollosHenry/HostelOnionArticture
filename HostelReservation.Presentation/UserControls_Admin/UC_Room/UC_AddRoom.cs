using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
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

namespace HostelReservation.Presentation.UserControls_Admin.UC_Room
{
    public partial class UC_AddRoom : UserControl
    {
        HotelServices hotelServices = new HotelServices(new HotelRepository(new Context.HostelDbContext()));
        RoomService roomService = new RoomService(new RoomRepository(new Context.HostelDbContext()));
        Hotel hotel = new Hotel();  
        Room room = new Room();
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (RRatestextBox.Text != "" && RNumtextBox.Text != "" && RStatustextBox.Text != "" && HotelIDtextBox.Text != "")
            {
                int HotelID = int.Parse(HotelIDtextBox.Text);

                hotel = hotelServices.GetHotelByID(HotelID);
                if (hotel != null)
                {
                   
                    room.RoomRates = int.Parse(RRatestextBox.Text);
                    room.RoomNumberBeds = int.Parse(RNumtextBox.Text);
                    room.RoomStatus = char.Parse(RStatustextBox.Text);
                    room.HotelID = HotelID;
                    roomService.CreateRoom(room);
                    MessageBox.Show("Successfully Added");
                    RRatestextBox.Text = "";
                    RNumtextBox.Text = "";
                    RStatustextBox.Text = "";
                    HotelIDtextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Not Found Hotel");
                    RRatestextBox.Text = "";
                    RNumtextBox.Text = "";
                    RStatustextBox.Text = "";
                    HotelIDtextBox.Text = "";
                    return;
                }
            }
        }
    }
}
