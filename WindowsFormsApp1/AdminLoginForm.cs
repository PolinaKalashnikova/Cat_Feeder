using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminLoginForm : Form
    {
        public Form1 PreviousForm { get; }

        public AdminLoginForm(Form1 prevform)
        {
            PreviousForm = prevform;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PreviousForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            string pass = "catfeeder";
            if (textBox2.Text == pass)
            {
                adminForm.Show();
                this.Hide();
            }
            else MessageBox.Show("Не верный пароль");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
