using System;

namespace PalindromeAndMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            if (IsPalindrome(name))
            {
                Console.WriteLine($"{name} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not palindrome.");
            }


        }


        public static bool IsPalindrome(string userString)
        {
            int j = userString.Length - 1; //sest hakkab pihta 0-st nt ANNA 0,1,2,3  4-1=3
            /*for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != userString[j])
                {
                    return false;
                }
                j--;
            }*/

            for (int i=0; i<= j/2+1; i++, j--)//i++ võtab vasakult paremale ja j-- võtab paremalt vasakule; kindlasti <= võrdsus märk!
                //j/2+1; nt ANNA jagab pooleks, mis teeb 1,5 (kunna array 3). ja C# ümmardab 1,5  1ni. siis peab pluss 1 panema, siis võtab järgmise ka
            {
                if (userString[i] != userString[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
