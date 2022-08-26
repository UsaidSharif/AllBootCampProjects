using System;

namespace AssignmentNo1_qno8
{
    class Program
    {
        static void NumisPrimeOrNot(int Number)
        {

            if (Number == 0 || Number == 1)
            {
                Console.WriteLine(Number + " is not prime number");
            }
            else
            {
                for (int i = 2; i <= Number / 2; i++)
                {
                    if (Number % i == 0)
                    {
                        Console.WriteLine(Number + " is not prime number");
                        return ;
                    }

                }
            }
            Console.WriteLine(Number + " is a prime number");
        }

        static void Main(string[] args)
        {
            int Number;
            bool condition;
            condition = true;
            while (condition)
            {
                Console.WriteLine("Write any Number to be checked if it is prime or not !");
                Number = Convert.ToInt32(Console.ReadLine());
                NumisPrimeOrNot(Number);
                Console.WriteLine("Do you want to restart or end ? press r for restart and any letter for end ");
                char x = Console.ReadLine()[0];
                if(x!= 'r')
                {
                    condition = false;
                }
                else
                {
                    condition = true;
                }
            }
            

        }
    }
}


