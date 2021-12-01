using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeScheduleForm changeScheduleForm = new ChangeScheduleForm();
            changeScheduleForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeederControlForm createScheduleForm = new FeederControlForm();
            createScheduleForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckTheScheduleForm checkTheScheduleForm = new CheckTheScheduleForm();
            checkTheScheduleForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FeedForm feedForm = new FeedForm();
            feedForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetInfoForm getInfoForm = new GetInfoForm();
            getInfoForm.Show();
        }
    }
}
