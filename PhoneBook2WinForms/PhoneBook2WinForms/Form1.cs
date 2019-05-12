﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook2;

namespace PhoneBook2WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void standardUser_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (standardUser.Checked)
            {
                //displayPhonebook.Text = StandardUser.Display();  - NOT WORKING
            }
            else if (supervisor.Checked)
            {
                displayPhonebook.Text = "supervisor";
            }
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            displayPhonebook.Clear();
        }
    }
}