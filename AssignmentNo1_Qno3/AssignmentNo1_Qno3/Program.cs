using System;

namespace AssignmentNo1_Qno3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;
            Console.WriteLine("Write Number1 !");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Number2 !");
            Number2 = Convert.ToInt32(Console.ReadLine());

            int Sum = Number1 + Number2;

            Console.WriteLine("Sum is "+ Sum);
            
        }
    }
}
