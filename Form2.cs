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
    public partial class Form2 : Form
    {
        List<Person> personList = new List<Person>();
        public int PersonIndex = 0;


        public Form2(string user)
        {
            InitializeComponent();
            CurrentUsername.Text = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void NewLineGBox_Enter(object sender, EventArgs e)
        {

        }

       

        private void AddPerson_Click(object sender, EventArgs e)
        {
            
            Form3 frm3 = new Form3();


            if (frm3.ShowDialog() == DialogResult.OK)
            {

                personList.Add(new Person(frm3.fName, frm3.lName, frm3.aDreSS));
                Accounts.Items.Add(frm3.fName + " " + frm3.lName);
            }
           
            
                    
            //Form3 frm3 = new Form3();
            //frm3.ShowDialog();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            string selectedAcount = Accounts.GetItemText(Accounts.SelectedItem);
            // Accounts.SelectedItem
            for (int i = 0; i < personList.Count; i++)
            {
                string name = (personList[i].FirstName + " " + personList[i].LastName);
              
                if (name == selectedAcount)
                {
                    personList[i].subject.Add(SubjectTextBox.Text);
                    personList[i].count.Add((int)countUpDown.Value);
                    personList[i].price.Add((int)PriceUpDown2.Value);
                    break;
                }
            }

            if (Accounts.GetItemText(Accounts.SelectedItem) != "")
                RefreshGridview();
            else
                MessageBox.Show("خطا! لطفا صورت حسابی انتخاب کنید");
        }

        private void ShowDetail_Click(object sender, EventArgs e)
        {
            if (Accounts.GetItemText(Accounts.SelectedItem) != "")
                RefreshGridview();
            else
                MessageBox.Show("خطا! لطفا صورت حسابی انتخاب کنید");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RefreshGridview()
        {
            dataGridView1.Rows.Clear();
            string SelectedAcountName = Accounts.GetItemText(Accounts.SelectedItem);
            int AcountIndex = 0;

            // AcountIndex intialize
            for (int i = 0; i < personList.Count; i++)
            {
                string name = (personList[i].FirstName + " " + personList[i].LastName);


                if (name == SelectedAcountName)
                {
                    AcountIndex = i;
                    PersonIndex = i;
                    break;
                }
            }

            // gridview 
            for (int i = 0; i < personList[AcountIndex].subject.Count; i++)
            {
                dataGridView1.Rows.Add(i + 1, personList[AcountIndex].subject[i], personList[AcountIndex].count[i], personList[AcountIndex].price[i]);
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            int rowIndex=0;
         
            if (Accounts.GetItemText(Accounts.SelectedItem) != "")
            {

                if(dataGridView1.CurrentCell!=null)
                {
                    rowIndex = dataGridView1.CurrentCell.RowIndex;
                    try
                    {
                        personList[PersonIndex].subject.RemoveAt(rowIndex);  //sub
                        personList[PersonIndex].count.RemoveAt(rowIndex);  //count
                        personList[PersonIndex].price.RemoveAt(rowIndex);  //price

                        RefreshGridview();

                    }
                    catch(ArgumentOutOfRangeException ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("!لطفا سطری را انتخاب کنید");

                }


            }
            else
            {
                MessageBox.Show("!لطفا صورتحساب کسی را انتخاب کنید");
            }

           /* int rowIndex = dataGridView1.CurrentCell.RowIndex;
           // dataGridView1.Rows.RemoveAt(rowIndex);
            personList[PersonIndex].subject.RemoveAt(rowIndex);  //sub
            personList[PersonIndex].count.RemoveAt(rowIndex);  //count
            personList[PersonIndex].price.RemoveAt(rowIndex);  //price

            RefreshGridview();*/
        }
    }
}
