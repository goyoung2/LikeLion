using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("학점을 입력해주세요");
            score = int.Parse(Console.ReadLine());
            if (score >= 90)
            {

            }else if (score<90 && score >=80)
            {
                Console.WriteLine("학생의 학점은 A!");
            }
            else if (score < 90 && score >= 80)
            {
                Console.WriteLine("학생의 학점은 B!");
            }
            else if (score < 80 && score >= 70)
            {
                Console.WriteLine("학생의 학점은 C!");
            }
            else if (score < 70 && score >= 60)
            {
                Console.WriteLine("학생의 학점은 D!");
            }
            else
            {
                Console.WriteLine("학생의 학점은 F!");
            }
        }
    }
}
