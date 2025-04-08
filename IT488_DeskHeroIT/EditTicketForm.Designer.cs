namespace IT488_DeskHeroIT
{
    partial class EditTicketForm
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
            this.newTicketGroupBox = new System.Windows.Forms.GroupBox();
            this.clearTicketButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ticketNameLabel = new System.Windows.Forms.Label();
            this.TicketOptions_ComboBox = new System.Windows.Forms.ComboBox();
            this.ticketPriorityLabel = new System.Windows.Forms.Label();
            this.confirmChangesButton = new System.Windows.Forms.Button();
            this.issueDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.ticketDesciptionLabel = new System.Windows.Forms.Label();
            this.estimatedTimeTextBox = new System.Windows.Forms.TextBox();
            this.estimatedCompletionTimeLabel = new System.Windows.Forms.Label();
            this.AssignedSpecialist_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.ticketDifficultyComboBox = new System.Windows.Forms.ComboBox();
            this.ticketDifficultyLabel = new System.Windows.Forms.Label();
            this.newTicketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTicketGroupBox
            // 
            this.newTicketGroupBox.Controls.Add(this.ticketDifficultyComboBox);
            this.newTicketGroupBox.Controls.Add(this.ticketDifficultyLabel);
            this.newTicketGroupBox.Controls.Add(this.clearTicketButton);
            this.newTicketGroupBox.Controls.Add(this.textBox1);
            this.newTicketGroupBox.Controls.Add(this.ticketNameLabel);
            this.newTicketGroupBox.Controls.Add(this.TicketOptions_ComboBox);
            this.newTicketGroupBox.Controls.Add(this.ticketPriorityLabel);
            this.newTicketGroupBox.Controls.Add(this.confirmChangesButton);
            this.newTicketGroupBox.Controls.Add(this.issueDescriptionTextbox);
            this.newTicketGroupBox.Controls.Add(this.ticketDesciptionLabel);
            this.newTicketGroupBox.Controls.Add(this.estimatedTimeTextBox);
            this.newTicketGroupBox.Controls.Add(this.estimatedCompletionTimeLabel);
            this.newTicketGroupBox.Controls.Add(this.AssignedSpecialist_ComboBox);
            this.newTicketGroupBox.Controls.Add(this.label6);
            this.newTicketGroupBox.Location = new System.Drawing.Point(47, 8);
            this.newTicketGroupBox.Name = "newTicketGroupBox";
            this.newTicketGroupBox.Size = new System.Drawing.Size(287, 369);
            this.newTicketGroupBox.TabIndex = 4;
            this.newTicketGroupBox.TabStop = false;
            this.newTicketGroupBox.Text = "Ticket #:";
            // 
            // clearTicketButton
            // 
            this.clearTicketButton.Location = new System.Drawing.Point(10, 337);
            this.clearTicketButton.Name = "clearTicketButton";
            this.clearTicketButton.Size = new System.Drawing.Size(53, 23);
            this.clearTicketButton.TabIndex = 18;
            this.clearTicketButton.Text = "Clear";
            this.clearTicketButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 16;
            // 
            // ticketNameLabel
            // 
            this.ticketNameLabel.AutoSize = true;
            this.ticketNameLabel.Location = new System.Drawing.Point(12, 29);
            this.ticketNameLabel.Name = "ticketNameLabel";
            this.ticketNameLabel.Size = new System.Drawing.Size(68, 13);
            this.ticketNameLabel.TabIndex = 15;
            this.ticketNameLabel.Text = "Ticket Name";
            // 
            // TicketOptions_ComboBox
            // 
            this.TicketOptions_ComboBox.FormattingEnabled = true;
            this.TicketOptions_ComboBox.Items.AddRange(new object[] {
            "Close "});
            this.TicketOptions_ComboBox.Location = new System.Drawing.Point(89, 51);
            this.TicketOptions_ComboBox.Name = "TicketOptions_ComboBox";
            this.TicketOptions_ComboBox.Size = new System.Drawing.Size(184, 21);
            this.TicketOptions_ComboBox.TabIndex = 14;
            // 
            // ticketPriorityLabel
            // 
            this.ticketPriorityLabel.AutoSize = true;
            this.ticketPriorityLabel.Location = new System.Drawing.Point(12, 54);
            this.ticketPriorityLabel.Name = "ticketPriorityLabel";
            this.ticketPriorityLabel.Size = new System.Drawing.Size(71, 13);
            this.ticketPriorityLabel.TabIndex = 13;
            this.ticketPriorityLabel.Text = "Ticket Priority";
            // 
            // confirmChangesButton
            // 
            this.confirmChangesButton.Location = new System.Drawing.Point(216, 337);
            this.confirmChangesButton.Name = "confirmChangesButton";
            this.confirmChangesButton.Size = new System.Drawing.Size(57, 23);
            this.confirmChangesButton.TabIndex = 10;
            this.confirmChangesButton.Text = "Confirm";
            this.confirmChangesButton.UseVisualStyleBackColor = true;
            // 
            // issueDescriptionTextbox
            // 
            this.issueDescriptionTextbox.Location = new System.Drawing.Point(10, 179);
            this.issueDescriptionTextbox.Multiline = true;
            this.issueDescriptionTextbox.Name = "issueDescriptionTextbox";
            this.issueDescriptionTextbox.Size = new System.Drawing.Size(263, 152);
            this.issueDescriptionTextbox.TabIndex = 8;
            // 
            // ticketDesciptionLabel
            // 
            this.ticketDesciptionLabel.AutoSize = true;
            this.ticketDesciptionLabel.Location = new System.Drawing.Point(12, 163);
            this.ticketDesciptionLabel.Name = "ticketDesciptionLabel";
            this.ticketDesciptionLabel.Size = new System.Drawing.Size(91, 13);
            this.ticketDesciptionLabel.TabIndex = 7;
            this.ticketDesciptionLabel.Text = "Issue Description:";
            // 
            // estimatedTimeTextBox
            // 
            this.estimatedTimeTextBox.Location = new System.Drawing.Point(153, 136);
            this.estimatedTimeTextBox.Name = "estimatedTimeTextBox";
            this.estimatedTimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.estimatedTimeTextBox.TabIndex = 6;
            // 
            // estimatedCompletionTimeLabel
            // 
            this.estimatedCompletionTimeLabel.AutoSize = true;
            this.estimatedCompletionTimeLabel.Location = new System.Drawing.Point(12, 143);
            this.estimatedCompletionTimeLabel.Name = "estimatedCompletionTimeLabel";
            this.estimatedCompletionTimeLabel.Size = new System.Drawing.Size(136, 13);
            this.estimatedCompletionTimeLabel.TabIndex = 5;
            this.estimatedCompletionTimeLabel.Text = "Estimated time to complete ";
            // 
            // AssignedSpecialist_ComboBox
            // 
            this.AssignedSpecialist_ComboBox.FormattingEnabled = true;
            this.AssignedSpecialist_ComboBox.Items.AddRange(new object[] {
            "Royce",
            "Brendan",
            "Wes",
            "Uziel",
            "Zaid"});
            this.AssignedSpecialist_ComboBox.Location = new System.Drawing.Point(89, 110);
            this.AssignedSpecialist_ComboBox.Name = "AssignedSpecialist_ComboBox";
            this.AssignedSpecialist_ComboBox.Size = new System.Drawing.Size(184, 21);
            this.AssignedSpecialist_ComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Assigned to";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(9, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 34);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ticketDifficultyComboBox
            // 
            this.ticketDifficultyComboBox.FormattingEnabled = true;
            this.ticketDifficultyComboBox.Items.AddRange(new object[] {
            "Close "});
            this.ticketDifficultyComboBox.Location = new System.Drawing.Point(89, 79);
            this.ticketDifficultyComboBox.Name = "ticketDifficultyComboBox";
            this.ticketDifficultyComboBox.Size = new System.Drawing.Size(184, 21);
            this.ticketDifficultyComboBox.TabIndex = 20;
            // 
            // ticketDifficultyLabel
            // 
            this.ticketDifficultyLabel.AutoSize = true;
            this.ticketDifficultyLabel.Location = new System.Drawing.Point(12, 82);
            this.ticketDifficultyLabel.Name = "ticketDifficultyLabel";
            this.ticketDifficultyLabel.Size = new System.Drawing.Size(80, 13);
            this.ticketDifficultyLabel.TabIndex = 19;
            this.ticketDifficultyLabel.Text = "Ticket Difficulty";
            // 
            // EditTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 390);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newTicketGroupBox);
            this.Name = "EditTicketForm";
            this.Text = "EditTicketForm";
            this.newTicketGroupBox.ResumeLayout(false);
            this.newTicketGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newTicketGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ticketNameLabel;
        private System.Windows.Forms.ComboBox TicketOptions_ComboBox;
        private System.Windows.Forms.Label ticketPriorityLabel;
        private System.Windows.Forms.Button confirmChangesButton;
        private System.Windows.Forms.TextBox issueDescriptionTextbox;
        private System.Windows.Forms.Label ticketDesciptionLabel;
        private System.Windows.Forms.TextBox estimatedTimeTextBox;
        private System.Windows.Forms.Label estimatedCompletionTimeLabel;
        private System.Windows.Forms.ComboBox AssignedSpecialist_ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearTicketButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox ticketDifficultyComboBox;
        private System.Windows.Forms.Label ticketDifficultyLabel;
    }
}