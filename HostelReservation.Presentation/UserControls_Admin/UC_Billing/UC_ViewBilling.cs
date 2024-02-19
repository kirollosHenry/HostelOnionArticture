using HostelReservation.Applications.Services.Billing;
using HostelReservation.Applications.Services.HotelServices;
using HostelReservation.Infrastructure.Repositories.BillingReposatory;
using HostelReservation.Infrastructure.Repositories.HotelRepository;
using HostelReservation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelReservation.Presentation.UserControls_Admin.UC_Billing
{
    public partial class UC_ViewBilling : UserControl
    {
        BillingServices billingServices = new BillingServices(new BillingReposatory(new Context.HostelDbContext()));

        public UC_ViewBilling()
        {
            InitializeComponent();
            dataGridView1.DataSource = billingServices.GetAllBilling().ToList();
            dataGridView1.Columns[0].Width = 270;
            dataGridView1.Columns[1].Width = 270;
            dataGridView1.Columns[2].Width = 270;
            dataGridView1.Columns[3].Width = 270;
            dataGridView1.Columns[4].Width = 270;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10, FontStyle.Regular);
        }
    }
}
