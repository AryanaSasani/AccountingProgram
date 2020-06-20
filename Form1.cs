using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// /users.txt File order :   Username|Password|Firstname|LastName|Email
/// </summary>
namespace Receipt
{
    public partial class Form1 : Form
    {
        string RootUserName = "root";
        string RootPassWord = "toor";

        public string userName;
        public string passWord;
        //public List<User> usersList = new List<User>();
        public Form1()
        {
            InitializeComponent();
            string dataPath = "data"; // your code goes here

            bool exists = System.IO.Directory.Exists(dataPath);

            if (!exists)
                System.IO.Directory.CreateDirectory(dataPath);

            if (File.Exists("users.txt") == false)
            {
                using (StreamWriter newFile = new StreamWriter("users.txt"))
                {

                }
            }
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
                string UsTest="";
                string PassTest = "";

                StreamReader sr = new StreamReader("users.txt");
                // File !
                string Line = "";
                while(Line!=null)
                {
                    Line = sr.ReadLine();
                    if(Line != null)
                    {
                        UsTest = Line.Split('|')[0];
                        PassTest = Line.Split('|')[1];

                        if(UsTest== textBoxUsername.Text)
                        {
                            if (textBoxPassword.Text == PassTest)
                            {
                                userName = UsTest;
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
                sr.Close();




                //========================================
                /// local variables
                /*for(int i=0;i<usersList.Count;i++)
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
                }*/
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
            bool Exist = false;

            if (signupform.ShowDialog()==DialogResult.OK)
            {
                if(File.Exists("users.txt")==false)
                {
                    using (StreamWriter newFile=new StreamWriter("users.txt"))
                    {

                    }
                }
                if (signupform.Error == false)
                {
                    StreamReader sr = new StreamReader("users.txt");
                    string Line = "";

                    while (Line!=null)
                    {
                        Line = sr.ReadLine(); //// split nemishe az inja kard! chon exeption mide XD
                        if(Line!=null)
                        {
                            Line = Line.Split('|')[0];
                            if (signupform.username == Line)
                            {
                                Exist = true;
                                MessageBox.Show("You cant choose this user name ! (" + signupform.username + ")  (This username was taken)");  
                                break;
                            }

                        }
                    }
                    sr.Close();
                    if (Exist == false)
                    {
                        //usersList.Add(new User(signupform.firstname, signupform.lastname, signupform.email,signupform.username, signupform.pass));
                        StreamWriter sw = new StreamWriter("users.txt",true);
                        sw.WriteLine(signupform.username+"|"+ signupform.pass+"|"+ signupform.firstname+"|"+ signupform.lastname+"|"+ signupform.email);
                        sw.Close();
                       
                    }
                }
                
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
