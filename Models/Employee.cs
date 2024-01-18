using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_fixacao.Models
{
    public class Employee
    {
        public double Salary {get ; private set; } 
        public int Id {get ; private set; }
          
        public string Name { get ; private set; }
        

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }
    

        public void IncreaseSlary (double percentage) {
            Salary += Salary * (percentage / 100);
           }

        public override string ToString()
        {
            return Id + "," + Name + "," +  Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    }
