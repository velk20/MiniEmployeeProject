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
    public partial class ChangeSalaryForm : Form
    {
        AddEmployeeForm addForm = new AddEmployeeForm();
        public bool isOpen = false;
        public ChangeSalaryForm()
        {
            InitializeComponent();
        }

        private void btnChangeSalary_Click(object sender, EventArgs e)
        {
            if (tbSalary.Text == "")
            {
                MessageBox.Show("First choose an employee!!", "Choose!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = listBoxSalaryChanger.SelectedIndex;
            addForm.fullInformation.Clear();
            addForm.salary.RemoveAt(index);
            addForm.salary.Insert(index, int.Parse(tbSalary.Text));
            listBoxSalaryChanger.Items.Clear();
            for (int i = 0; i < addForm.fullName.Count; i++)
            {
                addForm.fullInformation.Add(addForm.fullName[i] + addForm.seperator + addForm.PIN[i] + addForm.seperator + addForm.position[i] + addForm.seperator
                    + addForm.department[i] + addForm.seperator + addForm.salary[i] + addForm.seperator + addForm.dateOfReceipt[i] + addForm.seperator);

                listBoxSalaryChanger.Items.Add(addForm.fullInformation[i]);
            }
            File.WriteAllLines(addForm.filePath, addForm.fullInformation);
            

        }

        private void ChangeSalaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void ChangeSalaryForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(addForm.filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listBoxSalaryChanger.Items.Add(line);
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

        private void listBoxSalaryChanger_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxSalaryChanger.SelectedIndex;
            tbSalary.Text = addForm.salary[index].ToString();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            listBoxSalaryChanger.Items.Clear();
            using (FileStream red = new FileStream(addForm.filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(red))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listBoxSalaryChanger.Items.Add(line);
                        addForm.fullInformation.Clear();
                        addForm.fullInformation.Add(line);





                    }
                }
            }
        }
    }
}
