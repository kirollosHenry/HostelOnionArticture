using HostelReservation.Presentation.UserControls_Admin.UC_Customer;
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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
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
            UC_ViewCustomer uC_ViewCustomer = new UC_ViewCustomer();        
            addUserControl(uC_ViewCustomer);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddCustomer uC_AddCustomer = new UC_AddCustomer();   
            addUserControl(uC_AddCustomer);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UC_UpdateCustomer uC_UpdateCustomer = new UC_UpdateCustomer();
            addUserControl(uC_UpdateCustomer);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            UC_DeleteCustomercs uC_DeleteCustomercs = new UC_DeleteCustomercs();
            addUserControl(uC_DeleteCustomercs);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
