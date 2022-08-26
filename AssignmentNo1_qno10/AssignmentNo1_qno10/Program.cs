using System;

namespace AssignmentNo1_qno10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Pattern By For Loop ");
            for (int i = 1; i <= 5; i++)
            {


                for (int y = 1; y <= i; y++)
                {

                    Console.Write(y);

                }
                Console.Write("\n");
            }
        }
    }
}
