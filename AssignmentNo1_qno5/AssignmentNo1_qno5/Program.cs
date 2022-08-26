using System;

namespace AssignmentNo1_qno5
{
    class Program
    {
        static void listcheck()
        {
            int[] list = { 10, 20, 60, 40, 50 };
            int largest = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i]>largest)
                {
                    largest = list[i];
                }

            }
            
                Console.WriteLine("largest Number in the list is "+ largest);

           

        }

        static void Main(string[] args)
        {
            
            listcheck();
        }
    }
}
