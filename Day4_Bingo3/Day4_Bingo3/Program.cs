using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Bingo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , ] board = new int[5, 5];
            bool[ , ] marked = new bool[5, 5];

            int bingoCount = 0;
            Random random = new Random();

            //빙고판 초기화
            int[] numbbers = new int[25];

            for (int i = 0; i < 25; i++) numbbers[i] = i + 1;

            //랜덤 섞기(Fisher-Yates Shuffle)
            for(int i=0;i<100;i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);
                //C# 튜플 문법
                (numbbers[a], numbbers[b]) = (numbbers[b], numbbers[a]);
            }

            //2차원 배열
            int index = 0;
            for(int i = 0; i<5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    board[i, j] = numbbers[index++];
                }
            }

            //게임 시작
            while(bingoCount<5)
            {
                Console.Clear();

                Console.WriteLine("현재 빙고판");

                for (int i =0; i<5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i,j])
                        {
                            Console.Write(" X ");
                        }
                        else
                        {
                            Console.Write($"{board[i,j], 2}");
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
