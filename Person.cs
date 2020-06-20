using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receipt
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string EMailAdress { get; set; }



        public List<string> subject = new List<string>();
        public List<int> count = new List<int>();
        public List<int> price = new List<int>(); // row price
        //new
        public List<int> Off = new List<int>();
        public List<int> payableAmount = new List<int>();
        public List<int> LeftAmount = new List<int>();

        public List<string> datePayment = new List<string>();





        public Person(string first,string last ,string Phone,string mail,string adress)
        {
            FirstName = first;
            LastName = last;
            Adress = adress;
            PhoneNumber = Phone;
            EMailAdress = mail;
        }
    }
}
