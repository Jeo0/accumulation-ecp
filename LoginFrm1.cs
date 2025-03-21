using Activity5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectNamin
{
    public partial class LoginFrm1 : Form
    {
        public LoginFrm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            password = "jessiejude";
            username = "admin";
            if (usernameTxtbox.Text == username && passwordtxtbox.Text == password)
            {
                MessageBox.Show("Welcome!!!");
                A_Main_form adminfrm = new A_Main_form();
                this.Hide();
                adminfrm.ShowDialog(); // dont use form.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPass_check_CheckedChanged(object sender, EventArgs e)
        {
            bool showpass_state = showPass_check.Checked;

            switch (showpass_state)
            {
                case false:
                    passwordtxtbox.PasswordChar = '*';
                    break;
                case true:
                    passwordtxtbox.PasswordChar = '\0';
                    break;
            }
            
        }
    }
}
