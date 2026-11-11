using Microsoft.EntityFrameworkCore;

namespace SampleProgramDynamicLINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EfdemoDbContext context = new EfdemoDbContext();
        private void btnSubmit_Click(object sender, EventArgs e)
        {


            var emid = txtUserInput.Text;
            var empid = int.Parse(string.IsNullOrWhiteSpace(emid) ? "0" : emid);
            

            var empl = context.Employees.FromSql($"select * from employee where EmpID= {empid} "); 
            string empstr = " ";
            foreach (var emp in empl)
                empstr += emp.EmpId + " " + emp.FirstName + " " + emp.LastName + " " + emp.Salary + " " + emp.DeptId + " " + "\n";
            MessageBox.Show(empstr);
            context.Dispose();
        }



        private void btnInsert(object sender, EventArgs e)
        {
            String FirstName = txtFirstName.Text;
            String LastName = txtLastName.Text;
            Decimal Salary = decimal.Parse(txtSalary.Text);
            String DateOfBirth = txtDateOfBirth.Text;
            



            int DeptID = (int)cmbDepartment.SelectedValue;

            int rowsaffected = context.Database.ExecuteSql($"Insert into employee(FirstName, LastName, Salary, DateOfBirth, DeptId) values (  {FirstName},{LastName},{Salary},{DateTime.Parse(DateOfBirth)},{DeptID} )");

            MessageBox.Show(" The Row inserted successfully ");
            context.Dispose();
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartment.DisplayMember = "DeptName";
            cmbDepartment.ValueMember = "DeptId";
            cmbDepartment.DataSource = context.Departments.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(txtEmpID.Text);
            string FirstName = txFirstName.Text;
            string LastName = txLastName.Text;
            Decimal SalaryM = decimal.Parse(txSalary.Text);
            DateTime DateOfBirth = DateTime.Parse(txtDOB.Text);
            int Deptid = (int)cmbDepartment.SelectedValue;

            

            var empl = context.Database.ExecuteSql($"update employee set FirstName= {FirstName}, LastName= {LastName}, salary = {SalaryM},DateOfBirth= {DateOfBirth} ,DeptId={Deptid} where empId = {empno}");
            MessageBox.Show(" The Row updated successfully ");
            context.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(txEmpno.Text);
            context.Database.ExecuteSql($"delete from employee where EmpID= {empno}");
            MessageBox.Show(" The Row deeleted successfully ");
            context.Dispose(); 
        }
    }
}
