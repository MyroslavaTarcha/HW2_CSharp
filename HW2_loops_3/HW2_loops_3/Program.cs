using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_loops_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a count of clients (integer > 0)");
            Int32 N=Convert.ToInt32(Console.ReadLine());
            if (N <= 0)
            {
                Console.WriteLine("{0} <= 0, it is wrong",N);
                return;
            }
            Int32 fakt = 1;
            for (int i = 2; i <= N; i++)
            {
                fakt *= i;
            }
            Console.WriteLine("There is {0} a possible route of delivery!",fakt);
            Console.ReadLine();
        }
    }
}
