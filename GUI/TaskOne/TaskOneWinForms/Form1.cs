using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskOneCommon;

namespace TaskOneWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Person p1 = new Person();
        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            string firstName = firstNameText.Text;
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            string lastName = lastNameText.Text;
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            string email = emailText.Text;
        }

        private void generateUserName_Click(object sender, EventArgs e)
        {
            //Person p1 = new Person();
            userNameLbl.Text = p1.GenerateUserName();
        }

        private void password1Text_TextChanged(object sender, EventArgs e)
        {
            string password1 = password1Text.Text;
        }

        private void password2Text_TextChanged(object sender, EventArgs e)
        {
            string password2 = password2Text.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text == String.Empty || lastNameText.Text == String.Empty || emailText.Text==String.Empty)
                MessageBox.Show("Please complete all fields");
            else if (password1Text.Text != password2Text.Text)
                MessageBox.Show("Your passwords didn't match. Please try again.");
            else
            {
                MessageBox.Show("Registration successfully completed.");
            }
        }
    }
}
