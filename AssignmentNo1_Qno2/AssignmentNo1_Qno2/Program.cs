using System;

namespace AssignmentNo1_Qno2
{
    class Program
    {
        static void NumisEvenOrOdd()
        {
            int Number;
            Console.WriteLine("Write any Number !");
            Number = Convert.ToInt32(Console.ReadLine());
            int Remainder = Number % 2;

            if (Remainder == 1)
            {
                Console.WriteLine("Number is Odd");
            }
            else
            {
                Console.WriteLine("Number is Even");
            }
        }
        static void Main(string[] args)
        {
            NumisEvenOrOdd();
        }
    }
}
