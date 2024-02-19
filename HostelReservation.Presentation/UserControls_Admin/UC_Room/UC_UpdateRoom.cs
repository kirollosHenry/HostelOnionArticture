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
    public partial class UC_UpdateRoom : UserControl
    {
        HotelServices hotelServices = new HotelServices(new HotelRepository(new Context.HostelDbContext()));
        RoomService roomService = new RoomService(new RoomRepository(new Context.HostelDbContext()));

        public UC_UpdateRoom()
        {
            InitializeComponent();
            dataGridView1.DataSource = roomService.GetAllRooms().ToList();
            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].Width = 270;
            dataGridView1.Columns[2].Width = 270;
            dataGridView1.Columns[3].Width = 270;
            dataGridView1.Columns[4].Width = 270;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Room room = new Room();
                Hotel hotel = new Hotel();  
                int RoomID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()!);
                int RoomRates = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()!);
                int RoomNumberBeds = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()!);
                char RoomStatus = char.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()!);
                int HotelID = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()!);

                hotel = hotelServices.GetHotelByID(HotelID);
                if( hotel != null )
                {
                    room = roomService.GetRoomByID(RoomID);

                    room.RoomRates = RoomRates;
                    room.RoomNumberBeds = RoomNumberBeds;
                    room.RoomStatus = RoomStatus;
                    room.HotelID = HotelID;
                    roomService.UpdateRoom(room);
                }
                else
                {
                    MessageBox.Show("Not Found Hotel");
                    return;
                }
            }
            MessageBox.Show("Successfully Updated");
        }
    }
}
