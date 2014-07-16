using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //будуємо рівносторонній трикутник. довжина сторони а=18, висота h=16.
           //відповідно, будуючи рівняння прямих, що є сторонами такого трикутника, получаємо наступні нерівності для самого трикутника:
           // y>(144-16x)/9; y>(16x-144)/9; y<16;
            Console.WriteLine("The equilateral triangle\n");
            for (int i = 0; i <= 18; i++)
            {
                for (int j = 0; j <= 16; j++)
                {
                    if (j >= (144 - 16 * i) / 9 && j >= (16 * i - 144) / 9)
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            //Будуємо прямокутний трикутник.
            Console.WriteLine("The right triangle\n");
            for (int i = 0; i <= 18; i++)
            {
                for (int j = 0; j <= 16; j++)
                {
                    if (j <= (144 - 16 * i) / 9 )
                    {
                        Console.Write("*");
                        continue;
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }

            //Квадрат є частковим випадком ромба =)

            Console.WriteLine("The rhombus\n");


            for (int i = 0; i <= 18; i++)
            {
                for (int j = 0; j <= 18; j++)
                {
                    
                        Console.Write("* ");
                        
                    
                }
                Console.Write("\n");
            }

            Console.WriteLine("The rectangle\n");


            for (int i = 0; i <= 18; i++)
            {
                for (int j = 0; j <= 30; j++)
                {

                    Console.Write("* ");


                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
