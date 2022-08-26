using System;

namespace AssignmentNo1_Qno9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern By multiple Prints ");
            Console.WriteLine("*\n" +
                "**\n" +
                "***\n" +
                "****\n" +
                "*****\n");
            Console.WriteLine("Pattern By For Loop ");
            for(int i=0; i<5; i++)
            {
                
                
                for (int y=0; y<=i; y++)
                {
                    
                    Console.Write("*");

                }
                Console.Write("\n");
            }
        }
    }
}
