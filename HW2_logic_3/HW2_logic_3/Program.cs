using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_logic_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your salary and the work experience (in year),please!\n");
            double salary = Convert.ToDouble(Console.ReadLine());
            Int32 experianse = Convert.ToInt32(Console.ReadLine());
            
            double[] Bonus = { 0.1, 0.15, 0.25, 0.35, 0.45, 0.5};
            Int32 num = experianse / 5;
            if (num < 0)
            {
                Console.WriteLine("Wrong experience");
                Console.ReadLine();
                return;
            }
            if (num > 5)
            {
                Console.WriteLine("Your bonus is {0}",salary*Bonus[5]);
                Console.ReadLine();
                return;
            }
            switch (num)
            {
                case 0: Console.WriteLine("Your bonus is {0}", salary * Bonus[0]);
                        Console.ReadLine();
                        return;
                case 1: Console.WriteLine("Your bonus is {0}", salary * Bonus[1]);
                        Console.ReadLine();
                        return;
                case 2: Console.WriteLine("Your bonus is {0}", salary * Bonus[2]);
                        Console.ReadLine();
                        return;
                case 3: Console.WriteLine("Your bonus is {0}", salary * Bonus[3]);
                        Console.ReadLine();
                        return;
                case 4: Console.WriteLine("Your bonus is {0}", salary * Bonus[4]);
                        Console.ReadLine();
                        return;
            }
        }
    }
}
