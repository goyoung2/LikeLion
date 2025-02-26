using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project7
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c = 0f;
            char op = default;
            Console.WriteLine("두 개의 숫자와 연산자를 입력해주세요!!");
            Console.WriteLine("첫 번째 숫자는? :: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자는? :: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("계산하고 싶은 연산자는? :: ");
            op = char.Parse(Console.ReadLine());
            if (op == '+')
            {
                c =  (a + b);
                Console.WriteLine($"결과 ::{c}");
            }
            else if(op == '-')
            {
                c = a - b;
                Console.WriteLine($"결과 ::{c}");
            }
            else if(op == '*')
            {
                c = a * b;
                Console.WriteLine($"결과 ::{c}");
            }
            else if(op == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("예외처리 0으로 나누려고 했습니다!");
                }
                else
                {
                    c = a / b;
                    Console.WriteLine($"결과 ::{c}");
                }
            }
            else
            {
                Console.WriteLine("잘못된 연산 기호를 입력했습니다!");
            }
        }
    }
}
