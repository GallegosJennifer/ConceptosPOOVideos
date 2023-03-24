using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos_POO
{
    public class SalaryEmpleyee : Employees
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Value to pay: {$"{GetValueToPay():C2}",15}";
        }
    }
}
