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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string fName { get; set; }
        public string lName { get; set; }
        public string aDreSS { get; set; }



        private void Save_Click(object sender, EventArgs e)
        {
            fName = FirstText.Text;
            lName = LastText.Text;
            aDreSS = AdressText.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstText_Enter(object sender, EventArgs e)
        {

        }

        public void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
