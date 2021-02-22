
namespace EmployeeManagerProject
{
    partial class ChangeSalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSalaryChanger = new System.Windows.Forms.ListBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.btnChangeSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSalaryChanger
            // 
            this.listBoxSalaryChanger.FormattingEnabled = true;
            this.listBoxSalaryChanger.Location = new System.Drawing.Point(42, 31);
            this.listBoxSalaryChanger.Name = "listBoxSalaryChanger";
            this.listBoxSalaryChanger.Size = new System.Drawing.Size(649, 407);
            this.listBoxSalaryChanger.TabIndex = 0;
            this.listBoxSalaryChanger.SelectedIndexChanged += new System.EventHandler(this.listBoxSalaryChanger_SelectedIndexChanged);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(209, 457);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 1;
            // 
            // btnChangeSalary
            // 
            this.btnChangeSalary.Location = new System.Drawing.Point(339, 452);
            this.btnChangeSalary.Name = "btnChangeSalary";
            this.btnChangeSalary.Size = new System.Drawing.Size(140, 28);
            this.btnChangeSalary.TabIndex = 2;
            this.btnChangeSalary.Text = "Change salary";
            this.btnChangeSalary.UseVisualStyleBackColor = true;
            this.btnChangeSalary.Click += new System.EventHandler(this.btnChangeSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee salary: ";
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(520, 449);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(140, 28);
            this.btnUpdateList.TabIndex = 4;
            this.btnUpdateList.Text = "Update list";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // ChangeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 541);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeSalary);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.listBoxSalaryChanger);
            this.Name = "ChangeSalaryForm";
            this.Text = "ChangeSalaryForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangeSalaryForm_FormClosed);
            this.Load += new System.EventHandler(this.ChangeSalaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSalaryChanger;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Button btnChangeSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateList;
    }
}