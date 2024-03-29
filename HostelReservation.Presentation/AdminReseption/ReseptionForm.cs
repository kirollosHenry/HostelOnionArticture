﻿using HostelReservation.Presentation.ResaptionForms;
using HostelReservation.Presentation.AdminReseption;
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
    public partial class ReseptionForm : Form
    {
        public ReseptionForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm form1_Login = new LoginForm();
            form1_Login.ShowDialog();
        }

        private void CheckInButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Resaption resaption = new Resaption();
            resaption.ShowDialog();
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CheckOutFrm ChOut = new CheckOutFrm();
            ChOut.ShowDialog();
        }

        private void ReseptionForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchIDButton_Click(object sender, EventArgs e)
        {

        }
    }
}
