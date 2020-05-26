using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receipt
{
    public class User
    {
        private string Fname;
        private string Lname;
        private string EmailAdress;
        private string Password;
        private string UserName;
        public string FName { get; }
        public string LName { get; }
        public string EmailAd { get; }
        public string PassWord { get; }
        public string Username { get; }




        public User(string firstname, string lastname, string Email,string username, string password)
        {
            Fname = firstname;
            Lname = lastname;
            EmailAdress = Email;
            Password = password;
            UserName = username;
            FName = Fname;
            LName = Lname;
            EmailAd = EmailAdress;
            PassWord = Password;
            Username = UserName;

            MessageBox.Show("New user created !");

        }
    }
}
