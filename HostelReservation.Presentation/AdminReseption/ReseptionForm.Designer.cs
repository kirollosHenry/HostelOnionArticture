namespace HostelReservation.Presentation
{
    partial class ReseptionForm
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
            CheckInButton = new Button();
            CheckOutButton = new Button();
            BackButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // CheckInButton
            // 
            CheckInButton.BackColor = SystemColors.GradientInactiveCaption;
            CheckInButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInButton.Location = new Point(623, 235);
            CheckInButton.Name = "CheckInButton";
            CheckInButton.Size = new Size(182, 81);
            CheckInButton.TabIndex = 2;
            CheckInButton.Text = "Checkin";
            CheckInButton.UseVisualStyleBackColor = false;
            CheckInButton.Click += CheckInButton_Click;
            // 
            // CheckOutButton
            // 
            CheckOutButton.BackColor = SystemColors.GradientInactiveCaption;
            CheckOutButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutButton.Location = new Point(623, 413);
            CheckOutButton.Name = "CheckOutButton";
            CheckOutButton.Size = new Size(182, 81);
            CheckOutButton.TabIndex = 3;
            CheckOutButton.Text = "Checkout";
            CheckOutButton.UseVisualStyleBackColor = false;
            CheckOutButton.Click += CheckOutButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.GradientInactiveCaption;
            BackButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(38, 587);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(133, 47);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 21);
            label1.Name = "label1";
            label1.Size = new Size(614, 71);
            label1.TabIndex = 1;
            label1.Text = "Welcome Resepton\r\n";
            // 
            // ReseptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1404, 666);
            Controls.Add(BackButton);
            Controls.Add(CheckOutButton);
            Controls.Add(CheckInButton);
            Controls.Add(label1);
            Name = "ReseptionForm";
            Text = "ReseptionForm";
            Load += ReseptionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CheckInButton;
        private Button CheckOutButton;
        private Button BackButton;
        private Label label1;
    }
}