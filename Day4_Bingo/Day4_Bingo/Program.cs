using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = new int[25];


            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }

            Random rand = new Random();
            //셔플

            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;


                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }

            int input = 0;
            int iBingo = 0;
            int iCount = 0;

            while (true)
            {
                Console.Clear();
                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (iArray[i * 5 + j] == 0)  //0일경우 체크
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("빙고 숫자는 ::" + iBingo );
                Console.Write("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;

                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }
                //빙고 체크 로직
                //가로 체크
                for (int i =0; i<5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (iArray[i*5+j]==0)
                        {
                            ++iCount;
                        }
                        if(iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }
                //세로 체크
                for (int i = 0; i < 5; ++i)
                {
                    for (int j = 0; j < 5; ++j)
                    {
                        if (iArray[i+5*j] == 0)
                        {
                            ++iCount;
                        }
                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }

                //대각선 왼쪽 체크
               /* for (int i = 0; i < 5; i = i*6 )
                {
                    if (iArray[i] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
               */
                for (int i = 0; i < 5; i = i++)
                {
                    if (iArray[i*6] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;


                //대삭선 오른쪽 체크
               /* for (int i = 1; i < 6; i = i * 4)
                {
                    if (iArray[i] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
               */
                for (int i = 0; i < 5; i = i++)
                {
                    if (iArray[i*4+4] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;

                if(iBingo >= 5)
                {
                    Console.WriteLine("빙고 완성!!");
                    break;
                }
            }



        }
    }
}