namespace HostelReservation.Presentation.UserControls_Admin.UC_Room
{
    partial class UC_AddRoom
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
            AddButton = new Button();
            RStatustextBox = new TextBox();
            RNumtextBox = new TextBox();
            RRatestextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            HotelIDtextBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.GradientInactiveCaption;
            AddButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(1095, 293);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 88);
            AddButton.TabIndex = 13;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RStatustextBox
            // 
            RStatustextBox.Location = new Point(366, 299);
            RStatustextBox.Name = "RStatustextBox";
            RStatustextBox.Size = new Size(230, 27);
            RStatustextBox.TabIndex = 12;
            // 
            // RNumtextBox
            // 
            RNumtextBox.Location = new Point(366, 183);
            RNumtextBox.Name = "RNumtextBox";
            RNumtextBox.Size = new Size(230, 27);
            RNumtextBox.TabIndex = 11;
            // 
            // RRatestextBox
            // 
            RRatestextBox.Location = new Point(366, 73);
            RRatestextBox.Name = "RRatestextBox";
            RRatestextBox.Size = new Size(230, 27);
            RRatestextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 292);
            label3.Name = "label3";
            label3.Size = new Size(194, 34);
            label3.TabIndex = 9;
            label3.Text = "Room Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 176);
            label2.Name = "label2";
            label2.Size = new Size(252, 34);
            label2.TabIndex = 8;
            label2.Text = "Number Of Beds";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 65);
            label1.Name = "label1";
            label1.Size = new Size(185, 34);
            label1.TabIndex = 7;
            label1.Text = "Room Rates";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 419);
            label4.Name = "label4";
            label4.Size = new Size(145, 34);
            label4.TabIndex = 14;
            label4.Text = "Hotel ID";
            // 
            // HotelIDtextBox
            // 
            HotelIDtextBox.Location = new Point(366, 419);
            HotelIDtextBox.Name = "HotelIDtextBox";
            HotelIDtextBox.Size = new Size(230, 27);
            HotelIDtextBox.TabIndex = 15;
            // 
            // UC_AddRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(HotelIDtextBox);
            Controls.Add(label4);
            Controls.Add(AddButton);
            Controls.Add(RStatustextBox);
            Controls.Add(RNumtextBox);
            Controls.Add(RRatestextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddRoom";
            Size = new Size(1380, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox RStatustextBox;
        private TextBox RNumtextBox;
        private TextBox RRatestextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox HotelIDtextBox;
    }
}
