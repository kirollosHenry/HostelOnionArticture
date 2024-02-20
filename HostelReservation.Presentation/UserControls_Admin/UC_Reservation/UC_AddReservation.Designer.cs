namespace HostelReservation.Presentation.UserControls_Admin.UC_Reservation
{
    partial class UC_AddReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BillingIDtextBox = new TextBox();
            label4 = new Label();
            RoomIDtextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            CustomerIdtextBox = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // BillingIDtextBox
            // 
            BillingIDtextBox.Location = new Point(381, 345);
            BillingIDtextBox.Name = "BillingIDtextBox";
            BillingIDtextBox.Size = new Size(230, 27);
            BillingIDtextBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 345);
            label4.Name = "label4";
            label4.Size = new Size(170, 34);
            label4.TabIndex = 22;
            label4.Text = "Billing ID";
            // 
            // RoomIDtextBox
            // 
            RoomIDtextBox.Location = new Point(381, 241);
            RoomIDtextBox.Name = "RoomIDtextBox";
            RoomIDtextBox.Size = new Size(230, 27);
            RoomIDtextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 241);
            label3.Name = "label3";
            label3.Size = new Size(147, 34);
            label3.TabIndex = 18;
            label3.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(328, 34);
            label2.TabIndex = 17;
            label2.Text = "Reservation CheckOut";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 44);
            label1.Name = "label1";
            label1.Size = new Size(321, 34);
            label1.TabIndex = 16;
            label1.Text = " Reservation CheckIn";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(381, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(381, 153);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(794, 51);
            label5.Name = "label5";
            label5.Size = new Size(196, 34);
            label5.TabIndex = 26;
            label5.Text = "Customer ID";
            // 
            // CustomerIdtextBox
            // 
            CustomerIdtextBox.Location = new Point(1038, 53);
            CustomerIdtextBox.Name = "CustomerIdtextBox";
            CustomerIdtextBox.Size = new Size(230, 27);
            CustomerIdtextBox.TabIndex = 27;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.GradientInactiveCaption;
            AddButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(1075, 309);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 88);
            AddButton.TabIndex = 28;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // UC_AddReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(AddButton);
            Controls.Add(CustomerIdtextBox);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(BillingIDtextBox);
            Controls.Add(label4);
            Controls.Add(RoomIDtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddReservation";
            Size = new Size(1380, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BillingIDtextBox;
        private Label label4;
        private TextBox RoomIDtextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private TextBox CustomerIdtextBox;
        private Button AddButton;
    }
}
