using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Conditions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number,please!\n");
            double number = Convert.ToDouble(Console.ReadLine());
            Int32[] A = {0,15,35,50,100 };
            if(number<A[0] || number>A[4])
            {
                Console.WriteLine("The input number is not between 0 and 100");
                Console.ReadLine();
                return;
            }
            if (number / A[2] >= 1)
            {
                if (number / A[3] >= 1)
                {
                    Console.WriteLine("The input number is not between {0} and {1}",A[3]+1,A[4]);
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("The input number is not between {0} and {1}", A[2]+1, A[3]);
                    Console.ReadLine();
                    return;
                }
            }
            else
            {
                if (number / A[1] <= 1)
                {
                    Console.WriteLine("The input number is not between {0} and {1}", A[0], A[1]-1);
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("The input number is not between {0} and {1}", A[1], A[2]);
                    Console.ReadLine();
                    return;
                }
            }

            
        }
    }
}
