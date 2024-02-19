using HostelReservation.Presentation.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelReservation.Presentation
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm form1_Login = new LoginForm();
            form1_Login.ShowDialog();
        }

        private void HotelButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HotelForm hotelForm = new HotelForm();
            hotelForm.ShowDialog();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RoomForm roomForm = new RoomForm();
            roomForm.ShowDialog();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.ShowDialog();
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BillingForm billingForm = new BillingForm();
            billingForm.ShowDialog();
        }

        private void ReseptionButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HostelReservation.Presentation.AdminForms.ReseptionForm reseptionForm = new HostelReservation.Presentation.AdminForms.ReseptionForm();
            reseptionForm.ShowDialog();
        }

        
    }
}
