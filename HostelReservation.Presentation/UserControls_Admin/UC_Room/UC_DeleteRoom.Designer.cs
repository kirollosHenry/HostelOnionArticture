namespace HostelReservation.Presentation.UserControls_Admin.UC_Room
{
    partial class UC_DeleteRoom
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
            RoomIdtextBox = new TextBox();
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
            dataGridView1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.GradientInactiveCaption;
            DeleteButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(1147, 67);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(178, 49);
            DeleteButton.TabIndex = 12;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // RoomIdtextBox
            // 
            RoomIdtextBox.Location = new Point(218, 75);
            RoomIdtextBox.Multiline = true;
            RoomIdtextBox.Name = "RoomIdtextBox";
            RoomIdtextBox.Size = new Size(125, 34);
            RoomIdtextBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 75);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 10;
            label1.Text = "Room Id";
            // 
            // UC_DeleteRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(DeleteButton);
            Controls.Add(RoomIdtextBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "UC_DeleteRoom";
            Size = new Size(1380, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button DeleteButton;
        private TextBox RoomIdtextBox;
        private Label label1;
    }
}
