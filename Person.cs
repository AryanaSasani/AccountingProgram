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

        public List<string> subject = new List<string>();
        public List<int> count = new List<int>();
        public List<int> price = new List<int>();


        public Person(string first,string last ,string adress)
        {
            FirstName = first;
            LastName = last;
            Adress = adress;
        }
    }
}
