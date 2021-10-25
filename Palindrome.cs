using System;
using System.Collections.Generic;
using System.Text;

namespace Day8_Assignment
{
    class Palindrome
    {
        public void palindrome()
        {
             
            int rem, rev=0,num=0; int temp = num;
            Console.WriteLine("Enter the number");
             num = int.Parse(Console.ReadLine());

            while (temp != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = temp/ 10;


            }
            if (temp == rev)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not Palindrome");
            }
        }
        
    }
}
