namespace HostelReservation.Presentation.AdminReseption
{
    partial class CheckOutFrm
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            searchtxt = new TextBox();
            SearchBtn = new Button();
            ReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 157);
            label2.Name = "label2";
            label2.Size = new Size(181, 34);
            label2.TabIndex = 16;
            label2.Text = "Search by : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(540, 24);
            label1.Name = "label1";
            label1.Size = new Size(354, 71);
            label1.TabIndex = 15;
            label1.Text = "CHECK OUT";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1380, 351);
            dataGridView1.TabIndex = 22;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(291, 162);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(190, 29);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Customer Name";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(524, 162);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(162, 29);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Customer ID";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(46, 207);
            searchtxt.Multiline = true;
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(435, 41);
            searchtxt.TabIndex = 17;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.GradientInactiveCaption;
            SearchBtn.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(524, 202);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(162, 46);
            SearchBtn.TabIndex = 20;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.GradientInactiveCaption;
            ReturnBtn.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnBtn.Location = new Point(1230, 202);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(162, 46);
            ReturnBtn.TabIndex = 25;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += this.ReturnBtn_Click;
            // 
            // CheckOutFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1404, 666);
            Controls.Add(ReturnBtn);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBtn);
            Controls.Add(searchtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CheckOutFrm";
            Text = "Check Out";
            Load += CheckOutFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox searchtxt;
        private Button SearchBtn;
        private Button ReturnBtn;
    }
}