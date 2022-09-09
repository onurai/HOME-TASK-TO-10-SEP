using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HOME_TASK_TO_10_SEP
{
    class Task_5
    {
        static void Main()
        {
            string str1;
            Console.Write("");
            str1 = Console.ReadLine();

            var strnew = WordFilt(str1);
            Console.WriteLine(" ");
            foreach (string str2 in strnew)
            {
                Console.WriteLine(str2);
            }
            if (str1 == " ")
                Console.WriteLine("Please enter a string");


        }
        static IEnumerable<string> WordFilt(string mystr)
        {
            var upperword = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));

            return upperword;
        }

    }
}

