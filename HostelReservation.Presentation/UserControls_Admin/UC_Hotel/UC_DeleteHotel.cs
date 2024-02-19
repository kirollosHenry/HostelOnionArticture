using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
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
    public partial class UC_DeleteHotel : UserControl
    {
        HotelServices hotelServices = new HotelServices(new HotelRepository(new Context.HostelDbContext()));

        public UC_DeleteHotel()
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int HotelID = int.Parse(textBox1.Text);
                hotelServices.DeleteHotel(HotelID);
                MessageBox.Show("Successfully Deleted");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter Id to Delete");
            }
        }
    }
}
