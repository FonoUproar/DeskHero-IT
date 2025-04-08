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
    public partial class EditTicketForm: Form
    {
        private static EditTicketForm instance;
        private Form dashboardForm;
        public EditTicketForm(Form DashboardForm)
        {
            InitializeComponent();
            dashboardForm = DashboardForm;
        }
        public static EditTicketForm GetInstance(Form home)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EditTicketForm(home);
            }
            return instance;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (dashboardForm != null && !dashboardForm.IsDisposed)
            {
                dashboardForm.StartPosition = FormStartPosition.CenterScreen;
                dashboardForm.Show();
            }
            else
            {
                dashboardForm = new DashboardForm();
                dashboardForm.StartPosition = FormStartPosition.CenterScreen;
                dashboardForm.Show();
            }
        }
    }
}
