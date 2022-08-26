using System;

namespace AssignmentNo1_qno4
{
    class Program
    {
        static void listcheck(int check_Number)
        {
            int[] list = { 10, 20, 30, 40, 50 };
            int y = 0;
            for (int i = 0; i < list.Length; i++)
            {
               y = list[i];
                if (check_Number == y)
                {
                    Console.WriteLine("Number is in the list");
                    break;
                }
                
            }
            if (check_Number != y)
            {
                Console.WriteLine("Number is not in the list");

            }


        }

        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Write any Number to be checked in a list !");
            Number = Convert.ToInt32(Console.ReadLine());
            listcheck(Number);
        }
    }
        
    
}
