using HostelReservation.Presentation.UserControls_Admin.UC_Room;
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
    public partial class RoomForm : Form
    {
        public RoomForm()
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
            UC_ViewRoom uC_ViewRoom = new UC_ViewRoom();
            addUserControl(uC_ViewRoom);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddRoom uC_AddRoom = new UC_AddRoom();
            addUserControl(uC_AddRoom);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UC_UpdateRoom uC_UpdateRoom = new UC_UpdateRoom();
            addUserControl(uC_UpdateRoom);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UC_DeleteRoom uC_DeleteRoom = new UC_DeleteRoom();
            addUserControl(uC_DeleteRoom);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
