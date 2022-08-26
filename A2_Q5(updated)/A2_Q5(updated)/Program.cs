using System;

namespace A2_Q5_updated_
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, l;
            Console.WriteLine("Write Number of elements to be entered in an array!");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] terms = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Write elements to be entered in an array!");
                int value = Convert.ToInt32(Console.ReadLine());
                terms[i] = value;
            }

            Console.WriteLine("Array you made is\n ");

            for (int m = 0; m < Number; m++)
            {
                Console.Write(" " + terms[m] + "\n");
            }


            for (k = 0; k < Number; k++)
            {
                for (l = k + 1; l < Number; l++)
                {
                    if (terms[k] != terms[k + 1])
                    {
                        if (terms[k] == terms[l])
                        {
                            Console.Write("The duplicate element is: {0} \n", terms[k]);
                            break;
                        }
                    }
                }

            }



        }
    }
}
