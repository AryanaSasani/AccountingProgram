using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receipt
{
    public partial class Form2 : Form
    {
        //List<Person> personList = new List<Person>();
        public int PersonIndex = 0;


        public Form2(string user)
        {
            InitializeComponent();
            CurrentUsername.Text = user;
            //creat data
            string UserDataPath = "data\\"+user; // your code goes here
            bool exists = System.IO.Directory.Exists(UserDataPath);
            if (!exists)
                System.IO.Directory.CreateDirectory(UserDataPath);

            if (File.Exists(@"data\" + user + ".txt")==false)
            {
                StreamWriter sw = new StreamWriter(@"data\" + user + ".txt");
                sw.Close();

            }

            //load Customers :
            StreamReader sr = new StreamReader(@"data\" + user + ".txt");
            string Line = "";
            
            while (Line != null)
            {
                Line = sr.ReadLine();
                if (Line != null)
                {
                    Line = Line.Split('|')[0];
                    Accounts.Items.Add(Line);
                }
                else
                    break;
                

            }
            sr.Close();


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

               
                StreamReader sr = new StreamReader("data\\"+CurrentUsername.Text+".txt");
                string Line = "";
                bool Exist = false;
                while (Line != null)
                {
                    Line = sr.ReadLine();
                    if (Line != null)
                    {
                        if (frm3.fName + " " + frm3.lName == Line)
                        {
                            Exist = true;
                            MessageBox.Show("That customer Alredy Exists !");
                            break;
                        }

                    }
                }
                sr.Close();
                if (Exist == false)
                {
                    
                    //personList.Add(new Person(frm3.fName, frm3.lName, frm3.phoneNumber, frm3.EMail, frm3.aDreSS));
                    Accounts.Items.Add(frm3.fName + " " + frm3.lName);
                    StreamWriter sw = new StreamWriter("data\\" + CurrentUsername.Text + ".txt", true);
                    sw.WriteLine(frm3.fName + " " + frm3.lName + "|" + frm3.EMail + "|" + frm3.phoneNumber + "|" + frm3.aDreSS);
                    sw.Close();
                    string acountname=frm3.fName + " " + frm3.lName;
                    StreamWriter swGridvew = new StreamWriter(@"data\\" + CurrentUsername.Text + "\\" + acountname + ".txt");
                    swGridvew.Close();
                }
       
                
            }

        }

        private void AddItem_Click(object sender, EventArgs e)  // ghable W.C doros kardam
        {
            string selectedAcount = Accounts.GetItemText(Accounts.SelectedItem);
           

            if (selectedAcount!="")
            {
                //=================
                int DataCount = 0;

                StreamReader streamReader = new StreamReader(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt");
                //count how many lines exists in the file ...
                string Line = "";
                while (Line !=null)
                {
                    Line = streamReader.ReadLine();
                    if (Line != null)
                    {
                        DataCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                streamReader.Close();

                //=============
                StreamWriter streamWriter = new StreamWriter(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt",true);
                string dataToSave = (DataCount+1).ToString()+"|" + dateTextBox1.Text + "|" + SubjectTextBox.Text + "|" + countUpDown.Value.ToString() + "|" + PriceUpDown2.Value.ToString() + "|" + OffUpDown1.Value.ToString() + "|" + PayAblePriceUpDown1.Value.ToString() + "|" + LeftAmountUpDown1.Value.ToString();
                streamWriter.WriteLine(dataToSave);
                streamWriter.Close();
            }
            else
                MessageBox.Show("خطا! لطفا صورت حسابی انتخاب کنید");
            RefreshGridview();// bug!!

        }

        private void ShowDetail_Click(object sender, EventArgs e)
        {
            RefreshGridview();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RefreshGridview()
        {
            dataGridView1.Rows.Clear();

            string SelectedAcountName = Accounts.GetItemText(Accounts.SelectedItem);
            if (SelectedAcountName!="")
            {
                string[] datas = new string[8];
                StreamReader streamReader = new StreamReader(@"data\\" + CurrentUsername.Text + "\\" + SelectedAcountName + ".txt");
                //count how many lines exists in the file ...
                string Line = "";
                Line = streamReader.ReadLine();
                while (Line != null)
                {

                    if (Line != null)
                    {
                        datas = Line.Split('|');
                        dataGridView1.Rows.Add(datas);
                        Line = streamReader.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                streamReader.Close();

            }
           
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            string selectedAcount = Accounts.GetItemText(Accounts.SelectedItem);

            /// fix this !
            /// 
            if (Accounts.GetItemText(Accounts.SelectedItem) != "")
            {
                int deletedRow = 0;
            
                if (dataGridView1.CurrentCell != null)
                {
                    deletedRow = dataGridView1.CurrentCell.RowIndex+1;
              
                    try
                    {

                        string tempFile = Path.GetTempFileName();

                        using (var sr = new StreamReader(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt"))
                        {
                            using (var sw = new StreamWriter(tempFile))
                            {
                                string[] line=new string[8];
                                string Line = "";
                                while ((Line=sr.ReadLine()) != null)
                                {
                                    line = Line.Split('|');
                                    if (line[0] != deletedRow.ToString()) ///fix kon
                                        sw.WriteLine(Line);
                                }
                                
                            }

                        }
                        /// write 
                        if (selectedAcount != "")
                        {
                            //=================
                            int DataCount = 0;

                            StreamReader streamReader = new StreamReader(tempFile);
                            //count how many lines exists in the file ...
                            string Line = "";
                            while (Line != null)
                            {
                                Line = streamReader.ReadLine();
                                if (Line != null)
                                {
                                    DataCount++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            streamReader.Close();

                            //=============edit File
                            StreamWriter streamWriter = new StreamWriter(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt");
                            string[] line = new string[8];
                            string Linee = "";
                            using (var sr = new StreamReader(tempFile))
                            {
                                for (int i = 1; i <= DataCount; i++)
                                {
                                    line = sr.ReadLine().Split('|');
                                    
                                    string dataToSave = (i.ToString() + "|" + line[1] + "|" + line[2] + "|" + line[3] + "|" + line[4] + "|" + line[5] + "|" + line[6] + "|" + line[7]);
                                    streamWriter.WriteLine(dataToSave);

                                }
                            }
                            streamWriter.Close();
                        }
                        else
                            MessageBox.Show("خطا! لطفا صورت حسابی انتخاب کنید");
                       
                        File.Delete(tempFile);
                        // File.Move(tempFile, "file.txt");


                        RefreshGridview();

                    }
                    catch (ArgumentOutOfRangeException ex)
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
            /// //
           
            /* int rowIndex=0;

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

                         personList[PersonIndex].datePayment.RemoveAt(rowIndex);  //date
                         personList[PersonIndex].LeftAmount.RemoveAt(rowIndex);  //LeftAmount
                         personList[PersonIndex].Off.RemoveAt(rowIndex);  //Off
                         personList[PersonIndex].payableAmount.RemoveAt(rowIndex);  //payableAmount



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
             }*/


        }

        private void NewLineGBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ShowInfo_Click(object sender, EventArgs e)
        {
            /// ???
            string selectedAcount = Accounts.GetItemText(Accounts.SelectedItem);

            string SelectedAcountName = Accounts.GetItemText(Accounts.SelectedItem);
            string[] datas = new string[8];
            StreamReader streamReader = new StreamReader(@"data\\" + CurrentUsername.Text + ".txt");
            string Line = "";
            string[] InfoCustomer = new string[4];

            while (Line != null)
            {
                Line = streamReader.ReadLine();
                if(Line!=null)
                {
                    InfoCustomer=Line.Split('|');
                    if (InfoCustomer [0]== selectedAcount)
                    {
                        CustomersInfo cusInfo = new CustomersInfo(InfoCustomer[0].Split(' ')[0], InfoCustomer[0].Split(' ')[1], InfoCustomer[2], InfoCustomer[1], InfoCustomer[3]);

                        if (cusInfo.ShowDialog() == DialogResult.OK)
                        {
                        }
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            streamReader.Close();

            // Accounts.SelectedItem


            /*for (int i = 0; i < personList.Count; i++)
            {
                string name = (personList[i].FirstName + " " + personList[i].LastName);

                if (name == selectedAcount)
                {

                    CustomersInfo cusInfo = new CustomersInfo(personList[i].FirstName, personList[i].LastName, personList[i].PhoneNumber, personList[i].EMailAdress, personList[i].Adress);

                    if (cusInfo.ShowDialog() == DialogResult.OK)
                    {
                    }
                    break;
                }
            }*/

            ///

        }

        private void GridDoubleClick(object sender, EventArgs e)
        {

        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            int rowIndex = 0;
            string selectedAcount = Accounts.GetItemText(Accounts.SelectedItem);
            if (selectedAcount != "")
            {

                if (dataGridView1.CurrentCell != null)
                {
                    rowIndex = dataGridView1.CurrentCell.RowIndex;
                    string[] NewData = new string[8];
                    string[] OldData = new string[8];

                    try
                    {
                        bool Exit = false;
                        string DataLine = "";

                        using (var readFiler = new StreamReader(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt"))
                        {
                      
                            for(int i=1;i<= rowIndex+1;i++)
                            {
                                
                                DataLine = readFiler.ReadLine();
                                if (DataLine==null)
                                {
                                    Exit = true;
                                    break;
                                }
                            }
                        }
                        if(Exit==false)
                        {
                            OldData = DataLine.Split('|');

                            string SuB = OldData[2];  //sub
                            int CoUnT = int.Parse(OldData[3]);  //count
                            int PrIce = int.Parse( OldData[4]);  //price

                            string DaTe = OldData[1];  //date
                            int LeFtAmNt = int.Parse(OldData[7]);  //LeftAmount
                            int oFf = int.Parse(OldData[5]);  //Off
                            int PaYaBleAMNT = int.Parse(OldData[6]);  //payableAmount

                            Form4 frm4 = new Form4(SuB, CoUnT, PrIce, oFf, PaYaBleAMNT, LeFtAmNt, DaTe, rowIndex);
                            if (frm4.ShowDialog() == DialogResult.OK)
                            {

                                NewData[2] = frm4.Psubject;  //sub
                                NewData[3] = frm4.Pcount.ToString();  //count
                                NewData[4] = frm4.Pprice.ToString();  //price

                                NewData[0] = (rowIndex + 1).ToString();
                                NewData[1] = frm4.PdatePayment;  //date
                                NewData[7] = frm4.PLeftAmount.ToString();  //LeftAmount
                                NewData[5] = frm4.POff.ToString();  //Of
                                NewData[6] = frm4.PpayableAmount.ToString();  //payableAmount

                                /// $$$$$$$$$$$$$$$$$$$$$


                                int deletedRow = rowIndex + 1;



                                string tempFile = Path.GetTempFileName();

                                using (var sr = new StreamReader(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt"))
                                {
                                    using (var sw = new StreamWriter(tempFile))
                                    {
                                        string[] line = new string[8];
                                        string Line = "";
                                        while ((Line = sr.ReadLine()) != null)
                                        {
                                            line = Line.Split('|');
                                            if (line[0] != deletedRow.ToString()) ///fix kon
                                                sw.WriteLine(Line);
                                            else
                                            {
                                                Line = "";
                                                for (int i = 0; i < 7; i++)
                                                {
                                                    Line = Line + NewData[i] + "|";
                                                }
                                                Line += NewData[7];
                                                sw.WriteLine(Line);

                                            }
                                        }

                                    }
                                }
                                File.Delete(@"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt");

                                File.Copy(tempFile, @"data\\" + CurrentUsername.Text + "\\" + selectedAcount + ".txt");
                                File.Delete(tempFile);

                                MessageBox.Show("تغییرات با موفقیت اعمال شد");

                            }

                        }


                        RefreshGridview();

                    }
                    catch (ArgumentOutOfRangeException ex)
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

        }
    }
}
