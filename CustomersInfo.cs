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
    public partial class CustomersInfo : Form
    {
        public CustomersInfo(string fName,string lName,string phone,string mail,string adress)
        {
            InitializeComponent();
            FnameText.Text = fName;
            LnameText.Text = lName;
            PhoneText.Text = phone;
            EmailText.Text = mail;
            AdressText.Text = adress;
        }

        private void CustomersInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
