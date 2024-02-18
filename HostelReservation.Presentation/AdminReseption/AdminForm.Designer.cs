namespace HostelReservation.Presentation
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            HotelButton = new Button();
            RoomButton = new Button();
            CustomerButton = new Button();
            ReservationButton = new Button();
            BillingButton = new Button();
            BackButton = new Button();
            ReseptionButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 25);
            label1.Name = "label1";
            label1.Size = new Size(503, 71);
            label1.TabIndex = 0;
            label1.Text = "Welcome Admin";
            // 
            // HotelButton
            // 
            HotelButton.BackColor = SystemColors.GradientInactiveCaption;
            HotelButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HotelButton.Location = new Point(589, 130);
            HotelButton.Name = "HotelButton";
            HotelButton.Size = new Size(182, 81);
            HotelButton.TabIndex = 1;
            HotelButton.Text = "Hotel";
            HotelButton.UseVisualStyleBackColor = false;
            HotelButton.Click += HotelButton_Click;
            // 
            // RoomButton
            // 
            RoomButton.BackColor = SystemColors.GradientInactiveCaption;
            RoomButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomButton.Location = new Point(589, 237);
            RoomButton.Name = "RoomButton";
            RoomButton.Size = new Size(182, 81);
            RoomButton.TabIndex = 2;
            RoomButton.Text = "Room";
            RoomButton.UseVisualStyleBackColor = false;
            RoomButton.Click += RoomButton_Click;
            // 
            // CustomerButton
            // 
            CustomerButton.BackColor = SystemColors.GradientInactiveCaption;
            CustomerButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerButton.Location = new Point(589, 348);
            CustomerButton.Name = "CustomerButton";
            CustomerButton.Size = new Size(182, 81);
            CustomerButton.TabIndex = 3;
            CustomerButton.Text = "Customer";
            CustomerButton.UseVisualStyleBackColor = false;
            CustomerButton.Click += CustomerButton_Click;
            // 
            // ReservationButton
            // 
            ReservationButton.BackColor = SystemColors.GradientInactiveCaption;
            ReservationButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReservationButton.Location = new Point(589, 453);
            ReservationButton.Name = "ReservationButton";
            ReservationButton.Size = new Size(182, 81);
            ReservationButton.TabIndex = 4;
            ReservationButton.Text = "Reservation";
            ReservationButton.UseVisualStyleBackColor = false;
            // 
            // BillingButton
            // 
            BillingButton.BackColor = SystemColors.GradientInactiveCaption;
            BillingButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BillingButton.Location = new Point(589, 562);
            BillingButton.Name = "BillingButton";
            BillingButton.Size = new Size(182, 81);
            BillingButton.TabIndex = 5;
            BillingButton.Text = "Billing";
            BillingButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.GradientInactiveCaption;
            BackButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(30, 607);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(133, 47);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // ReseptionButton
            // 
            ReseptionButton.BackColor = SystemColors.GradientInactiveCaption;
            ReseptionButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReseptionButton.Location = new Point(1186, 562);
            ReseptionButton.Name = "ReseptionButton";
            ReseptionButton.Size = new Size(182, 81);
            ReseptionButton.TabIndex = 8;
            ReseptionButton.Text = "Reseption";
            ReseptionButton.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1404, 666);
            Controls.Add(ReseptionButton);
            Controls.Add(BackButton);
            Controls.Add(BillingButton);
            Controls.Add(ReservationButton);
            Controls.Add(CustomerButton);
            Controls.Add(RoomButton);
            Controls.Add(HotelButton);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button HotelButton;
        private Button RoomButton;
        private Button CustomerButton;
        private Button ReservationButton;
        private Button BillingButton;
        //private PictureBox pictureBox1;
        private Button BackButton;
        private Button ReseptionButton;
    }
}