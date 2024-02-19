using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Context;
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

namespace HostelReservation.Presentation.AdminReseption
{
    public partial class CheckOutFrm : Form
    {
        public CheckOutFrm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender , EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // function (get data using name (name) searchtxt.text)
                HotelServices hotelService = new HotelServices(new HotelRepository(new HostelDbContext()));

                dataGridView1.DataSource = hotelService.GetAllHotel();
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
            }
            if (radioButton2.Checked)
            {
                // function (get data using id  (id) serchtxt.text)
                HotelServices hotelService = new HotelServices(new HotelRepository(new HostelDbContext()));

                dataGridView1.DataSource = hotelService.GetAllHotel();
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
            }

        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
          this.Hide();
          ReseptionForm reseptionForm = new ReseptionForm();
          reseptionForm.ShowDialog();
        }

        private void CheckOutFrm_Load(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchtxt.PlaceholderText = "Customer Name";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchtxt.PlaceholderText = "Customer ID";
        }
    }
}
