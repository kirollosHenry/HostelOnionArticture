using HostelReservation.Presentation.UserControls_Admin.UC_Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelReservation.Presentation.AdminForms
{
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            UC_ViewReservation uC_ViewReservation = new UC_ViewReservation();
            addUserControl(uC_ViewReservation);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddReservation uC_AddReservation = new UC_AddReservation();
            addUserControl(uC_AddReservation);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UC_UpdateReservation uC_UpdateReservation = new UC_UpdateReservation();
            addUserControl(uC_UpdateReservation);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UC_DeleteReservation uC_DeleteReservation = new UC_DeleteReservation();
            addUserControl(uC_DeleteReservation);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
