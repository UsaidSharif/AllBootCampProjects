using System;

namespace assignmentNo1_Bonus
{
    class Program
    {
        
        static void palindrome(string s)
        {
            string reverses = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverses += s[i].ToString();

            }
            if (reverses == s)
            {
                Console.WriteLine("String is Palindrome \nEntered String is {0}\nReverse String is {1}", s, reverses);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \nEntered String is {0}\nReverse String is {1}", s, reverses);
            }

        }
            static void Main(string[] args)
        {
            string str="";


            Console.WriteLine(" Enter any string");
            str = Console.ReadLine();
            str = str.ToLower();
            palindrome(str);
            Console.ReadKey();

        }
    }
}
