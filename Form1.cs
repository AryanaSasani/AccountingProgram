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
    public partial class Form1 : Form
    {
        string RootUserName = "root";
        string RootPassWord = "toor";

        public string userName;
        public string passWord;
        public List<User> usersList = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool SignIn = false;
            bool RootUser = false;
           

            if(textBoxUsername.Text == RootUserName)
            {
                if(textBoxPassword.Text == RootPassWord)
                {
                    userName = "root";
                    RootUser = true;
                }
                else
                {
                    Result.Text = "Wrong password! cant access with root user";
                }
            }
            else
            {
                for(int i=0;i<usersList.Count;i++)
                {
                    if (textBoxUsername.Text == usersList[i].Username)
                    {
                        if(textBoxPassword.Text == usersList[i].PassWord)
                        {
                            userName = usersList[i].Username;
                            SignIn = true;
                        }
                        else
                        {
                            Result.Text = "Wrong username or password!";
                        }
                        break;
                    }
                }
            }

            //////========================
            if (RootUser == true || SignIn == true)
            {
                Form2 frm2 = new Form2(userName);
                frm2.ShowDialog();
            }
            else
            {
                Result.Text = "Wrong username or password!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Closed!");
            this.Close();
        }

        private void CreatAccount_Click(object sender, EventArgs e)
        {
            SignUp signupform = new SignUp();
     
            if (signupform.ShowDialog()==DialogResult.OK)
            {
                if (signupform.Error == false)
                    usersList.Add(new User(signupform.firstname, signupform.lastname, signupform.email,signupform.username, signupform.pass));
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("RootUser:  user=root    pass=toor");
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Github:  "+"https://github.com/AryanaBakhshandeh");

        }
    }
}
