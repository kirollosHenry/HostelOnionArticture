namespace HostelReservation.Presentation.UserControls_Admin.UC_Reservation
{
    partial class UC_DeleteReservation
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
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            ReservationIdtextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1268, 288);
            dataGridView1.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.GradientInactiveCaption;
            DeleteButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(1144, 57);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(178, 49);
            DeleteButton.TabIndex = 15;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReservationIdtextBox
            // 
            ReservationIdtextBox.Location = new Point(310, 65);
            ReservationIdtextBox.Multiline = true;
            ReservationIdtextBox.Name = "ReservationIdtextBox";
            ReservationIdtextBox.Size = new Size(125, 34);
            ReservationIdtextBox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 65);
            label1.Name = "label1";
            label1.Size = new Size(225, 34);
            label1.TabIndex = 13;
            label1.Text = "Reservation Id";
            // 
            // UC_DeleteReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(DeleteButton);
            Controls.Add(ReservationIdtextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UC_DeleteReservation";
            Size = new Size(1380, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button DeleteButton;
        private TextBox ReservationIdtextBox;
        private Label label1;
    }
}
