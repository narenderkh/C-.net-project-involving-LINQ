namespace SampleProgramDynamicLINQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            txtUserInput = new TextBox();
            button1 = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtSalary = new TextBox();
            txtDateOfBirth = new TextBox();
            cmbDepartment = new ComboBox();
            btnUpdate = new Button();
            txtEmpID = new TextBox();
            txFirstName = new TextBox();
            txLastName = new TextBox();
            txSalary = new TextBox();
            txtDOB = new TextBox();
            btnDelete = new Button();
            txEmpno = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(56, 58);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Location = new Point(37, 109);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(185, 23);
            txtUserInput.TabIndex = 1;
            txtUserInput.Text = "Enter Employee No";
            // 
            // button1
            // 
            button1.Location = new Point(271, 59);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 2;
            button1.Text = "btnInsert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnInsert;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(271, 109);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(151, 23);
            txtFirstName.TabIndex = 3;
            txtFirstName.Text = "Enter First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(271, 152);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 23);
            txtLastName.TabIndex = 4;
            txtLastName.Text = " Entre Last Name";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(271, 199);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(151, 23);
            txtSalary.TabIndex = 5;
            txtSalary.Text = "Enter Salary";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(271, 240);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(151, 23);
            txtDateOfBirth.TabIndex = 6;
            txtDateOfBirth.Text = "Enter DateOfBirth";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(311, 328);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(270, 23);
            cmbDepartment.TabIndex = 7;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(478, 59);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(478, 120);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(142, 23);
            txtEmpID.TabIndex = 9;
            txtEmpID.Text = "Enter Employee No";
            // 
            // txFirstName
            // 
            txFirstName.Location = new Point(476, 155);
            txFirstName.Name = "txFirstName";
            txFirstName.Size = new Size(143, 23);
            txFirstName.TabIndex = 10;
            txFirstName.Text = "Enter First Name";
            // 
            // txLastName
            // 
            txLastName.Location = new Point(474, 193);
            txLastName.Name = "txLastName";
            txLastName.Size = new Size(145, 23);
            txLastName.TabIndex = 11;
            txLastName.Text = "Enter Last Name";
            // 
            // txSalary
            // 
            txSalary.Location = new Point(474, 244);
            txSalary.Name = "txSalary";
            txSalary.Size = new Size(146, 23);
            txSalary.TabIndex = 12;
            txSalary.Text = "Entrer Salary";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(474, 289);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(146, 23);
            txtDOB.TabIndex = 13;
            txtDOB.Text = "Enter Date Of Birth";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(673, 57);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(210, 25);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txEmpno
            // 
            txEmpno.Location = new Point(665, 108);
            txEmpno.Name = "txEmpno";
            txEmpno.Size = new Size(220, 23);
            txEmpno.TabIndex = 15;
            txEmpno.Text = "Enter Employee No";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 450);
            Controls.Add(txEmpno);
            Controls.Add(btnDelete);
            Controls.Add(txtDOB);
            Controls.Add(txSalary);
            Controls.Add(txLastName);
            Controls.Add(txFirstName);
            Controls.Add(txtEmpID);
            Controls.Add(btnUpdate);
            Controls.Add(cmbDepartment);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtSalary);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(button1);
            Controls.Add(txtUserInput);
            Controls.Add(btnSubmit);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtUserInput;
        private Button button1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtSalary;
        private TextBox txtDateOfBirth;
        private ComboBox cmbDepartment;
        private Button btnUpdate;
        private TextBox txtEmpID;
        private TextBox txFirstName;
        private TextBox txLastName;
        private TextBox txSalary;
        private TextBox txtDOB;
        private Button btnDelete;
        private TextBox txEmpno;
    }
}
