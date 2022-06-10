using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Doctor : Job
    {
        //properties
        public string Name { get; set; }
        public string Occupation { get; set; }
        public decimal Salary { get; set; } 
        public int Tax { get; set; } //constructor


        //constructor
        public Doctor(string name, string occupation, decimal salary, int tax)
        {
            Name = name;
            Occupation = occupation;
            Salary = salary;
            Tax = tax;
        }


        //method

        public string WhoAmI()
        {
            return $"{Name} is a {Occupation} Salary : {Salary} Bath  Tax : {Tax}";
        }

        public decimal GetTax()
        {
            return (Salary * Tax) / 100;
        }
    }
}
