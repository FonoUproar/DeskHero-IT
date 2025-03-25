namespace IT488_DeskHeroIT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button_CurrentTicketsSearch = new System.Windows.Forms.Button();
            this.CurrentTickets_SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_ViewEdit = new System.Windows.Forms.Button();
            this.Button_NewTicket = new System.Windows.Forms.Button();
            this.CurrentTickets_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CompletedTickets_SearchTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CompletedTickets_ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_ViewCompleted = new System.Windows.Forms.Button();
            this.CompletedTickets_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DeskHero IT Dashboard";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button_CurrentTicketsSearch);
            this.groupBox2.Controls.Add(this.CurrentTickets_SearchTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Button_ViewEdit);
            this.groupBox2.Controls.Add(this.Button_NewTicket);
            this.groupBox2.Controls.Add(this.CurrentTickets_RichTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Tickets";
            // 
            // Button_CurrentTicketsSearch
            // 
            this.Button_CurrentTicketsSearch.Location = new System.Drawing.Point(234, 90);
            this.Button_CurrentTicketsSearch.Name = "Button_CurrentTicketsSearch";
            this.Button_CurrentTicketsSearch.Size = new System.Drawing.Size(75, 23);
            this.Button_CurrentTicketsSearch.TabIndex = 10;
            this.Button_CurrentTicketsSearch.Text = "Search";
            this.Button_CurrentTicketsSearch.UseVisualStyleBackColor = true;
            // 
            // CurrentTickets_SearchTextBox
            // 
            this.CurrentTickets_SearchTextBox.Location = new System.Drawing.Point(108, 40);
            this.CurrentTickets_SearchTextBox.Name = "CurrentTickets_SearchTextBox";
            this.CurrentTickets_SearchTextBox.Size = new System.Drawing.Size(201, 20);
            this.CurrentTickets_SearchTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Ticket";
            // 
            // Button_ViewEdit
            // 
            this.Button_ViewEdit.Location = new System.Drawing.Point(240, 250);
            this.Button_ViewEdit.Name = "Button_ViewEdit";
            this.Button_ViewEdit.Size = new System.Drawing.Size(75, 23);
            this.Button_ViewEdit.TabIndex = 3;
            this.Button_ViewEdit.Text = "View/Edit Ticket";
            this.Button_ViewEdit.UseVisualStyleBackColor = true;
            // 
            // Button_NewTicket
            // 
            this.Button_NewTicket.Location = new System.Drawing.Point(0, 250);
            this.Button_NewTicket.Name = "Button_NewTicket";
            this.Button_NewTicket.Size = new System.Drawing.Size(75, 23);
            this.Button_NewTicket.TabIndex = 2;
            this.Button_NewTicket.Text = "New Ticket";
            this.Button_NewTicket.UseVisualStyleBackColor = true;
            // 
            // CurrentTickets_RichTextBox
            // 
            this.CurrentTickets_RichTextBox.Location = new System.Drawing.Point(6, 119);
            this.CurrentTickets_RichTextBox.Name = "CurrentTickets_RichTextBox";
            this.CurrentTickets_RichTextBox.Size = new System.Drawing.Size(303, 105);
            this.CurrentTickets_RichTextBox.TabIndex = 1;
            this.CurrentTickets_RichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current Tickets Open";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.CompletedTickets_SearchTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CompletedTickets_ComboBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Button_ViewCompleted);
            this.groupBox3.Controls.Add(this.CompletedTickets_RichTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(360, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 284);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CompletedTickets_SearchTextBox
            // 
            this.CompletedTickets_SearchTextBox.Location = new System.Drawing.Point(271, 32);
            this.CompletedTickets_SearchTextBox.Name = "CompletedTickets_SearchTextBox";
            this.CompletedTickets_SearchTextBox.Size = new System.Drawing.Size(121, 20);
            this.CompletedTickets_SearchTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Search Ticket";
            // 
            // CompletedTickets_ComboBox
            // 
            this.CompletedTickets_ComboBox.FormattingEnabled = true;
            this.CompletedTickets_ComboBox.Items.AddRange(new object[] {
            "Urgent",
            "Medium ",
            "Low"});
            this.CompletedTickets_ComboBox.Location = new System.Drawing.Point(59, 32);
            this.CompletedTickets_ComboBox.Name = "CompletedTickets_ComboBox";
            this.CompletedTickets_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.CompletedTickets_ComboBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Priority";
            // 
            // Button_ViewCompleted
            // 
            this.Button_ViewCompleted.Location = new System.Drawing.Point(18, 89);
            this.Button_ViewCompleted.Name = "Button_ViewCompleted";
            this.Button_ViewCompleted.Size = new System.Drawing.Size(75, 23);
            this.Button_ViewCompleted.TabIndex = 2;
            this.Button_ViewCompleted.Text = "View";
            this.Button_ViewCompleted.UseVisualStyleBackColor = true;
            // 
            // CompletedTickets_RichTextBox
            // 
            this.CompletedTickets_RichTextBox.Location = new System.Drawing.Point(6, 118);
            this.CompletedTickets_RichTextBox.Name = "CompletedTickets_RichTextBox";
            this.CompletedTickets_RichTextBox.Size = new System.Drawing.Size(391, 160);
            this.CompletedTickets_RichTextBox.TabIndex = 1;
            this.CompletedTickets_RichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Completed Tickets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form4";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button_ViewEdit;
        private System.Windows.Forms.Button Button_NewTicket;
        private System.Windows.Forms.RichTextBox CurrentTickets_RichTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_ViewCompleted;
        private System.Windows.Forms.RichTextBox CompletedTickets_RichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CompletedTickets_SearchTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CompletedTickets_ComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button_CurrentTicketsSearch;
        private System.Windows.Forms.TextBox CurrentTickets_SearchTextBox;
        private System.Windows.Forms.Label label2;
    }
}