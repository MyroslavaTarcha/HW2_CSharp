using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_logic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer between {0} and {1},please.\n",Int32.MinValue,Int32.MaxValue);
            Int32 number = Convert.ToInt32(Console.ReadLine());

            //Відомо, що у парних чисел молодший біт має значення 0
            //Спосіб 1: робимо зсув числа на 31 (Int32 це 32 біти) біт вліво, якщо це парне число, то результуюче число повинно дорівнювати нулю

            Int32 b = number << 31;            
            if (b == 0)
            {
                Console.WriteLine("It is the even number.\n");
            }
            else
            {
                Console.WriteLine("It isn't the even number\n");
            }

            //Спосіб 2: остача ділення парного числа на 2 дорівнює 0, перевіряємо це

            Int32 c = number % 2;
            if (c == 0)
            {
                Console.WriteLine("It is really the even number");
            }
            else
            {
                Console.WriteLine("It isn't the even number, frankly");
            }
            Console.ReadLine();
        }
    }
}
