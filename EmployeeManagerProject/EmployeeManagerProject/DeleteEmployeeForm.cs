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
    public partial class DeleteEmployeeForm : Form
    {
        AddEmployeeForm addForm = new AddEmployeeForm();
        public bool isOpen = false;
        public DeleteEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBoxDeleteEmployee.SelectedIndex != -1)
            {
                int index = listBoxDeleteEmployee.SelectedIndex;
                listBoxDeleteEmployee.Items.RemoveAt(index);
                addForm.fullInformation.Clear();
                addForm.fullName.RemoveAt(index);
                addForm.PIN.RemoveAt(index);
                addForm.position.RemoveAt(index);
                addForm.department.RemoveAt(index);
                addForm.salary.RemoveAt(index);
                addForm.dateOfReceipt.RemoveAt(index);

                for (int i = 0; i < addForm.fullName.Count; i++)
                {
                    addForm.fullInformation.Add(addForm.fullName[i] + addForm.seperator + addForm.PIN[i] + addForm.seperator + addForm.position[i] + addForm.seperator
                        + addForm.department[i] + addForm.seperator + addForm.salary[i] + addForm.seperator + addForm.dateOfReceipt[i] + addForm.seperator);
                }
                File.WriteAllLines(addForm.filePath, addForm.fullInformation);
                tbPinSearch.Text = "";
            }

            else
            {
                MessageBox.Show("First choose an employee!!", "Choose!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
        }

        private void DeleteEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void tbPinSearch_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbPinSearch.Text) == false)
            {
                listBoxDeleteEmployee.Items.Clear();
                List<string> stringList = new List<string>();
                stringList = addForm.PIN.ConvertAll(delegate (int i) { return i.ToString(); });


               
                foreach (string str in stringList)
                {
                    if (str.Contains(tbPinSearch.Text))
                    {
                        
                            listBoxDeleteEmployee.Items.Add(str);

                        
                    }
                }
            }

            else if (tbPinSearch.Text == "")
            {
                listBoxDeleteEmployee.Items.Clear();
                for (int i = 0; i < addForm.fullName.Count; i++)
                {
                    addForm.fullInformation.Add(addForm.fullName[i] + addForm.seperator + addForm.PIN[i] + addForm.seperator + addForm.position[i] + addForm.seperator
                    + addForm.department[i] + addForm.seperator + addForm.salary[i] + addForm.seperator + addForm.dateOfReceipt[i] + addForm.seperator);

                    listBoxDeleteEmployee.Items.Add(addForm.fullInformation[i]);
                }
               

            }


        }

        private void DeleteEmployeeForm_Load(object sender, EventArgs e)
        {
            using (FileStream red = new FileStream(addForm.filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(red))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listBoxDeleteEmployee.Items.Add(line);
                        addForm.fullInformation.Clear();
                        string[] userInfo = line.Split(addForm.seperator);
                        addForm.fullInformation.Add(line);
                        addForm.fullName.Add(userInfo[0]);
                        addForm.PIN.Add(int.Parse(userInfo[1]));
                        addForm.position.Add(userInfo[2]);
                        addForm.department.Add(userInfo[3]);
                        addForm.salary.Add(int.Parse(userInfo[4]));
                        addForm.dateOfReceipt.Add(userInfo[5]);




                    }
                }
            }


        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            listBoxDeleteEmployee.Items.Clear();
            using (FileStream red = new FileStream(addForm.filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(red))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listBoxDeleteEmployee.Items.Add(line);
                        addForm.fullInformation.Clear();
                        addForm.fullInformation.Add(line);
                        




                    }
                }
            }
        }
    }
}
