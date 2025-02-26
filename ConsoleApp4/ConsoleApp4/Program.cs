using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 배열 요소 출력
            int[] a = new int[] { 10, 20, 30, 40, 50 };         
            foreach (int item in a) Console.WriteLine(item);
            
            //2. 배열 요소 합 구하기
            int[] numbers = new int[5];
            int sum = 0;

            Console.WriteLine("정수 5개를 입력하세요.");
            for (int i = 0; i<5; i++)
            {
                Console.Write($"{i+1}번째 정수 입력 :: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach (int num in numbers) sum += num;

            Console.WriteLine($"총 합계는 :: {sum}");
            
            //3. 최대값 찾기
            Console.WriteLine("최대값 찾기");
            int[] numbers2 = new int[] { 3, 8, 15, 6, 2 };
            int highNum = 0;
            
            foreach (int num in numbers2) if (num > highNum) highNum = num;
          
            Console.WriteLine($"배열 중 가장 큰 값은 :: {highNum}");
            
            
            //4. 1부터 10까지 출력 (for문)
            Console.WriteLine("for문을 이용한 1~10까지 출력");
            for (int i = 0; i < 10; i++) Console.Write(i+1+" ");
            
            
            //5. 짝수만 출력 (while문)
            Console.WriteLine("while문을 이용한 1~10 중 짝수만 출력");
            int evenNum = 2;
            while (evenNum<=10)
            {
                Console.Write(evenNum + " ");
                evenNum += 2;
            }
            
            //6. 배열 요소 출력(foreach문)
            Console.WriteLine("foreach문을 이용한 배열 요소 출력");
            int[] number3 = new int[] {1,2,3,4,5};
            foreach (int t in number3) Console.Write(t + " ");

            
            //7. 두 수의 합을 구하는 함수
            Console.WriteLine("정수 2개를 입력하세요.");
            Console.Write("첫 번째 정수 ::");
            int d = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 ::");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine(PlusFungtion(d,e));
            
            //8. 문자열 길이 반환 함수
            Console.WriteLine("임의의 문자열을 입력하세요.");
            string str = Console.ReadLine();
            Console.WriteLine(LengthString(str));

            
            //9. 가장 큰 수 반환 함수
            Console.WriteLine("정수 3개를 입력하세요.");
            Console.Write("첫 번째 정수 ::");
            int f = int.Parse(Console.ReadLine());
            Console.Write("두 번째 정수 ::");
            int g = int.Parse(Console.ReadLine());
            Console.Write("세 번째 정수 ::");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine(MaxNumber(f, g, h));
        }
        static int PlusFungtion(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static int LengthString(string a)
        {
            int leng = 0;
            leng = a.Length;
            return leng;
        }


        static int MaxNumber(int a, int b, int c)
        {
            int[] numbers = new int[] { a, b, c };
            int MaxNum = 0;

            foreach (int num in numbers) if (num > MaxNum) MaxNum = num;

            return MaxNum;
        }
    }
}
