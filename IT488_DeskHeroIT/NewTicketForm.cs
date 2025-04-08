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
    public partial class NewTicketForm: Form
    {
        private static NewTicketForm instance;
        private Form dashboardForm;
        public NewTicketForm(Form DashboardForm)
        {
            InitializeComponent();
            dashboardForm = DashboardForm;
        }
        public static NewTicketForm GetInstance(Form home)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new NewTicketForm(home);
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
