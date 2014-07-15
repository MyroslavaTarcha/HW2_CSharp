using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW2_Cinditions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputkey;
            do
            {
            Console.WriteLine("\tConsole calculator\nInput two numbers for calculating, please.\n");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You input {0} and {1}\nEnter please one of the following arithmetic operations +,-,*,/\n", operand1, operand2);
            string sign=Convert.ToString(Console.ReadLine());
            double result = 0;
            switch (sign)
                {
                    case "+": result = operand1 + operand2; break;
                    case "-": result = operand1 - operand2; break;
                    case "*": result = operand1 * operand2; break;
                    case "/": if (operand2 != 0)
                            {
                                result = operand1 / operand2; break;
                            }
                            else
                            {
                                Console.WriteLine("Dividing by zero is not possible\n"); break;
                            }
                }
            Console.WriteLine("Result = {0} \n", result);
            Console.WriteLine("Do you want continue? (Enter YES or NO)\n");
            outputkey=Convert.ToString(Console.ReadLine());            
            }
            while (outputkey=="YES");
            
        }
    }
}
