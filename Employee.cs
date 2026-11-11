using System;
using System.Collections.Generic;

namespace SampleProgramDynamicLINQ;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public decimal Salary { get; set; }

    public DateOnly DateofBirth { get; set; }

    public int DeptId { get; set; }

    public virtual Department Dept { get; set; } = null!;
}
