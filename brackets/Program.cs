using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string:");
            string text = Console.ReadLine();
            int n = text.Length;

            int openingbrackets = 0;
            int closingbrackets = 0;

            for (int i = 0; i < n; i++)
            { char a = text[i];
                if (a == '(' && openingbrackets>=closingbrackets) openingbrackets++;
                if (a == ')') closingbrackets++;
            }
            
            if (openingbrackets == closingbrackets) Console.WriteLine("The parentheses (round brackets) are placed right");
            else Console.WriteLine("The parentheses (round brackets) are placed wrong");
            Console.ReadLine();
        }
    }
}
