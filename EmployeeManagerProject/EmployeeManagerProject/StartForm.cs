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
    public partial class StartForm : Form
    {
        
        AboutTheAuthorForm aboutForm = new AboutTheAuthorForm();
        AddEmployeeForm addForm = new AddEmployeeForm();
        DeleteEmployeeForm deleteForm = new DeleteEmployeeForm();
        ChangeSalaryForm changeForm = new ChangeSalaryForm();
        EmployeesInformation employeeForm = new EmployeesInformation();
       
        public StartForm()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendToBackStartUpText(label1, label2, label3, pictureBox1);

            if ( !addForm.isOpen)
            {
                addForm = new AddEmployeeForm();
                addForm.MdiParent = this;
                addForm.Show();
                addForm.isOpen = true;
                
            }
            
            else 
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendToBackStartUpText(label1, label2, label3, pictureBox1);
            if (!deleteForm.isOpen)
            {
                deleteForm = new DeleteEmployeeForm();
                deleteForm.MdiParent = this;
                deleteForm.Show();
                deleteForm.isOpen = true;
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendToBackStartUpText(label1, label2, label3, pictureBox1);
            if (!changeForm.isOpen)
            {
                changeForm = new ChangeSalaryForm();
                changeForm.MdiParent = this;
                changeForm.Show();
                changeForm.isOpen = true;
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendToBackStartUpText(label1, label2, label3, pictureBox1);
            if (!employeeForm.isOpen)
            {
                employeeForm = new EmployeesInformation();
                employeeForm.MdiParent = this;
                employeeForm.Show();
                employeeForm.isOpen = true;
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        
        private void aboutTheAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendToBackStartUpText(label1, label2, label3, pictureBox1);

            if (!aboutForm.isOpen)
            {
                aboutForm = new AboutTheAuthorForm();
                aboutForm.MdiParent = this;
                aboutForm.Show();
                aboutForm.isOpen = true;
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        void SendToBackStartUpText(Label lb1, Label lb2 , Label lb3, PictureBox pb)
        {
            lb1.SendToBack();
            lb2.SendToBack();
            lb3.SendToBack();
            pb.SendToBack();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(addForm.filePath, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] userInfo = line.Split(addForm.seperator);
                        addForm.fullInformation.Add(line);
                        addForm.fullName.Add(userInfo[0]);
                        addForm.PIN.Add(int.Parse(userInfo[1]));
                        addForm.position.Add(userInfo[2]);
                        addForm.department.Add(userInfo[3]);
                        addForm.salary.Add(int.Parse(userInfo[4]));
                        addForm.dateOfReceipt.Add(userInfo[5]);
                        //usernames.Add(userInfo[0]);
                        //passwords.Add(userInfo[1]);


                    }
                }
            }

            SendToBackStartUpText(label1, label2, label3, pictureBox1);
            if (!aboutForm.isOpen)
            {
                aboutForm = new AboutTheAuthorForm();
                aboutForm.MdiParent = this;
                aboutForm.Show();
                aboutForm.isOpen = true;
            }
            else
            {
                MessageBox.Show("Form is already opened!", "Form opened!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
