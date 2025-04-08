namespace IT488_DeskHeroIT
{
    partial class DashboardForm
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
            this.openTicketsGroupBox = new System.Windows.Forms.GroupBox();
            this.openTicketsListBox = new System.Windows.Forms.ListBox();
            this.openTicketsComboBox = new System.Windows.Forms.ComboBox();
            this.openTicketsPriorityLabel = new System.Windows.Forms.Label();
            this.openTicketsSearchButton = new System.Windows.Forms.Button();
            this.openTicketsSearchTextBox = new System.Windows.Forms.TextBox();
            this.openTicketsSearchLabel = new System.Windows.Forms.Label();
            this.openTicketsNewTicketButton = new System.Windows.Forms.Button();
            this.openTicketsEditSelectedButton = new System.Windows.Forms.Button();
            this.closedTicketsGroupBox = new System.Windows.Forms.GroupBox();
            this.closedTicketsListBox = new System.Windows.Forms.ListBox();
            this.closedTicketsPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.closedTicketsPriorityLabel = new System.Windows.Forms.Label();
            this.closedTicketsSearchButton = new System.Windows.Forms.Button();
            this.closedTicketsSearchComboBox = new System.Windows.Forms.TextBox();
            this.closedTicketsSearchLabel = new System.Windows.Forms.Label();
            this.closedTicketsEditSelectedButton = new System.Windows.Forms.Button();
            this.managePersonelButton = new System.Windows.Forms.Button();
            this.openTicketsGroupBox.SuspendLayout();
            this.closedTicketsGroupBox.SuspendLayout();
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
            // openTicketsGroupBox
            // 
            this.openTicketsGroupBox.Controls.Add(this.openTicketsListBox);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsComboBox);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsPriorityLabel);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsSearchButton);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsSearchTextBox);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsSearchLabel);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsNewTicketButton);
            this.openTicketsGroupBox.Controls.Add(this.openTicketsEditSelectedButton);
            this.openTicketsGroupBox.Location = new System.Drawing.Point(12, 37);
            this.openTicketsGroupBox.Name = "openTicketsGroupBox";
            this.openTicketsGroupBox.Size = new System.Drawing.Size(358, 387);
            this.openTicketsGroupBox.TabIndex = 2;
            this.openTicketsGroupBox.TabStop = false;
            this.openTicketsGroupBox.Text = "Open Tickets";
            // 
            // openTicketsListBox
            // 
            this.openTicketsListBox.FormattingEnabled = true;
            this.openTicketsListBox.Location = new System.Drawing.Point(18, 59);
            this.openTicketsListBox.Name = "openTicketsListBox";
            this.openTicketsListBox.Size = new System.Drawing.Size(322, 290);
            this.openTicketsListBox.TabIndex = 12;
            // 
            // openTicketsComboBox
            // 
            this.openTicketsComboBox.FormattingEnabled = true;
            this.openTicketsComboBox.Items.AddRange(new object[] {
            "Urgent",
            "Medium ",
            "Low"});
            this.openTicketsComboBox.Location = new System.Drawing.Point(18, 32);
            this.openTicketsComboBox.Name = "openTicketsComboBox";
            this.openTicketsComboBox.Size = new System.Drawing.Size(119, 21);
            this.openTicketsComboBox.TabIndex = 11;
            // 
            // openTicketsPriorityLabel
            // 
            this.openTicketsPriorityLabel.AutoSize = true;
            this.openTicketsPriorityLabel.Location = new System.Drawing.Point(15, 16);
            this.openTicketsPriorityLabel.Name = "openTicketsPriorityLabel";
            this.openTicketsPriorityLabel.Size = new System.Drawing.Size(38, 13);
            this.openTicketsPriorityLabel.TabIndex = 10;
            this.openTicketsPriorityLabel.Text = "Priority";
            // 
            // openTicketsSearchButton
            // 
            this.openTicketsSearchButton.Location = new System.Drawing.Point(286, 30);
            this.openTicketsSearchButton.Name = "openTicketsSearchButton";
            this.openTicketsSearchButton.Size = new System.Drawing.Size(54, 23);
            this.openTicketsSearchButton.TabIndex = 10;
            this.openTicketsSearchButton.Text = "Search";
            this.openTicketsSearchButton.UseVisualStyleBackColor = true;
            // 
            // openTicketsSearchTextBox
            // 
            this.openTicketsSearchTextBox.Location = new System.Drawing.Point(143, 32);
            this.openTicketsSearchTextBox.Name = "openTicketsSearchTextBox";
            this.openTicketsSearchTextBox.Size = new System.Drawing.Size(137, 20);
            this.openTicketsSearchTextBox.TabIndex = 9;
            // 
            // openTicketsSearchLabel
            // 
            this.openTicketsSearchLabel.AutoSize = true;
            this.openTicketsSearchLabel.Location = new System.Drawing.Point(140, 16);
            this.openTicketsSearchLabel.Name = "openTicketsSearchLabel";
            this.openTicketsSearchLabel.Size = new System.Drawing.Size(74, 13);
            this.openTicketsSearchLabel.TabIndex = 6;
            this.openTicketsSearchLabel.Text = "Search Ticket";
            this.openTicketsSearchLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // openTicketsNewTicketButton
            // 
            this.openTicketsNewTicketButton.Location = new System.Drawing.Point(15, 358);
            this.openTicketsNewTicketButton.Name = "openTicketsNewTicketButton";
            this.openTicketsNewTicketButton.Size = new System.Drawing.Size(88, 23);
            this.openTicketsNewTicketButton.TabIndex = 2;
            this.openTicketsNewTicketButton.Text = "New Ticket";
            this.openTicketsNewTicketButton.UseVisualStyleBackColor = true;
            this.openTicketsNewTicketButton.Click += new System.EventHandler(this.openTicketsNewTicketButton_Click);
            // 
            // openTicketsEditSelectedButton
            // 
            this.openTicketsEditSelectedButton.Location = new System.Drawing.Point(252, 358);
            this.openTicketsEditSelectedButton.Name = "openTicketsEditSelectedButton";
            this.openTicketsEditSelectedButton.Size = new System.Drawing.Size(88, 23);
            this.openTicketsEditSelectedButton.TabIndex = 3;
            this.openTicketsEditSelectedButton.Text = "Edit Selected";
            this.openTicketsEditSelectedButton.UseVisualStyleBackColor = true;
            this.openTicketsEditSelectedButton.Click += new System.EventHandler(this.openTicketsEditSelectedButton_Click);
            // 
            // closedTicketsGroupBox
            // 
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsListBox);
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsPriorityComboBox);
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsPriorityLabel);
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsSearchButton);
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsSearchComboBox);
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsSearchLabel);
            this.closedTicketsGroupBox.Controls.Add(this.closedTicketsEditSelectedButton);
            this.closedTicketsGroupBox.Location = new System.Drawing.Point(419, 37);
            this.closedTicketsGroupBox.Name = "closedTicketsGroupBox";
            this.closedTicketsGroupBox.Size = new System.Drawing.Size(358, 387);
            this.closedTicketsGroupBox.TabIndex = 13;
            this.closedTicketsGroupBox.TabStop = false;
            this.closedTicketsGroupBox.Text = "Closed Tickets";
            // 
            // closedTicketsListBox
            // 
            this.closedTicketsListBox.FormattingEnabled = true;
            this.closedTicketsListBox.Location = new System.Drawing.Point(20, 59);
            this.closedTicketsListBox.Name = "closedTicketsListBox";
            this.closedTicketsListBox.Size = new System.Drawing.Size(322, 290);
            this.closedTicketsListBox.TabIndex = 13;
            // 
            // closedTicketsPriorityComboBox
            // 
            this.closedTicketsPriorityComboBox.FormattingEnabled = true;
            this.closedTicketsPriorityComboBox.Items.AddRange(new object[] {
            "Urgent",
            "Medium ",
            "Low"});
            this.closedTicketsPriorityComboBox.Location = new System.Drawing.Point(20, 32);
            this.closedTicketsPriorityComboBox.Name = "closedTicketsPriorityComboBox";
            this.closedTicketsPriorityComboBox.Size = new System.Drawing.Size(119, 21);
            this.closedTicketsPriorityComboBox.TabIndex = 11;
            // 
            // closedTicketsPriorityLabel
            // 
            this.closedTicketsPriorityLabel.AutoSize = true;
            this.closedTicketsPriorityLabel.Location = new System.Drawing.Point(17, 16);
            this.closedTicketsPriorityLabel.Name = "closedTicketsPriorityLabel";
            this.closedTicketsPriorityLabel.Size = new System.Drawing.Size(38, 13);
            this.closedTicketsPriorityLabel.TabIndex = 10;
            this.closedTicketsPriorityLabel.Text = "Priority";
            // 
            // closedTicketsSearchButton
            // 
            this.closedTicketsSearchButton.Location = new System.Drawing.Point(288, 30);
            this.closedTicketsSearchButton.Name = "closedTicketsSearchButton";
            this.closedTicketsSearchButton.Size = new System.Drawing.Size(54, 23);
            this.closedTicketsSearchButton.TabIndex = 10;
            this.closedTicketsSearchButton.Text = "Search";
            this.closedTicketsSearchButton.UseVisualStyleBackColor = true;
            // 
            // closedTicketsSearchComboBox
            // 
            this.closedTicketsSearchComboBox.Location = new System.Drawing.Point(145, 32);
            this.closedTicketsSearchComboBox.Name = "closedTicketsSearchComboBox";
            this.closedTicketsSearchComboBox.Size = new System.Drawing.Size(137, 20);
            this.closedTicketsSearchComboBox.TabIndex = 9;
            // 
            // closedTicketsSearchLabel
            // 
            this.closedTicketsSearchLabel.AutoSize = true;
            this.closedTicketsSearchLabel.Location = new System.Drawing.Point(142, 16);
            this.closedTicketsSearchLabel.Name = "closedTicketsSearchLabel";
            this.closedTicketsSearchLabel.Size = new System.Drawing.Size(74, 13);
            this.closedTicketsSearchLabel.TabIndex = 6;
            this.closedTicketsSearchLabel.Text = "Search Ticket";
            // 
            // closedTicketsEditSelectedButton
            // 
            this.closedTicketsEditSelectedButton.Location = new System.Drawing.Point(254, 358);
            this.closedTicketsEditSelectedButton.Name = "closedTicketsEditSelectedButton";
            this.closedTicketsEditSelectedButton.Size = new System.Drawing.Size(88, 23);
            this.closedTicketsEditSelectedButton.TabIndex = 3;
            this.closedTicketsEditSelectedButton.Text = "Edit Selected";
            this.closedTicketsEditSelectedButton.UseVisualStyleBackColor = true;
            this.closedTicketsEditSelectedButton.Click += new System.EventHandler(this.closedTicketsEditSelectedButton_Click);
            // 
            // managePersonelButton
            // 
            this.managePersonelButton.Location = new System.Drawing.Point(655, 13);
            this.managePersonelButton.Name = "managePersonelButton";
            this.managePersonelButton.Size = new System.Drawing.Size(122, 23);
            this.managePersonelButton.TabIndex = 13;
            this.managePersonelButton.Text = "Manage Personel";
            this.managePersonelButton.UseVisualStyleBackColor = true;
            this.managePersonelButton.Click += new System.EventHandler(this.managePersonelButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.managePersonelButton);
            this.Controls.Add(this.closedTicketsGroupBox);
            this.Controls.Add(this.openTicketsGroupBox);
            this.Controls.Add(this.label1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.openTicketsGroupBox.ResumeLayout(false);
            this.openTicketsGroupBox.PerformLayout();
            this.closedTicketsGroupBox.ResumeLayout(false);
            this.closedTicketsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox openTicketsGroupBox;
        private System.Windows.Forms.Button openTicketsEditSelectedButton;
        private System.Windows.Forms.Button openTicketsNewTicketButton;
        private System.Windows.Forms.Button openTicketsSearchButton;
        private System.Windows.Forms.TextBox openTicketsSearchTextBox;
        private System.Windows.Forms.Label openTicketsSearchLabel;
        private System.Windows.Forms.ComboBox openTicketsComboBox;
        private System.Windows.Forms.Label openTicketsPriorityLabel;
        private System.Windows.Forms.GroupBox closedTicketsGroupBox;
        private System.Windows.Forms.ComboBox closedTicketsPriorityComboBox;
        private System.Windows.Forms.Label closedTicketsPriorityLabel;
        private System.Windows.Forms.Button closedTicketsSearchButton;
        private System.Windows.Forms.TextBox closedTicketsSearchComboBox;
        private System.Windows.Forms.Label closedTicketsSearchLabel;
        private System.Windows.Forms.Button closedTicketsEditSelectedButton;
        private System.Windows.Forms.ListBox openTicketsListBox;
        private System.Windows.Forms.ListBox closedTicketsListBox;
        private System.Windows.Forms.Button managePersonelButton;
    }
}