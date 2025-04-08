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
    public partial class PersonelManagementForm: Form
    {
        private static PersonelManagementForm instance;
        private Form dashboardForm;
        public PersonelManagementForm(Form DashboardForm)
        {
            InitializeComponent();
            dashboardForm = DashboardForm;
        }
        public static PersonelManagementForm GetInstance(Form home)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PersonelManagementForm(home);
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void personelManagementFormLabel_Click(object sender, EventArgs e)
        {

        }

        private void createTeamMemberLabel_Click(object sender, EventArgs e)
        {

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
