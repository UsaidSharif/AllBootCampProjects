using System;

namespace Assignmentno1_qno7
{
    class Program
    {
        static void oddlist()
        {
            int[] list = { 10, 20, 30, 40, 50, 60, 70 };
            
            Console.WriteLine("Odd Numbers in the list are ");

            for (int i = 0; i < list.Length; i++)
            {
                if(i % 2 == 1)
                {
                    int y=list[i];
                    Console.WriteLine(y);

                
                }
               
            }

            


        }

        static void Main(string[] args)
        {

            oddlist();
        }
    }
}
