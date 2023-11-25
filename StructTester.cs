using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    enum EmpType : byte
    {
        Grunt = 1, VP = 9, Manager = 10, Contractor = 100
    }

    struct Employee
    {
        public short deptID;
        public EmpType title;
        public string name;

        public Employee(EmpType t, string n)
        {
            this.deptID = (short) t; this.title = t; this.name = n; 
        }
    }

    class StructTester : Part
    {
        public override void Start()
        {
            OutExercise("Познакомиться со структурами в C#.");

            Employee fred;
            fred.deptID = 123; fred.title = EmpType.Grunt; fred.name = "Fred";

            Employee ben = new Employee(EmpType.VP, "Ben");

            Employee[] employees = { fred, ben };

            foreach (Employee employee in employees)
            {
                Console.WriteLine("\nName: " + employee.name + "\nTitle: " + employee.title + "\ndeptID: " + employee.deptID);
            }
            Console.WriteLine();
        }
    }
}

