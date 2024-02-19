using HostelReservation.Presentation.UserControls_Admin.UC_Reseption;
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
    public partial class ReseptionForm : Form
    {
        public ReseptionForm()
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
            UC_ViewReseption uC_ViewReseption = new UC_ViewReseption();
            addUserControl(uC_ViewReseption);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddReseption uC_AddReseption = new UC_AddReseption();
            addUserControl(uC_AddReseption);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UC_UpdateReseption uC_UpdateReseption = new UC_UpdateReseption();
            addUserControl(uC_UpdateReseption);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UC_DeleteReseption uC_DeleteReseption = new UC_DeleteReseption();
            addUserControl(uC_DeleteReseption);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
