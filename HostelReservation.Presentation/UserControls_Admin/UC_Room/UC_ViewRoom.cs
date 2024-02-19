using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Applications.Services.RoomServices;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
using HostelReservation.Infrastructure.Repositories.RoomRepository;
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
    public partial class UC_ViewRoom : UserControl
    {
        RoomService roomService = new RoomService(new RoomRepository(new Context.HostelDbContext()));
        
        public UC_ViewRoom()
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
    }
}
