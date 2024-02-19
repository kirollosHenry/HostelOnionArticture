namespace HostelReservation.Presentation.UserControls_Admin.UC_Customer
{
    partial class UC_AddCustomer
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
            CPhonetextBox = new TextBox();
            CCitytextBox = new TextBox();
            CNametextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            // CPhonetextBox
            // 
            CPhonetextBox.Location = new Point(366, 329);
            CPhonetextBox.Name = "CPhonetextBox";
            CPhonetextBox.Size = new Size(230, 27);
            CPhonetextBox.TabIndex = 12;
            // 
            // CCitytextBox
            // 
            CCitytextBox.Location = new Point(366, 213);
            CCitytextBox.Name = "CCitytextBox";
            CCitytextBox.Size = new Size(230, 27);
            CCitytextBox.TabIndex = 11;
            // 
            // CNametextBox
            // 
            CNametextBox.Location = new Point(366, 103);
            CNametextBox.Name = "CNametextBox";
            CNametextBox.Size = new Size(230, 27);
            CNametextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 322);
            label3.Name = "label3";
            label3.Size = new Size(246, 34);
            label3.TabIndex = 9;
            label3.Text = "Customer Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 206);
            label2.Name = "label2";
            label2.Size = new Size(214, 34);
            label2.TabIndex = 8;
            label2.Text = "Customer City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 95);
            label1.Name = "label1";
            label1.Size = new Size(236, 34);
            label1.TabIndex = 7;
            label1.Text = "Customer Name";
            // 
            // UC_AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(AddButton);
            Controls.Add(CPhonetextBox);
            Controls.Add(CCitytextBox);
            Controls.Add(CNametextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddCustomer";
            Size = new Size(1380, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox CPhonetextBox;
        private TextBox CCitytextBox;
        private TextBox CNametextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
