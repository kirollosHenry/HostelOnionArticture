﻿namespace HostelReservation.Presentation.AdminForms
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
            BackButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panelCRUD = new Panel();
            DeleteButton = new Button();
            UpdateButton = new Button();
            AddButton = new Button();
            ViewButton = new Button();
            panelCRUD.SuspendLayout();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.GradientInactiveCaption;
            BackButton.Font = new Font("Wide Latin", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(1, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(147, 42);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 186);
            panel1.Name = "panel1";
            panel1.Size = new Size(1380, 476);
            panel1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(523, 15);
            label1.Name = "label1";
            label1.Size = new Size(352, 71);
            label1.TabIndex = 17;
            label1.Text = "Reseption";
            // 
            // panelCRUD
            // 
            panelCRUD.Controls.Add(DeleteButton);
            panelCRUD.Controls.Add(UpdateButton);
            panelCRUD.Controls.Add(AddButton);
            panelCRUD.Controls.Add(ViewButton);
            panelCRUD.Location = new Point(12, 86);
            panelCRUD.Name = "panelCRUD";
            panelCRUD.Size = new Size(1380, 94);
            panelCRUD.TabIndex = 16;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = SystemColors.GradientInactiveCaption;
            DeleteButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(1110, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(193, 88);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = SystemColors.GradientInactiveCaption;
            UpdateButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateButton.Location = new Point(784, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(193, 88);
            UpdateButton.TabIndex = 4;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.GradientInactiveCaption;
            AddButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(396, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 88);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.BackColor = SystemColors.GradientInactiveCaption;
            ViewButton.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewButton.Location = new Point(83, 3);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(193, 88);
            ViewButton.TabIndex = 2;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = false;
            ViewButton.Click += ViewButton_Click;
            // 
            // ReseptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1404, 666);
            Controls.Add(BackButton);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panelCRUD);
            Name = "ReseptionForm";
            Text = "ReseptionForm";
            panelCRUD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Panel panel1;
        private Label label1;
        private Panel panelCRUD;
        private Button DeleteButton;
        private Button UpdateButton;
        private Button AddButton;
        private Button ViewButton;
    }
}