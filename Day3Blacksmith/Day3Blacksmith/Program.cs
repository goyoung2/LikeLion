using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day3Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            int scene = 0;
            int inpuut = 0;
            int money = 0;

            int target = 0;


            int s = 0, ss = 0, sss = 0;
            Random rand = new Random();

            Console.WriteLine("대장장이 키우기");

            while (true)
            {
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력 : ");
                inpuut = int.Parse(Console.ReadLine());
                
                switch (inpuut)
                {
                    case 1:
                        Console.WriteLine("나무캐기 ");

                        break;
                    case 2:
                        Console.WriteLine("####장비 뽑기#### ");
                        Console.WriteLine("1.1회 뽑기 :: 100G    2. 2회 뽑기 :: 900G");
                        int sel = int.Parse(Console.ReadLine());
                        switch(sel)
                        {
                            case 1:
                                if (money < 100)
                                {
                                    Console.WriteLine("돈이 부족합니다!");
                                    break;
                                }
                                else
                                {
                                    for (int i = 0; i < 1; i++)
                                    {
                                        int randomnumber = rand.Next(0, 100);
                                        target = randomnumber;
                                        if (target < 2)
                                        {
                                            Console.WriteLine("SSR급 도끼 획득!");
                                            sss += 1;
                                        }
                                        else if (target >= 2 && target < 20)
                                        {
                                            Console.WriteLine("SR급 도끼 획득!");
                                            ss += 1;
                                        }
                                        else
                                        {
                                            Console.WriteLine("R급 도끼 획득!");
                                            s += 1;
                                        }
                                        Thread.Sleep(50);
                                    }
                                    break;
                                }
                            case 2:
                                if (money < 100)
                                {
                                    Console.WriteLine("돈이 부족합니다!");
                                    break;
                                }
                                else
                                {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        int randomnumber = rand.Next(0, 100);
                                        target = randomnumber;
                                        if (target < 2)
                                        {
                                            Console.WriteLine("SSR급 도끼 획득!");
                                            sss += 1;
                                        }
                                        else if (target >= 2 && target < 20)
                                        {
                                            Console.WriteLine("SR급 도끼 획득!");
                                            ss += 1;
                                        }
                                        else
                                        {
                                            Console.WriteLine("R급 도끼 획득!");
                                            s += 1;
                                        }
                                        Thread.Sleep(50);
                                    }
                                    break;
                                }
                        }

                        for (int i = 0; i < 100; i++)
                        {
                            int randomnumber = rand.Next(0, 100);
                            target = randomnumber;
                            if (target < 2)
                            {
                                Console.WriteLine("SSR급 도끼 획득!");
                                sss += 1;
                            }
                            else if (target >= 2 && target < 20)
                            {
                                Console.WriteLine("SR급 도끼 획득!");
                                ss += 1;
                            }
                            else
                            {
                                Console.WriteLine("R급 도끼 획득!");
                                s += 1;
                            }
                            Thread.Sleep(50);
                        }
                        break;
                    case 3:
                        Console.WriteLine("나가기 ");
                        break;
                }
                
            }
        }
        
    }
}
