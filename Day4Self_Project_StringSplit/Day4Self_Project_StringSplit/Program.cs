using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Self_Project_StringSplit
{
    class Program
    {
        //Stiroing
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력해 주세요!!(뛰어쓰기로 여러개 입력 가능!!");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            for (int i = 0; i< v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
           
            foreach (var i in v)
            {
                sum += int.Parse(i);
            }
            Console.WriteLine("결과는 {0}",sum);

            string userName = "hoyoung";
            string date = DateTime.Today.ToShortDateString();

            string str = $"Hello {userName}. Today is {date}";
            Console.WriteLine(str);

            decimal temp = 20.4m;
            string ss = String.Format("At {0}, the temperature is {1}C",DateTime.Now, temp);
            Console.WriteLine(ss);

            Console.WriteLine(String.Concat("I","am","a","boy"));

            string[] animals = { "mouse", "cow","tiger","rabbit","dragon"};
            string s2 = String.Concat(animals);
            Console.WriteLine(s2);
            s2 = String.Join(",", animals);
            Console.WriteLine(s2);



        }
    }
}
