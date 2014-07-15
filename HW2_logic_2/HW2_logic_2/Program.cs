using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_logic_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x = 5, y = 10, and z = 15\n");
            Int32 x = 5, y = 10, z = 15;
            Console.WriteLine("x += y >> x++ * z\n");
            Int32 result = (x += y >> x++ * z);
            Console.WriteLine(result);
            Console.WriteLine("\nz = ++x & y * 5\n");
            result = (z = ++x & y * 5);
            Console.WriteLine(result);
            Console.WriteLine("\ny /= x + 5 | z\n");
            result = (y /= x + 5 | z);
            Console.WriteLine(result);
            Console.WriteLine("\nz = x++ & y * 5\n");
            result = (z = x++ & y * 5);
            Console.WriteLine(result);
            Console.WriteLine("\nx = y << x++ ^ z\n");
            result = (x = y << x++ ^ z);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
