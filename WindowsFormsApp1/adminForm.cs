using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddFeederForm addFeederForm = new AddFeederForm();
            addFeederForm.Show();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void check_the_status_Click(object sender, EventArgs e)
        {
            CheckStatus checkStatus = new CheckStatus();
            checkStatus.Show();
            

        }

        private void get_info_Click(object sender, EventArgs e)
        {
            GetInfoForm getInfoForm = new GetInfoForm();
            getInfoForm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
