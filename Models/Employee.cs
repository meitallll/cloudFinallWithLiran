using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloudFinal.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }     
        public string LastName { get; set; }            
        public string Role { get; set; }           
        public int Salary { get; set; }
        public override string ToString()
        {
            string empDataStr = string.Empty;

            empDataStr += "\n\n[Employee]";

            if (string.IsNullOrEmpty(Id))
                empDataStr += "\nThere is no employee ID documented at the moment.";
            else
                empDataStr += "\nEmployee ID: " + Id;

            if (string.IsNullOrEmpty(FirstName))
                empDataStr += "\nThere is no first name documented at the moment.";
            else
                empDataStr += "\nFirst name: " + FirstName;

            if (string.IsNullOrEmpty(LastName))
                empDataStr += "\nThere is no last name documented at the moment.";
            else
                empDataStr += "\nLast name: " + LastName;

            if (string.IsNullOrEmpty(Role))
                empDataStr += "\nThere is no role documented at the moment.";
            else
                empDataStr += "\nRole: " + Role;

            if (Salary == 0)
                empDataStr += "\nThere is no salary documented at the moment.";
            else
                empDataStr += "\nSalary: " + Salary;

            return empDataStr;
        }

    }
}
