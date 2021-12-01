using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FeederControlForm : Form
    {
        public FeederControlForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeederSeting feederSeting = new FeederSeting();
            feederSeting.Show();

        }
    }
}
