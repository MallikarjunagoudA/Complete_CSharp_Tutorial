using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntro
{
    public class ParentClassInheritance
    {
        public string name;
        public string email;
        public int age;

        public ParentClassInheritance(string message)
        {
            Console.WriteLine(message);
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"name : {name}, email : {email}, age : {age}");
        }
    }

    public class childClassPartTimeEmp : ParentClassInheritance
    {
       public childClassPartTimeEmp(): base("called directly by childClassPartTimeEmp  class")
        {
            Console.WriteLine("childClassPartTimeEmp costructor is called.");
        }
        public int hourlySalary;

    }

    public class childClassFullTimeEmp : ParentClassInheritance
    {
        public childClassFullTimeEmp() : base("called directly by childClassPartTimeEmp class")
        {
            Console.WriteLine("childClassFullTimeEmp costructor is called.");
        }
        public int yearlySalary;

    }
}
