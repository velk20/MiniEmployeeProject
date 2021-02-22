
namespace EmployeeManagerProject
{
    partial class EmployeesInformation
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
            this.lbEmplyeesInformation = new System.Windows.Forms.ListBox();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmplyeesInformation
            // 
            this.lbEmplyeesInformation.FormattingEnabled = true;
            this.lbEmplyeesInformation.Location = new System.Drawing.Point(37, 12);
            this.lbEmplyeesInformation.Name = "lbEmplyeesInformation";
            this.lbEmplyeesInformation.Size = new System.Drawing.Size(709, 355);
            this.lbEmplyeesInformation.TabIndex = 0;
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(92, 383);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(151, 33);
            this.btnUpdateList.TabIndex = 1;
            this.btnUpdateList.Text = "Update list";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // EmployeesInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.lbEmplyeesInformation);
            this.Name = "EmployeesInformation";
            this.Text = "EmployeesInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesInformation_FormClosed);
            this.Load += new System.EventHandler(this.EmployeesInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmplyeesInformation;
        private System.Windows.Forms.Button btnUpdateList;
    }
}