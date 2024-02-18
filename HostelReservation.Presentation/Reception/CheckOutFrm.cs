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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // search using name
            }
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
