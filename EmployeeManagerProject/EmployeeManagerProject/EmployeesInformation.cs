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
    public partial class EmployeesInformation : Form
    {
        public bool isOpen = false;
        AddEmployeeForm addForm = new AddEmployeeForm();
        public EmployeesInformation()
        {
            InitializeComponent();
        }

        private void EmployeesInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void EmployeesInformation_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(addForm.filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lbEmplyeesInformation.Items.Add(line);
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
            lbEmplyeesInformation.Items.Clear();
            using (FileStream red = new FileStream(addForm.filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(red))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        lbEmplyeesInformation.Items.Add(line);
                        addForm.fullInformation.Clear();
                        addForm.fullInformation.Add(line);





                    }
                }
            }
        }
    }
}
