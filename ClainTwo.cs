using Lab_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public interface IProps
    {
        void Prop1(string s);
        void Prop2(string name, int val); void Prop3();
    }
    public interface IPropsOne
    {
        void Prop1(string s);
        void Prop2(int val); void Prop3();
    }
    public class ClainTwo : IProps, IPropsOne
    {
        public void Prop1(string s) { Console.WriteLine(s); }
        public void Prop2(string s, int x) { Console.WriteLine(s + x); }
        public void Prop2(int x) { Console.WriteLine(x); }
        void IProps.Prop3() { Console.WriteLine("\nMethod 3 Interface 1"); }
        void IPropsOne.Prop3() { Console.WriteLine("\nMethod 3 Interface 2"); }
        public void Prop3FromInterface1() { ((IProps)this).Prop3(); }
        public void Prop3FromInterface2() { ((IPropsOne)this).Prop3(); }
    }

    public class TestClainTwo : Part
    {
        public override void Start()
        {
            OutExercise("Опробовать коллизию имен.");
            
            ClainTwo claintwo = new ClainTwo();
            claintwo.Prop1("\nGluing properties of two interfaces"); 
            claintwo.Prop2("Overload: ", 99); 
            claintwo.Prop2(9999);
            claintwo.Prop3FromInterface1(); 
            claintwo.Prop3FromInterface2();
            Console.WriteLine("\nThe interface object calls the methods of the 1st interface!");

            IProps ip1 = (IProps)claintwo; 
            ip1.Prop1("\nIProps interface: property 1"); 
            ip1.Prop3();
            Console.WriteLine("\nThe interface object calls the methods of the 2nd interface!");
            IPropsOne ip2 = (IPropsOne)claintwo; 
            ip2.Prop1("\nIPropsOne interface: property 1"); 
            ip2.Prop3();
        }
    }
}

