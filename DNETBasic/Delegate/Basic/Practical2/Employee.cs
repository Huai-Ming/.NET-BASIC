﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Basic.Practical2
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name,decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return string.Format("{0},{1:C}", Name, Salary);
        }

        public static bool CompareSalary(Employee e1, Employee e2)
        {
            return e1.Salary < e2.Salary;
        }
    }
}
