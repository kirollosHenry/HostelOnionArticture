namespace HostelReservation.Presentation.UserControls_Admin.UC_Reseption
{
    partial class UC_UpdateReseption
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
            UpdateButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.GradientInactiveCaption;
            UpdateButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(1144, 57);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(178, 49);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1268, 288);
            dataGridView1.TabIndex = 14;
            // 
            // UC_UpdateReseption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView1);
            Name = "UC_UpdateReseption";
            Size = new Size(1380, 476);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button UpdateButton;
        private DataGridView dataGridView1;
    }
}
