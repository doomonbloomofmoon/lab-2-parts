using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Derived : Found
    {
        protected int debet;

        public Derived() { }
        
        public Derived(string name, int cred, int deb) : base(name, cred) { debet = deb; }

        public void DerivedMethod() { Console.WriteLine("\nThis is a method of the Derived class"); }

        new public void Analysis() { Console.WriteLine("Complex analysis"); }

        public void Analysis(int level)
        {
            base.Analysis();
            Console.WriteLine("Depth Analysis: " + level);
        }

        public override string ToString() { return(string.Format($"Name = {name}, Credit = {credit}, Debet: {debet}")); }

        public override void VirtMethod() { Console.WriteLine("Son: " + this.ToString()); }
    }

    public class TestDerived : Part
    {
        public override void Start()
        {
            OutExercise("Создать класс-потомок Derived, переопределить методы.");

            Derived derived = new Derived("Example", 15000, 10500);
            derived.DerivedMethod();
            derived.VirtMethod();
            derived.Analysis();
            Console.WriteLine();
        }
    }
}

