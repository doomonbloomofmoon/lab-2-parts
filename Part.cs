using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Part
    {
        public void OutExercise(string s)
        {
            Console.WriteLine(s);
        }
        public abstract void Start();
    }
}

