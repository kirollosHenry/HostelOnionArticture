namespace HostelReservation.Presentation.UserControls_Admin.UC_Billing
{
    partial class UC_AddBilling
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
            customerIDDtextBox = new TextBox();
            label4 = new Label();
            AddButton = new Button();
            NumOfDaystextBox = new TextBox();
            DeposittextBox = new TextBox();
            PricetestextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // customerIDDtextBox
            // 
            customerIDDtextBox.Location = new Point(384, 398);
            customerIDDtextBox.Name = "customerIDDtextBox";
            customerIDDtextBox.Size = new Size(230, 27);
            customerIDDtextBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 398);
            label4.Name = "label4";
            label4.Size = new Size(196, 34);
            label4.TabIndex = 23;
            label4.Text = "Customer ID";
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.GradientInactiveCaption;
            AddButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(1113, 272);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 88);
            AddButton.TabIndex = 22;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // NumOfDaystextBox
            // 
            NumOfDaystextBox.Location = new Point(384, 278);
            NumOfDaystextBox.Name = "NumOfDaystextBox";
            NumOfDaystextBox.Size = new Size(230, 27);
            NumOfDaystextBox.TabIndex = 21;
            // 
            // DeposittextBox
            // 
            DeposittextBox.Location = new Point(384, 162);
            DeposittextBox.Name = "DeposittextBox";
            DeposittextBox.Size = new Size(230, 27);
            DeposittextBox.TabIndex = 20;
            // 
            // PricetestextBox
            // 
            PricetestextBox.Location = new Point(384, 52);
            PricetestextBox.Name = "PricetestextBox";
            PricetestextBox.Size = new Size(230, 27);
            PricetestextBox.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 272);
            label3.Name = "label3";
            label3.Size = new Size(253, 34);
            label3.TabIndex = 18;
            label3.Text = "Number Of Days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 155);
            label2.Name = "label2";
            label2.Size = new Size(123, 34);
            label2.TabIndex = 17;
            label2.Text = "Deposit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 44);
            label1.Name = "label1";
            label1.Size = new Size(91, 34);
            label1.TabIndex = 16;
            label1.Text = "Price";
            // 
            // UC_AddBilling
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(customerIDDtextBox);
            Controls.Add(label4);
            Controls.Add(AddButton);
            Controls.Add(NumOfDaystextBox);
            Controls.Add(DeposittextBox);
            Controls.Add(PricetestextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddBilling";
            Size = new Size(1380, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerIDDtextBox;
        private Label label4;
        private Button AddButton;
        private TextBox NumOfDaystextBox;
        private TextBox DeposittextBox;
        private TextBox PricetestextBox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
