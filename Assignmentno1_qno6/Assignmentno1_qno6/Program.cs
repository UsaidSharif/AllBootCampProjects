using System;

namespace Assignmentno1_qno6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number you want a table of !");
            int Number = Convert.ToInt32(Console.ReadLine());
            int z = 0;
            Console.WriteLine("Table of " + Number + " is");
            for (int i = 0; i < 11; i++)
            {
                z=Number* i;
                Console.WriteLine(Number +" * "+ i+" = "+ z);

            }
        }
    }
}
