using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Found
    {
        protected string name; 
        protected int credit; 

        public Found() { }

        public Found(string name, int sum)
        {
            this.name = name; credit = sum;
        }

        public virtual void VirtMethod()
        {
            Console.WriteLine("\nFather: " + this.ToString());
        }

        public override string ToString() 
        {
            return(String.Format($"Name = {name}, Credit = {credit}"));
        }

        public void NonVirtMethod()
        {
            Console.WriteLine("Mather: " + this.ToString());
        }

        public void Analysis()
        {
            Console.WriteLine("Common analysis");
        }

        public void Work()
        {
            VirtMethod(); NonVirtMethod(); Analysis();
        }
    }

    public class TestFound : Part
    {
        public override void Start()
        {
            OutExercise("Создать класс-родитель Found");

            Found found = new Found("None", 12000);
            found.Work();
            Console.WriteLine();
        }
    }
}

