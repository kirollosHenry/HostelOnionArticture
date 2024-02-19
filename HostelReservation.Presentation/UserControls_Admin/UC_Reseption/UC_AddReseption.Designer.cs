namespace HostelReservation.Presentation.UserControls_Admin.UC_Reseption
{
    partial class UC_AddReseption
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
            PasstextBox = new TextBox();
            UsertextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.GradientInactiveCaption;
            AddButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(1061, 199);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 88);
            AddButton.TabIndex = 13;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // PasstextBox
            // 
            PasstextBox.Location = new Point(338, 289);
            PasstextBox.Name = "PasstextBox";
            PasstextBox.Size = new Size(230, 27);
            PasstextBox.TabIndex = 11;
            // 
            // UsertextBox
            // 
            UsertextBox.Location = new Point(338, 179);
            UsertextBox.Name = "UsertextBox";
            UsertextBox.Size = new Size(230, 27);
            UsertextBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 282);
            label2.Name = "label2";
            label2.Size = new Size(169, 34);
            label2.TabIndex = 8;
            label2.Text = " Password ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 171);
            label1.Name = "label1";
            label1.Size = new Size(170, 34);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            // 
            // UC_AddReseption
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(AddButton);
            Controls.Add(PasstextBox);
            Controls.Add(UsertextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_AddReseption";
            Size = new Size(1380, 476);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private TextBox PasstextBox;
        private TextBox UsertextBox;
        private Label label2;
        private Label label1;
    }
}
