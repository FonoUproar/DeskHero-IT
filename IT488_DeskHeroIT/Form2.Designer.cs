namespace IT488_DeskHeroIT
{
    partial class Form3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TicketOptions_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_SubmitProblemSolved = new System.Windows.Forms.Button();
            this.Button_ResetProblemSolved = new System.Windows.Forms.Button();
            this.Description_Textbox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TimeTaken_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AssignedSpecialist_ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TicketOptions_ComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Button_SubmitProblemSolved);
            this.groupBox3.Controls.Add(this.Button_ResetProblemSolved);
            this.groupBox3.Controls.Add(this.Description_Textbox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TimeTaken_Textbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.AssignedSpecialist_ComboBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 350);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Problem Solved";
            // 
            // TicketOptions_ComboBox
            // 
            this.TicketOptions_ComboBox.FormattingEnabled = true;
            this.TicketOptions_ComboBox.Items.AddRange(new object[] {
            "Close "});
            this.TicketOptions_ComboBox.Location = new System.Drawing.Point(163, 81);
            this.TicketOptions_ComboBox.Name = "TicketOptions_ComboBox";
            this.TicketOptions_ComboBox.Size = new System.Drawing.Size(110, 21);
            this.TicketOptions_ComboBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ticket Options";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "TicketID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Button_SubmitProblemSolved
            // 
            this.Button_SubmitProblemSolved.Location = new System.Drawing.Point(198, 324);
            this.Button_SubmitProblemSolved.Name = "Button_SubmitProblemSolved";
            this.Button_SubmitProblemSolved.Size = new System.Drawing.Size(75, 23);
            this.Button_SubmitProblemSolved.TabIndex = 10;
            this.Button_SubmitProblemSolved.Text = "Submit";
            this.Button_SubmitProblemSolved.UseVisualStyleBackColor = true;
            // 
            // Button_ResetProblemSolved
            // 
            this.Button_ResetProblemSolved.Location = new System.Drawing.Point(0, 324);
            this.Button_ResetProblemSolved.Name = "Button_ResetProblemSolved";
            this.Button_ResetProblemSolved.Size = new System.Drawing.Size(75, 23);
            this.Button_ResetProblemSolved.TabIndex = 9;
            this.Button_ResetProblemSolved.Text = "Reset";
            this.Button_ResetProblemSolved.UseVisualStyleBackColor = true;
            // 
            // Description_Textbox2
            // 
            this.Description_Textbox2.Location = new System.Drawing.Point(4, 214);
            this.Description_Textbox2.Multiline = true;
            this.Description_Textbox2.Name = "Description_Textbox2";
            this.Description_Textbox2.Size = new System.Drawing.Size(263, 104);
            this.Description_Textbox2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Resolution Description:";
            // 
            // TimeTaken_Textbox
            // 
            this.TimeTaken_Textbox.Location = new System.Drawing.Point(163, 161);
            this.TimeTaken_Textbox.Name = "TimeTaken_Textbox";
            this.TimeTaken_Textbox.Size = new System.Drawing.Size(110, 20);
            this.TimeTaken_Textbox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Time taken to complete ticket";
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
            this.AssignedSpecialist_ComboBox.Location = new System.Drawing.Point(163, 121);
            this.AssignedSpecialist_ComboBox.Name = "AssignedSpecialist_ComboBox";
            this.AssignedSpecialist_ComboBox.Size = new System.Drawing.Size(110, 21);
            this.AssignedSpecialist_ComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Assigned to";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(0, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 375);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button_SubmitProblemSolved;
        private System.Windows.Forms.Button Button_ResetProblemSolved;
        private System.Windows.Forms.TextBox Description_Textbox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TimeTaken_Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox AssignedSpecialist_ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox TicketOptions_ComboBox;
        private System.Windows.Forms.Label label2;
    }
}