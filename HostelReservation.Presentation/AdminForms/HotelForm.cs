using HostelReservation.Presentation.UserControls_Admin.UC_Hotel;
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
    public partial class HotelForm : Form
    {
        public HotelForm()
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
            UC_ViewHotel uC_ViewHotel = new UC_ViewHotel();
            addUserControl(uC_ViewHotel);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddHotel uC_AddHotel = new UC_AddHotel();
            addUserControl(uC_AddHotel);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UC_UpdateHotel uC_UpdateHotel = new UC_UpdateHotel();
            addUserControl(uC_UpdateHotel);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UC_DeleteHotel uC_DeleteHotel = new UC_DeleteHotel();
            addUserControl (uC_DeleteHotel);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
