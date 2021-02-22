using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerProject
{
    public partial class AboutTheAuthorForm : Form
    {
        public bool isOpen = false;
        public AboutTheAuthorForm()
        {
            InitializeComponent();
        }

        private void AboutTheAuthorForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Hello, \n My name is Angel Mladenov and I'm studying Software \ntechnologies and design in Plovdiv university \nPaisii Hilendarski. I'm almost 20 years old. This is \nmy first more complex project in which I have \ninvested the knowledge gained during the trimester. ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AboutTheAuthorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }
    }
}
