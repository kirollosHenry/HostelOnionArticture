using HostelReservation.Presentation.UserControls_Admin.UC_Billing;
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
    public partial class BillingForm : Form
    {
        public BillingForm()
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
            UC_ViewBilling uC_ViewBilling = new UC_ViewBilling();
            addUserControl(uC_ViewBilling);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddBilling uC_AddBilling = new UC_AddBilling();
            addUserControl(uC_AddBilling);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UC_UpdateBilling uC_UpdateBilling = new UC_UpdateBilling();
            addUserControl(uC_UpdateBilling);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UC_DeleteBilling uC_DeleteBilling = new UC_DeleteBilling();
            addUserControl(uC_DeleteBilling);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
