using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_loops_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //так як про типи чисел нічого не сказано, то я вибираю інти
            Console.WriteLine("Input two integers A and B (A<B)");
            Int32 A = Convert.ToInt32(Console.ReadLine());
            Int32 B = Convert.ToInt32(Console.ReadLine());
            if (B <= A)
            {
                Console.WriteLine("{0}>={1} it is wrong",A,B);
                return;
            }
            if (B-A<=1)
            {
                Console.WriteLine("Between {0} and {1} it is not any integers",A,B);
                return;
            }
            // Рахуємо суму арифметичної прогресії для чисел між А і В не включаючи самих чисел А і В
            Int32 sum = 0;
            sum = (B - 1 + A + 1) * (B - 1 - A - 1 + 1) / 2;
            Console.WriteLine("Sum of integers between {0} and {1} is {2}\n",A,B,sum);
            Int32 mod = A % 2;
            Int32 firstnum;
            if (mod == 0)
            {
                firstnum = A + 1;
            }
            else
            {
                firstnum = A + 2;
            }
            Console.WriteLine("Between {0} and {1} it is this odd integers:", A, B);
            for (int i = firstnum; i < B; i = i + 2)
            {
                Console.WriteLine("{0}  ",i);
            }
            Console.ReadLine();
            return;
        }
    }
}
