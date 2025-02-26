using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x = 5, y = 10;
             Console.WriteLine(x < y); 
             Console.WriteLine(x == y);
             Console.WriteLine(x < y);   
             Console.WriteLine(x > y);  
             Console.WriteLine(x >= y);
             Console.WriteLine(x <= y);

             bool a = true, b = false;
             Console.WriteLine(a && b); 
             Console.WriteLine(a || b); 
             Console.WriteLine(!a);

             b = !a;

             Console.WriteLine(b);*/
            /*
                        int x = 5; // 0101
                        int y = 3; // 0011 

                        Console.WriteLine(x & y); //AND : 1 (0001)
                        Console.WriteLine(x | y); //OR : 7 (0111)
                        Console.WriteLine(x ^ y); //XOR :6   (0110)
                        Console.WriteLine(~x);    //NOT : -6 

                        int value = 4; // 0100
                        Console.WriteLine(value << 1); // 8
                        Console.WriteLine(value >> 1); // 2

                        int a = 10, b = 20;
                        int max;

                        max = (a < b) ? a : b; //삼항 연산자
                        Console.WriteLine(max);


                        int key = 1;
                        string str;
                        str = (key == 2) ? "문이열렸습니다." : "문을 못열었습니다.";

                        Console.WriteLine(str);


                        int result = 10 + 2 * 5; //곱셈이 덧셈보다 우선
                        Console.WriteLine(result);

                        int adjustedResult = (10 + 2) * 5; //괄호 우선순위 먼저계산

                        Console.WriteLine(adjustedResult);

                        int score = 85;
                        if (score >= 90)
                        {
                            Console.WriteLine("A 학점");
                        }
                        else
                        {
                            Console.WriteLine("90점 미만");
                        }

                        string GameID = "멋사검존";


                        if (GameID == "멋사검존")
                        {
                            Console.WriteLine("아이디가 일치합니다.");
                        }
                        else
                        {
                            Console.WriteLine("아이디가 일치하지 않습니다.");
                        }

                        score = 60;

                        if (score >= 90)
                        {
                            Console.WriteLine("A 학점");
                        }
                        else if (score >= 80)
                        {
                            Console.WriteLine("B 학점");
                        }
                        else if (score >= 70)
                        {
                            Console.WriteLine("C 학점");
                        }
                        else
                        {
                            Console.WriteLine("F 학점");
                        }*/

            int money =0, atk = 100, plusAtk = 0;
            string name = "멋사검존";
            string weapon = default;
            string swd_inf = "무한의 대검", swd_kanata = "카타나", swd_jin = "진은검", 
                   swd_howse = "집판검", swd_ex="엑스칼리버", swd_ghost="유령검", swd_leg="전설의검";

            Console.WriteLine("가지고 있는 소지금을 입력하세요 : " );
            money = int.Parse(Console.ReadLine());
            if (money <=100 && money >=0)
            {
                Console.WriteLine($"{swd_inf} 획득!!");
                weapon = swd_inf;
                plusAtk += 1;
            }
            else if (money>=101 && money <= 200 )
            {
                Console.WriteLine($"{swd_kanata} 획득!!");
                weapon = swd_kanata;
                plusAtk += 2;
            }
            else if (money >= 201 && money <= 300)
            {
                Console.WriteLine($"{swd_jin} 획득!!");
                weapon = swd_jin;
                plusAtk += 3;
            }
            else if (money >= 301 && money <= 400)
            {
                Console.WriteLine($"{swd_howse} 획득!!");
                weapon = swd_howse;
                plusAtk += 4;
            }
            else if (money >= 401 && money <= 500)
            {
                Console.WriteLine($"{swd_ex} 획득!!");
                weapon = swd_ex;
                plusAtk += 5;
            }
            else if (money >= 501 && money <= 600)
            {
                Console.WriteLine($"{swd_ghost} 획득!!");
                weapon = swd_ghost;
                plusAtk += 6;
            }
            else
            {
                Console.WriteLine($"{swd_leg} 획득!!");
                weapon = swd_leg;
                plusAtk += 7;
            }
            //Console.Clear();
             Console.WriteLine($" 캐릭터 이름 : {name} \n 장착 무기 : {weapon} \n 공격력 : {atk} + {plusAtk}");
        }
    }
}
