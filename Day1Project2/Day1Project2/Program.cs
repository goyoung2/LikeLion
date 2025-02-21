using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요!");
            string name = Console.ReadLine();
            Console.Write("나이를 입력하세요!");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("키를 입력하세요.");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요.");
            Console.Write(name);
            Console.Write("님");

            Console.WriteLine("나이는" + age + "세, 키는" + height + "cm군요!" );
        }
    }
}
