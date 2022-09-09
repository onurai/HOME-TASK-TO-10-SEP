using System;
using System.Collections.Generic;
using System.Text;

namespace HOME_TASK_TO_10_SEP
{
    class Task_6
    {
        static void Main()
        {
            Console.WriteLine("Please enter any year");

            int years;
            years = int.Parse(Console.ReadLine());

            if(years % 4 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }


    }
}
