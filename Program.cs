using static Lab_2.Person;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part[] parts =
            {
                new StructTester(),
                new TestPersonProps(),
                new TestPersonChildren(),
                new TestFound(),
                new TestDerived(),
                new TestClainTwo()
            };

            int count = 1;
            foreach (Part part in parts) 
            {
                Console.Write("Задание " + count + ". ");
                part.Start();
                ++count;
            }
        }
    }
}

