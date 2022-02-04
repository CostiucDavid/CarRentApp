﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lPassword.BackColor = System.Drawing.Color.Transparent;
            lUsername.BackColor = System.Drawing.Color.Transparent;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                var name = tbUsername.Text;
                var password = tbPassword.Text;
                var hashPassword = Utils.HashPassword(password);
                //check for matching username, passwoed and active flag
                var user = "David";
                if (user == null)
                {
                    MessageBox.Show("please provide valid credentials");

                }
                else
                {

                    var mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, please try again, in 5 min :)");
                throw;
            }
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please fill form");
            }
            else
            { 
                btnLogin.Enabled = true;
                btnLogin.Select();
            }
          

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                label1.Text = "Please fill username";
            }
        }

        private void tbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                label1.Text = "";
            }
            else
            {
                btnLogin.Enabled = true;
                btnLogin.Select();
            }
        }
    }
}
