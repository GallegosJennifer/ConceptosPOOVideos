using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceptos_POO
{
    public class CommissionEmployee : Employees
    {
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\t Commission percentaje:{$"{CommissionPercentaje:P2}",18}" +
                $"\n\t Sales................:{$"{Sales:C2}",18}" +
                $"\n\t Value to pay.........:{$"{GetValueToPay():C2}",18}";
        }
    }

}
