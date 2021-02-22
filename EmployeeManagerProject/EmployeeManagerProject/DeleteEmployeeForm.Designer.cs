
namespace EmployeeManagerProject
{
    partial class DeleteEmployeeForm
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
            this.listBoxDeleteEmployee = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPinSearch = new System.Windows.Forms.TextBox();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDeleteEmployee
            // 
            this.listBoxDeleteEmployee.FormattingEnabled = true;
            this.listBoxDeleteEmployee.Location = new System.Drawing.Point(33, 46);
            this.listBoxDeleteEmployee.Name = "listBoxDeleteEmployee";
            this.listBoxDeleteEmployee.Size = new System.Drawing.Size(550, 342);
            this.listBoxDeleteEmployee.TabIndex = 0;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(70, 394);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "Delete Employee";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search employee by PIN here ->";
            // 
            // tbPinSearch
            // 
            this.tbPinSearch.Location = new System.Drawing.Point(218, 12);
            this.tbPinSearch.Name = "tbPinSearch";
            this.tbPinSearch.Size = new System.Drawing.Size(100, 20);
            this.tbPinSearch.TabIndex = 3;
            this.tbPinSearch.TextChanged += new System.EventHandler(this.tbPinSearch_TextChanged);
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(192, 394);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateList.TabIndex = 4;
            this.btnUpdateList.Text = "Update list";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 445);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.tbPinSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.listBoxDeleteEmployee);
            this.Name = "DeleteEmployeeForm";
            this.Text = "DeleteEmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteEmployeeForm_FormClosed);
            this.Load += new System.EventHandler(this.DeleteEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDeleteEmployee;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPinSearch;
        private System.Windows.Forms.Button btnUpdateList;
    }
}