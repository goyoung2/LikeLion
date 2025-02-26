using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iKor, iEng, iMath, sum = 0;
            float aver = 0.0f;

            Console.WriteLine("당신의 국어 점수를 입력하세요 : ");
            string input = Console.ReadLine();
            iKor = int.Parse(input);
            Console.WriteLine("당신의 영어 점수를 입력하세요 : ");
            input = Console.ReadLine();
            iEng = int.Parse(input);
            Console.WriteLine("당신의 수학 점수를 입력하세요 : ");
            input = Console.ReadLine();
            iMath = int.Parse(input);

            sum = iKor + iEng + iMath;
            aver = (float)sum / 3;
            Console.WriteLine("당신의 총 점수는 : " + sum);
            Console.WriteLine("당신의 평균 점수는 : " + aver.ToString("F2"));

            Console.WriteLine("임의의 정수를 입력하세요 : ");
            input = Console.ReadLine();
            Console.WriteLine("당신이 입력한 값은 : " + input);
            int ouput = int.Parse(input);
            Console.WriteLine("당신이 입력한 값의 비트  반전값은 : " + ~ouput);
        }
    }
}
