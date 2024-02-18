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
namespace HostelReservation.Presentation.ResaptionForms
{
    public partial class Resaption : Form
    {
        HotelServices hotel;
        public Resaption()
        {
            InitializeComponent();
            dataGridView1.DataSource = hotel.GetAllHotel();
        }

        private void Resaption_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hotel.GetAllHotel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
