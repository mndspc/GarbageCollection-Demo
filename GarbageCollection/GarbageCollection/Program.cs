using System;


namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();

            using (Employee employee = new Employee())
            {

            }
                Console.ReadLine();
        }
    }
}
