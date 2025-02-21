using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 30;
            Console.WriteLine($"a ={a}, b={b}, c={c}");

            const double Pi = 3.14159;
            const int MaxScore = 100;
            Console.WriteLine($"Pi = {Pi}, MaxScore = {MaxScore}");

            Console.Clear();

            Console.WriteLine("형식지정자를 요약합니다.");
            Console.WriteLine(
                "(C) Currncy(통화) : ------------------------------{0:C}\n" +
                "(D) Decimal(십진수 (정수)) : ---------------------{0:D}\n" +
                "(E) Scientific(지수 (과학)) : --------------------{1:E}\n" +
                "(F) Fixed point(고정자릿수) : --------------------{0:F}\n" +
                "(G) General(일반) : ------------------------------{0:G}\n" +
                "(N) Number(천단위 구분 기호 숫자) : --------------{0:N}\n" +
                "(P) Percent(퍼센트) : ----------------------------{1:P}\n" +
                "(R) Round-trip(라운드트립) : ---------------------{1:R}\n" +
                "(X) Hexadecimal(16진수) : ------------------------{0:X}\n", 
                -123645678,-1234.5678f
                );




        }
    }
}
