namespace HostelReservation.Presentation.UserControls_Admin.UC_Hotel
{
    partial class UC_AddHotel
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HNametextBox = new TextBox();
            HPhonetextBox = new TextBox();
            HZiptextBox = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 91);
            label1.Name = "label1";
            label1.Size = new Size(185, 34);
            label1.TabIndex = 0;
            label1.Text = "Hotel Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 202);
            label2.Name = "label2";
            label2.Size = new Size(195, 34);
            label2.TabIndex = 1;
            label2.Text = "Hotel Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 318);
            label3.Name = "label3";
            label3.Size = new Size(229, 34);
            label3.TabIndex = 2;
            label3.Text = "Hotel Zip Code";
            // 
            // HNametextBox
            // 
            HNametextBox.Location = new Point(328, 99);
            HNametextBox.Name = "HNametextBox";
            HNametextBox.Size = new Size(230, 27);
            HNametextBox.TabIndex = 3;
            // 
            // HPhonetextBox
            // 
            HPhonetextBox.Location = new Point(328, 209);
            HPhonetextBox.Name = "HPhonetextBox";
            HPhonetextBox.Size = new Size(230, 27);
            HPhonetextBox.TabIndex = 4;
            // 
            // HZiptextBox
            // 
            HZiptextBox.Location = new Point(328, 325);
            HZiptextBox.Name = "HZiptextBox";
            HZiptextBox.Size = new Size(230, 27);
            HZiptextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.GradientInactiveCaption;
            AddButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(1057, 289);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 88);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // UC_AddHotel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(AddButton);
            Controls.Add(HZiptextBox);
            Controls.Add(HPhonetextBox);
            Controls.Add(HNametextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddHotel";
            Size = new Size(1380, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox HNametextBox;
        private TextBox HPhonetextBox;
        private TextBox HZiptextBox;
        private Button AddButton;
    }
}
