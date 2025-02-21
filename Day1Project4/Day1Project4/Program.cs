using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            double att = 56.7;
            string chaName = "ullari";
            char rank = 'S';

            Console.WriteLine("HP는" + hp);
            Console.WriteLine("공격력은" + att);
            Console.WriteLine("캐릭터 이름은" + chaName);
            Console.WriteLine("등급은" + rank);

            int i;
            double x;

            i = 5;
            x = 3.12351;
            Console.WriteLine("i = " + i + ", x = " + x);

            x = i;
            i = (int)x;
            Console.WriteLine("i = " + i + ", x = " + x);

            Console.WriteLine("10이하의 소수 : {0},{1},{2},{3}", 2, 3, 5, 7);
            string prims;
            prims = string.Format("10이하의 소수 : {0},{1},{2},{3}", 2, 3, 5, 7);
            Console.WriteLine(primsS);

            int v1 = 200;
            double v2 = 1.2345;
            Console.WriteLine("vi = " + v1 + ", v2 = " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}",v1,v2);
            Console.WriteLine($"v1 = {v1}, v2= {v2}");

        }
    }
}
