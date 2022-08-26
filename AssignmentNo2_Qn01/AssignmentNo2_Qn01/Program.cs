using System;

namespace AssignmentNo2_Qn01
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int sum = 0;
            int product = 1;
            Console.WriteLine("Write Number of elements to be entered in an array!");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] terms = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Write elements to be entered in an array!");
                int value = Convert.ToInt32(Console.ReadLine());
                terms[i] = value;
            }
            Console.WriteLine("Array you made is\n " );
            foreach (int str in terms)
                Console.Write(" "+str);

            for (int j = 0; j < Number; j++)
            {
                //Console.Write(" "+terms[j]);
                sum = terms[j]+ sum;
                product = terms[j] * product;
            }
            Console.WriteLine("\nSum of array is\n "+ sum);
            Console.WriteLine("\nProduct of array is\n " + product);

        }
    }
}
