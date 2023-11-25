using Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Person
    {
        string fam = "", status = "", health = "";
        int age = 0, salary = 0;
        public string Fam
        {
            set { fam = value; }
            get { return (fam); }
        }
        public string Status
        {
            get { return (status); }
        }
        public int Age
        {
            set
            {
                age = value;
                if (age < 7) status = "ребенок";
                else if (age < 17) status = "школьник";
                else if (age < 22) status = "студент";
                else status = "служащий";
            }
            get { return (age); }
        }
        public int Salary
        {
            set { salary = value; }
        }

        const int Child_Max = 10;
        Person[] children = new Person[Child_Max];
        int count_children = 0;
        public Person this[int i]
        {
            get
            {
                if (i >= 0 && i < count_children) return (children[i]); else return (children[0]);
            }
            set
            {
                if (i == count_children && i < Child_Max) children[i] = value; count_children++;
            }
        }

        public class TestPersonChildren : Part
        {
            public override void Start()
            {
                OutExercise("Дополнить созданный ранее класс.");

                Person pers1 = new Person(), pers2 = new Person(); 
                pers1.Fam = "Петров"; 
                pers1.Age = 42;
                pers1.Salary = 10000; 
                pers1[pers1.count_children] = pers2; 
                pers2.Fam = "Петров"; 
                pers2.Age = 21; 
                pers2.Salary = 1000;
                Console.WriteLine("\nFam: " + pers1.Fam + "\nAge: " + pers1.Age + "\nStatus: " + pers1.Status);
                Console.WriteLine("\nSon: " + pers1[0].Fam + "\nAge: " + pers1[0].Age + "\nStatus: " + pers1[0].Status);
                Console.WriteLine();
            }
        }

        public class TestPersonProps : Part
        {
            public override void Start()
            {
                OutExercise("Изучить классы в C#.");

                Person pers1 = new Person();
                pers1.Fam = "Петров"; pers1.Age = 21; pers1.Salary = 1000;
                Console.WriteLine("\nFam: " + pers1.Fam + "\nAge: " + pers1.Age + "\nStatus: " + pers1.Status);
                pers1.Fam = "Иванов"; pers1.Age += 1;
                Console.WriteLine("\nFam: " + pers1.Fam + "\nAge: " + pers1.Age + "\nStatus: " + pers1.Status);
                Console.WriteLine();
            }
        }
    }
}

