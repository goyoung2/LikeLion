using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study11
{
    class Program
    {

        //1단계함수
        //반환형 함수이름 (매개변수)
        //{
        //}
        //1단계 기본형
        static void Loading()
        {

            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은  :: " + _Attack);
        }
        static int BaseAttack()
        {
            int attack = 10;

            return attack;
        }

        static int Add(int a, int b)
        {
            int sum;
            sum = a + b;
            return (sum);

        }


        static void Main(string[] args)
        {/*

            Loading();

            Console.WriteLine("게임이 시작됩니다.");
            Console.ReadLine();

            int Attack = 0;
            int bAttack = 0;

            Console.WriteLine("캐릭터의 공격력을 입력 :: ");
            Attack = int.Parse(Console.ReadLine());

            bAttack = BaseAttack();

            AttackFunction(bAttack + Attack);

            */
            //두수를 더하는 함수 만들어서 오류를 해결하세요.
             int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");
        }
    }
}