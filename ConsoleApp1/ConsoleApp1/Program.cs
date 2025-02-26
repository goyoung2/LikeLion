using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("첫번째 임의의 정수를 입력해주세요!");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 임의의 정수를 입력해주세요!");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("세번째 임의의 정수를 입력해주세요!");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"가장 큰 숫자는 {a} 입니다!");
                }
                else
                {
                    Console.WriteLine($"가장 큰 숫자는 {c} 입니다!");
                }
            }
            else if (b > c)
            {
                Console.WriteLine($"가장 큰 숫자는 {b} 입니다!");
            }
            else
            {
                Console.WriteLine($"가장 큰 숫자는 {c} 입니다!");
            }
        }
    }
}
