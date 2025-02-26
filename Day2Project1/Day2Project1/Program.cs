using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("2진수를 입력하세요");
            string binaryInput = Console.ReadLine();
            int decimalValue = Convert.ToInt32(binaryInput, 2);

            string binaryOutput = Convert.ToString(decimalValue, 2);

            Console.WriteLine($"입력한 이진수는 {binaryInput}");
            Console.WriteLine($"10진수로 변환 {decimalValue}");
            Console.WriteLine($"더사 이진수로 변환 {binaryOutput}");*/

            // var를 사용하여 변수 선언
            var name = "Alice"; // 문자열로 추론
            var age = 25; // 정수로 추론
            var isStudent = true; // 논리값으로 추론
            Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");
            Console.WriteLine($"아룸의 타입 : {name.GetType()}");
            Console.WriteLine($"나이의 타입 : {age.GetType()}");
            Console.WriteLine($"학생여부의 타입 : {isStudent.GetType()}");

            // default 키워드를 사용한 기본값 설정
            int defaultInt = default; // 기본값: 0
            string defaultString = default; // 기본값: null
            bool defaultBool = default; // 기본값: false
            Console.WriteLine($"정수 기본값: {defaultInt}"); // 출력: 0
            Console.WriteLine($"문자열 기본값: {defaultString}"); // 출력: (null)
            Console.WriteLine($"논리값 기본값: {defaultBool}"); // 출력: False

            int a = 11, b = 3;
            int sum = a + b; // 산술 연산자 사용
            bool isEqual = (a == b); // 관계형 연산자 사용
            Console.WriteLine($"합: {sum}"); // 출력: 8
            Console.WriteLine($"a와 b가 같은가? {isEqual}"); // 출력: False

            int minus = a - b;
            Console.WriteLine($"차: {minus}");

            int multiple = a * b;
            Console.WriteLine($"곱: {multiple}");

            int divide = a / b;
            Console.WriteLine($"나누기: {divide}");

            int remain = a % b;
            Console.WriteLine($"나머지: {remain}");

            int number2 = 7;
            int check = 0;
            check = number2 % 2;
            bool checkOdd = check == 0;
            Console.WriteLine("숫자의 홀수 짝수 여부는 : " + checkOdd);


            int number = 5;
            Console.WriteLine(+number); // 양수 출력: 5
            Console.WriteLine(-number); // 음수 출력: -5
            bool flag = true;
            Console.WriteLine(!flag); // 논리 부정: False

            Console.WriteLine("5의 비트 반전은 : " + ~number);

            double pi = 3.14;
            int integerPi = (int)pi; 
            Console.WriteLine(integerPi);

            int iKor = 90;
            int iEng = 75;
            int iMath = 50;

            int sum2 = 0;
            float aver = 0.0f;

            sum2 = iKor + iEng + iMath;
            aver = (float)sum2 / 3;

            Console.WriteLine("총점은 : " + sum2);
            Console.WriteLine("평균은 : " + aver);

            string firstName = "Alice";
            string lastName = "Smith";
            Console.WriteLine(firstName + " " + lastName);


            int c = 10;
            c += 5; // c = c + 5
            Console.WriteLine(c);
            c -= 5;  // c  = c - 5;
            Console.WriteLine(c);
            c *= 5;  // c  = c * 5;
            Console.WriteLine(c);
            c /= 5;  // c  = c / 5;
            Console.WriteLine(c);
            c %= 5;  // c  = c % 5;
            Console.WriteLine(c);
        }
    }
}
