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

namespace EmployeeManagerProject
{
    public partial class AddEmployeeForm : Form
    {
        
        public bool isOpen = false;
        public readonly string filePath = "employees.csv";
        public readonly char seperator = ',';
        public List<string> fullName = new List<string>();
        public List<int> PIN = new List<int>();
        public List<string> position = new List<string>();
        public List<string> department = new List<string>();
        public List<int> salary = new List<int>();
        public List<string> dateOfReceipt = new List<string>();
       public string fullInfo ;
        public List<string> fullInformation = new List<string>();

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] userInfo = line.Split(seperator);
                        listBox1.Items.Add(line);
                        fullInformation.Add(line);
                        //usernames.Add(userInfo[0]);
                        //passwords.Add(userInfo[1]);


                    }
                }
            }

            
            //Sales Department
            comboBoxPosition.Items.Add("Sales Manager");
            comboBoxPosition.Items.Add("Sales Consultant");
            comboBoxPosition.Items.Add("Assistant");
            //Production Department
            comboBoxPosition.Items.Add("Production Manager");
            comboBoxPosition.Items.Add("Production Technologist");
            comboBoxPosition.Items.Add("Production Worker");
            comboBoxPosition.Items.Add("Unloader");
            //Accounting Department
            comboBoxPosition.Items.Add("Main Accountant");
            comboBoxPosition.Items.Add("Accountant");
            comboBoxPosition.Items.Add("Secretary");
            //Marketing and Advertising Department
            comboBoxPosition.Items.Add("Marketing Manager");
            comboBoxPosition.Items.Add("PR");
            comboBoxPosition.Items.Add("Advertising Manager");

            comboBoxDepartment.Items.Add("Sales Department");
            comboBoxDepartment.Items.Add("Production Department");
            comboBoxDepartment.Items.Add("Accounting Department");
            comboBoxDepartment.Items.Add("Marketing and Advertising Department");
            
            lblDate.Text = "";
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dtpReceipt.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           

                // For the names of person
                if (tbName.Text != "")
                {
                    fullName.Add(tbName.Text);
                
                }
                else
                {
                    EmptyControlMessageBox("Input full name of employee!");
                    return;
                }

                //For person's PIN
                if (tbPIN.Text != "")
                {
                    try
                    {
                        PIN.Add(int.Parse(tbPIN.Text));

                    }
                    catch (Exception )
                    {
                    MessageBox.Show("Pin MUST be a number!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    
                    }
               
                }
                else
                {
                    EmptyControlMessageBox("Input PIN of employee,it MUST be a number!");
                      return;
                }

                //For person's position
                if (comboBoxPosition.SelectedItem != default)
                {
                    position.Add(comboBoxPosition.SelectedItem.ToString());
               

                }
                else
                {
                    EmptyControlMessageBox("Choose position of employee!");
                return;
                }

                //for person's department
                if (comboBoxDepartment.SelectedItem != default)
                {
                    department.Add(comboBoxDepartment.SelectedItem.ToString());
               

                }
                else
                {
                    EmptyControlMessageBox("Choose department of employee!");
                return;

                }

                //for person's salary
                if (tbSalary.Text != "")
                {
                        try
                        {
                        salary.Add(int.Parse(tbSalary.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Salary MUST be a number!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                    }
               
             
                }
                else
                {
                    EmptyControlMessageBox("Input salary of employee,it MUST be a number!");
                return;
                }

                //for person's Date of receipt
                if (dtpReceipt.Checked != default)
                {
                    dateOfReceipt.Add(dtpReceipt.Checked.ToString());
              
                }
                else
                {
                    EmptyControlMessageBox("Pick date of employee!");
                return;
                }
            
            fullInfo = tbName.Text.Trim() + seperator + tbPIN.Text.Trim() + seperator + comboBoxPosition.SelectedItem.ToString().Trim() + seperator + comboBoxDepartment.SelectedItem.ToString().Trim() + seperator + tbSalary.Text.Trim() + seperator + dtpReceipt.Text;
            listBox1.Items.Add(fullInfo);
            fullInformation.Add(fullInfo);

            using (FileStream fs = new FileStream(filePath, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {  
                    writer.WriteLine(fullInfo);
                }
            }

            //clear all controls
            
            tbName.Text = "";
            tbPIN.Text = "";
            comboBoxPosition.SelectedItem = default;
            comboBoxDepartment.SelectedItem = default;
            tbSalary.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to close? Your changes will not be saved!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void AddEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        void EmptyControlMessageBox(String message) 
        {
            MessageBox.Show(message, "Missing Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Append,FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        fullInformation.Clear();
                        listBox1.Items.Add(line);
                        fullInformation.Add(line);
                        

                    }
                }
            }
        }
    }
}
