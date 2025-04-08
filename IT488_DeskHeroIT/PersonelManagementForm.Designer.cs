namespace IT488_DeskHeroIT
{
    partial class PersonelManagementForm
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
            this.createTeamMemberButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.currentTeamMembersListBox = new System.Windows.Forms.ListBox();
            this.personelManagementFormLabel = new System.Windows.Forms.Label();
            this.createTeamMemberLabel = new System.Windows.Forms.Label();
            this.currentTeamMembersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTeamMemberButton
            // 
            this.createTeamMemberButton.Location = new System.Drawing.Point(206, 155);
            this.createTeamMemberButton.Name = "createTeamMemberButton";
            this.createTeamMemberButton.Size = new System.Drawing.Size(75, 23);
            this.createTeamMemberButton.TabIndex = 0;
            this.createTeamMemberButton.Text = "Create";
            this.createTeamMemberButton.UseVisualStyleBackColor = true;
            this.createTeamMemberButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 94);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proficiency";
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Location = new System.Drawing.Point(32, 155);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(75, 23);
            this.clearEntryButton.TabIndex = 5;
            this.clearEntryButton.Text = "Clear";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            // 
            // currentTeamMembersListBox
            // 
            this.currentTeamMembersListBox.FormattingEnabled = true;
            this.currentTeamMembersListBox.Location = new System.Drawing.Point(32, 217);
            this.currentTeamMembersListBox.Name = "currentTeamMembersListBox";
            this.currentTeamMembersListBox.Size = new System.Drawing.Size(249, 199);
            this.currentTeamMembersListBox.TabIndex = 6;
            // 
            // personelManagementFormLabel
            // 
            this.personelManagementFormLabel.AutoSize = true;
            this.personelManagementFormLabel.Location = new System.Drawing.Point(100, 20);
            this.personelManagementFormLabel.Name = "personelManagementFormLabel";
            this.personelManagementFormLabel.Size = new System.Drawing.Size(113, 13);
            this.personelManagementFormLabel.TabIndex = 7;
            this.personelManagementFormLabel.Text = "Personel Management";
            this.personelManagementFormLabel.Click += new System.EventHandler(this.personelManagementFormLabel_Click);
            // 
            // createTeamMemberLabel
            // 
            this.createTeamMemberLabel.AutoSize = true;
            this.createTeamMemberLabel.Location = new System.Drawing.Point(104, 61);
            this.createTeamMemberLabel.Name = "createTeamMemberLabel";
            this.createTeamMemberLabel.Size = new System.Drawing.Size(109, 13);
            this.createTeamMemberLabel.TabIndex = 8;
            this.createTeamMemberLabel.Text = "Create Team Member";
            this.createTeamMemberLabel.Click += new System.EventHandler(this.createTeamMemberLabel_Click);
            // 
            // currentTeamMembersLabel
            // 
            this.currentTeamMembersLabel.AutoSize = true;
            this.currentTeamMembersLabel.Location = new System.Drawing.Point(96, 201);
            this.currentTeamMembersLabel.Name = "currentTeamMembersLabel";
            this.currentTeamMembersLabel.Size = new System.Drawing.Size(117, 13);
            this.currentTeamMembersLabel.TabIndex = 9;
            this.currentTeamMembersLabel.Text = "Current Team Members";
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(88, 422);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(140, 23);
            this.deleteSelectedButton.TabIndex = 10;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(32, 34);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PersonelManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 459);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.currentTeamMembersLabel);
            this.Controls.Add(this.createTeamMemberLabel);
            this.Controls.Add(this.personelManagementFormLabel);
            this.Controls.Add(this.currentTeamMembersListBox);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.createTeamMemberButton);
            this.Name = "PersonelManagementForm";
            this.Text = "ManagePersonelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTeamMemberButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.ListBox currentTeamMembersListBox;
        private System.Windows.Forms.Label personelManagementFormLabel;
        private System.Windows.Forms.Label createTeamMemberLabel;
        private System.Windows.Forms.Label currentTeamMembersLabel;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button backButton;
    }
}