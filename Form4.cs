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
    public partial class Form4 : Form
    {
        public int PcurrentRow { get; set; }
        public string Psubject { get; set; }
        public int Pcount { get; set; }
        public int Pprice { get; set; }
        public int POff { get; set; }
        public int PpayableAmount { get; set; }
        public int PLeftAmount { get; set; }
        public string PdatePayment { get; set; }

        public Form4(string sub,int Cunt, int pric, int off, int payAmount, int lefAmnt, string date, int currentrowww)
        {

            InitializeComponent();
            Psubject = sub;
            Pcount = Cunt;
            Pprice = pric;
            POff = off;
            PpayableAmount = payAmount;
            PLeftAmount = lefAmnt;
            PdatePayment = date;
            PcurrentRow = currentrowww+1;
            ////
            SubjectTextBox.Text = Psubject;
            countUpDown.Value = Pcount;
            PriceUpDown2.Value = Pprice;
            PayAblePriceUpDown1.Value = PpayableAmount;
            OffUpDown1.Value = POff;
            LeftAmountUpDown1.Value = PLeftAmount;
            dateTextBox1.Text = PdatePayment;
            rowText.Text = PcurrentRow.ToString();



        }

        private void EditGridView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Psubject= SubjectTextBox.Text;
            Pcount = (int)countUpDown.Value;
            Pprice=  (int)PriceUpDown2.Value;
            PpayableAmount= (int)PayAblePriceUpDown1.Value;
            POff=(int)OffUpDown1.Value;
            PLeftAmount = (int)LeftAmountUpDown1.Value;
            PdatePayment=dateTextBox1.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
