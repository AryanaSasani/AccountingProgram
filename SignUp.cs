using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receipt
{
    public partial class SignUp : Form
    {
        public string firstname;
        public string lastname;
        public string username;

        public string email;
        public string pass;
        public bool Error = true;

        public SignUp()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if(FirstName.Text=="First Name")
            {
                FirstName.Text = "";
                FirstName.ForeColor = Color.Black;
            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "First Name";
                FirstName.ForeColor = Color.Silver;
            }
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (LastName.Text == "Last Name")
            {
                LastName.Text = "";
                LastName.ForeColor = Color.Black;
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text == "")
            {
                LastName.Text = "Last Name";
                LastName.ForeColor = Color.Silver;
            }
        }

        private void UsernameTBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTBox.Text == "Username")
            {
                UsernameTBox.Text = "";
                UsernameTBox.ForeColor = Color.Black;
            }
        }

        private void UsernameTBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTBox.Text == "")
            {
                UsernameTBox.Text = "Username";
                UsernameTBox.ForeColor = Color.Silver;
            }
        }
        private void mail_Enter(object sender, EventArgs e)
        {
            if (mail.Text == "Email")
            {
                mail.Text = "";
                mail.ForeColor = Color.Black;
            }
        }

        private void mail_Leave(object sender, EventArgs e)
        {
            if (mail.Text == "")
            {
                mail.Text = "Email";
                mail.ForeColor = Color.Silver;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Silver;
            }
        }

        private void ConfPas_Enter(object sender, EventArgs e)
        {
            if (ConfPas.Text == "Confirm Password")
            {
                ConfPas.Text = "";
                ConfPas.ForeColor = Color.Black;
            }
        }

        private void ConfPas_Leave(object sender, EventArgs e)
        {
            if (ConfPas.Text == "")
            {
                ConfPas.Text = "Confirm Password";
                ConfPas.ForeColor = Color.Silver;
            }
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Error = false;
            firstname = FirstName.Text;
            lastname = LastName.Text;
            if (UsernameTBox.Text == "")
            {
                Error = true;
                MessageBox.Show("please enter an Username!");
            }
            else
                username = UsernameTBox.Text;
            email = mail.Text;
            if (Password.Text == ConfPas.Text)
                pass = Password.Text;
            else
            {
                Error = true;
                MessageBox.Show("Passwords don't match !");
            }
            if(AcceptCheck.Checked==false)
            {
                Error = true;
                MessageBox.Show("Please check the CheckBox if you wanna proceed !");
            }
            if(Error==false)
            {
                DialogResult=DialogResult.OK;
            }
            
        }

        private void UsernameTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
