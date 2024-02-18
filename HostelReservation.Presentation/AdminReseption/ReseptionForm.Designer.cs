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
            label1 = new Label();
            CheckInButton = new Button();
            CheckOutButton = new Button();
            BackButton = new Button();
            label2 = new Label();
            SeaarchIDtextBox = new TextBox();
            SeaarchNametextBox = new TextBox();
            label3 = new Label();
            SearchIDButton = new Button();
            SearchNamebutton = new Button();
            SuspendLayout();
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
            // CheckInButton
            // 
            CheckInButton.BackColor = SystemColors.GradientInactiveCaption;
            CheckInButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckInButton.Location = new Point(623, 341);
            CheckInButton.Name = "CheckInButton";
            CheckInButton.Size = new Size(182, 81);
            CheckInButton.TabIndex = 2;
            CheckInButton.Text = "Checkin";
            CheckInButton.UseVisualStyleBackColor = false;
            // 
            // CheckOutButton
            // 
            CheckOutButton.BackColor = SystemColors.GradientInactiveCaption;
            CheckOutButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckOutButton.Location = new Point(623, 467);
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
            BackButton.Location = new Point(24, 607);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(133, 47);
            BackButton.TabIndex = 8;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 154);
            label2.Name = "label2";
            label2.Size = new Size(110, 34);
            label2.TabIndex = 9;
            label2.Text = "Search";
            // 
            // SeaarchIDtextBox
            // 
            SeaarchIDtextBox.Location = new Point(140, 162);
            SeaarchIDtextBox.Multiline = true;
            SeaarchIDtextBox.Name = "SeaarchIDtextBox";
            SeaarchIDtextBox.Size = new Size(216, 27);
            SeaarchIDtextBox.TabIndex = 10;
            SeaarchIDtextBox.Text = "Customer ID";
            // 
            // SeaarchNametextBox
            // 
            SeaarchNametextBox.Location = new Point(140, 226);
            SeaarchNametextBox.Multiline = true;
            SeaarchNametextBox.Name = "SeaarchNametextBox";
            SeaarchNametextBox.Size = new Size(216, 27);
            SeaarchNametextBox.TabIndex = 12;
            SeaarchNametextBox.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 218);
            label3.Name = "label3";
            label3.Size = new Size(110, 34);
            label3.TabIndex = 11;
            label3.Text = "Search";
            // 
            // SearchIDButton
            // 
            SearchIDButton.BackColor = SystemColors.GradientInactiveCaption;
            SearchIDButton.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchIDButton.Location = new Point(385, 157);
            SearchIDButton.Name = "SearchIDButton";
            SearchIDButton.Size = new Size(114, 35);
            SearchIDButton.TabIndex = 13;
            SearchIDButton.Text = "Search";
            SearchIDButton.UseVisualStyleBackColor = false;
            // 
            // SearchNamebutton
            // 
            SearchNamebutton.BackColor = SystemColors.GradientInactiveCaption;
            SearchNamebutton.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchNamebutton.Location = new Point(385, 221);
            SearchNamebutton.Name = "SearchNamebutton";
            SearchNamebutton.Size = new Size(114, 35);
            SearchNamebutton.TabIndex = 14;
            SearchNamebutton.Text = "Search";
            SearchNamebutton.UseVisualStyleBackColor = false;
            // 
            // ReseptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1404, 666);
            Controls.Add(SearchNamebutton);
            Controls.Add(SearchIDButton);
            Controls.Add(SeaarchNametextBox);
            Controls.Add(label3);
            Controls.Add(SeaarchIDtextBox);
            Controls.Add(label2);
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

        private Label label1;
        private Button CheckInButton;
        private Button CheckOutButton;
        private Button BackButton;
        private Label label2;
        private TextBox SeaarchIDtextBox;
        private TextBox SeaarchNametextBox;
        private Label label3;
        private Button SearchIDButton;
        private Button SearchNamebutton;
    }
}