using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_DeskHeroIT
{
    public partial class DashboardForm: Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void openTicketsNewTicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewTicketForm newTicketForm = NewTicketForm.GetInstance(this);
            newTicketForm.StartPosition = FormStartPosition.CenterScreen;
            newTicketForm.Show();
        }

        private void openTicketsEditSelectedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditTicketForm editTicketForm = EditTicketForm.GetInstance(this);
            editTicketForm.StartPosition = FormStartPosition.CenterScreen;
            editTicketForm.Show();
        }

        private void closedTicketsEditSelectedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditTicketForm editTicketForm = EditTicketForm.GetInstance(this);
            editTicketForm.StartPosition = FormStartPosition.CenterScreen;
            editTicketForm.Show();
        }

        private void managePersonelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelManagementForm personelManagementForm = PersonelManagementForm.GetInstance(this);
            personelManagementForm.StartPosition = FormStartPosition.CenterScreen;
            personelManagementForm.Show();
        }
    }
}
