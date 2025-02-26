using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1차원 배열 선언 
             
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            int[] num2 = new int[] { 1, 2, 3 };
            int[] num3 = { 100, 200, 300 };

            string[] fruits = new string[] { "사과", "배", "수박" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"1번 배열은 {i + 1} 번쨰 값: " + num[i]);
                Console.WriteLine($"2번 배열은 {i + 1} 번쨰 값: " + num2[i]);
                Console.WriteLine($"3번 배열은 {i + 1} 번쨰 값: " + num3[i]);
                Console.WriteLine($"4번 배열은 {i + 1}번째 값 : " + fruits[i]);
            }

            int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMath = new int[3];

            int[] sum = new int[3];
            float[] aver = new float[3];
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i+1}번 학생의 성적 입력하세요.");
                Console.Write("국어 :  ");
                iKor[i] =int.Parse(Console.ReadLine());
                Console.Write("영어 :  ");
                iEng[i] = int.Parse(Console.ReadLine());
                Console.Write("수학 :  ");
                iMath[i] = int.Parse(Console.ReadLine());
                sum[i] = iKor[i] + iEng[i] + iMath[i];
                aver[i] = (float)sum[i] / 3;
                Console.WriteLine($"{i + 1}번학생 국어 :: {iKor[i]} 영어 :: {iEng[i]} 수학 :: {iMath[i]}");
                Console.WriteLine($"{i+1}번학생 총점 :: " + sum[i]);
                Console.WriteLine($"{i + 1}번학생  :: " + aver[i].ToString("F2"));
            }
            */

            //배열 길이

            /*
            int[] scores = new int[3];
            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;

            for (int i = 0; i<scores.Length; i++)
            {
                Console.WriteLine($"점수 {i+1} :: " + scores[i]);
            }
            //포맷팅

            double value = 123000555.4567890;
            Console.WriteLine(value);
            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째 자리 :: {value:F2}" );
            Console.WriteLine(string.Format("소수점 셋째 자리 :: {0:F3}",value));

            Console.WriteLine(value.ToString("N2"));
            */

            //2차원 배열
            /*
            int[,] matrix = new int[2, 3] { { 1,2,3},{4,5,6 } };
            for(int i =0; i<3;i++)
            {
                for(int j = 0; j<4;j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
            }*/
            //실제 배열 크기: 2행(0~1) × 3열(0~2)
            //오류 발생: i = 2 또는 j = 3 접근 시 IndexOutOfRangeException 발생

            int[,] matrix2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            // 행의 길이: matrix.GetLength(0) → 2
            // 열의 길이: matrix.GetLength(1) → 3
            for (int i = 0; i < matrix2.GetLength(0); i++)  // 2번 반복 (i = 0, 1)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)  // 3번 반복 (j = 0, 1, 2)
                {
                    Console.WriteLine($"[{i} , {j}]번 배열의 값은 :: " + matrix2[i, j]);
                }
            }
            //가변 배열
            //내부 배열 미초기화:
            //matrix3는** 가변 배열(Jagged Array) * *로, 외부 배열만 생성되었을 뿐 내부 배열이 초기화되지 않았습니다.
            
            int[][] matrix3 = new int[3][];

            matrix3[0] = new int[4];  // 0번 행: 4개 요소 내부 배열 초기화!!
            matrix3[1] = new int[4];  // 1번 행: 4개 요소
            matrix3[2] = new int[4];  // 2번 행: 4개 요소 

            matrix3[0][0] = 10;
            matrix3[0][1] = 20;
            matrix3[0][2] = 30;
            matrix3[0][3] = 40;

            matrix3[1][0] = 50;
            matrix3[1][1] = 60;
            matrix3[1][2] = 70;
            matrix3[1][3] = 80;

            for (int i = 0; i < matrix3.Length; i++)  // 2번 반복 (i = 0, 1)
            {
                for (int j = 0; j < matrix3[i].Length; j++)  // 3번 반복 (j = 0, 1, 2)
                {
                    Console.WriteLine($"[{i} , {j}]번 배열의 값은 :: " + matrix3[i][j]);
                }
            }

            int[] iArray = new int[25];

            for (int i = 0; i< iArray.Length; i++)
            {
                iArray[i] = i +  1;
                Console.WriteLine($"{i+1}번째 배열의 값은 ::" + iArray[i]);
            }

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(iArray[i*5+j].ToString("D2")+" ");
                }
                Console.WriteLine();
            }

            //스왑
            int a = 10;
            int b = 20;
            int t = 0;
            t = a;
            a = b;
            b = t;
            Console.WriteLine("a : " + a + " b :" + b);

            //셔플

            Random rand = new Random();
            for (int i = 0; i<100; i++)
            {
                int iA = rand.Next(0, iArray.Length);
                int iB = rand.Next(0, iArray.Length);
                int iT = 0;

                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }

            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                }
                Console.WriteLine();
            }
            */
            Console.Clear();

            int input = 0;


            while(true)
            {
                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            Console.Write(" *");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                }
            }

            Console.WriteLine("숫자를 입력하세요.");
            input = int.Parse(Console.ReadLine());

            for(int i = 0; i<25; i++)
            {
                if (iArray[i] == input)
                {
                    iArray[i] = 0;
                    break;
                }
            }
        }
    }
}
