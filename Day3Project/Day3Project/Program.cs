using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day3Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int day = 6;

             switch (day)
             {
                 case 1:
                     Console.WriteLine("월요일");
                     break;
                 case 2:
                     Console.WriteLine("화요일");
                     break;
                 case 3:
                     Console.WriteLine("수요일");
                     break;
                 case 4:
                     Console.WriteLine("목요일");
                     break;
                 case 5:
                     Console.WriteLine("금요일");
                     break;
                 default:
                     Console.WriteLine("주말입니다.");
                     break;
             }*/
            /*int select = 1;
            Console.WriteLine("캐릭터를 선택해 주세요! (1~3) ::");
            select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.WriteLine("직업 : 검사 \n 공격력 : 100 \n 방어력 90");
                    break;
                case 2:
                    Console.WriteLine("직업 : 마법사 \n 공격력 : 110 \n 방어력 80");
                    break;
                case 3:
                    Console.WriteLine("직업 : 도적 \n 공격력 : 115 \n 방어력 70");
                    break;
                default:
                    Console.WriteLine("선택 범위를 벗어났습니다!");
                    break;
            }
*/
            /*int sum = 0;
            for (int i =1; i <11; i++)
            {
              //  Console.WriteLine("숫자 : " + i);
                sum = sum + i;
                
            }
            Console.WriteLine("숫자 : " + sum);*/
            /*int i = 1;
            while (i>0)
            {
                Console.WriteLine(i);
                i += i;
                if ( i > 500)
                {
                    Console.WriteLine("목표값 달성!");
                    break;
                }

            }*/

            Random rand = new Random();

            /*for (int i=0;i<10;i++)
            {
                int randomnumber = rand.Next(0, 10);
                Console.WriteLine(randomnumber);

            }*/

            int target = 0;
            int s=0, ss=0, sss = 0;
            for(int i = 0; i<100; i++)
            {
                int randomnumber = rand.Next(0, 100);
                target = randomnumber;
                if (target < 10)
                {
                    Console.WriteLine("SSS급 도끼 획득!");
                    sss += 1; 
                }
                else if (target >= 10 && target < 50)
                {
                    Console.WriteLine("SS급 도끼 획득!");
                    ss += 1;
                }
                else
                {
                    Console.WriteLine("S급 도끼 획득!");
                    s += 1;
                }
                Thread.Sleep(50);
            }
            Console.WriteLine($"S급 :: {s} SS급 :: {ss} SSS급 :: {sss}");
            float sum = s + ss + sss;
            float aver = sss / sum; 
            Console.WriteLine($"SSS급 확률 :: {aver}");


            //break 문
            //반복문을 탈출할수있다.

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("브레이크!!");
                    break;
                }


                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue;
                Console.WriteLine(i); // 홀수만 출력
            }

        }





    }
}
