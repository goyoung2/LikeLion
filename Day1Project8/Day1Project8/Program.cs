using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello world";
            string name = "Alice";
            Console.WriteLine(greeting +" "+ name);

            Console.WriteLine("나이를 입력하세요");
            string input2 = Console.ReadLine();
            int age = int.Parse(input2);
            Console.WriteLine($"내년에는 {age + 1} 살이 됩니다.");

            string input;
            int value;

            Console.WriteLine("1. int로 변환할 문자열을 입력하세요.");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result)
            {
                Console.WriteLine(result);
                Console.WriteLine("'{0}'는 int로 변활 될 수 없습니다. \n", input);
            }
            else
            {
                Console.WriteLine(result);
                Console.WriteLine("int '{0}' 으로 변환되었습니다 \n",value);
            }

            Console.Write("2. double로 변환할 문자열을 입력하세요,");
            input = Console.ReadLine();
            try
            {
                double m = double.Parse(input); //double m = Convert.ToDouble(input);
                Console.WriteLine("double '{0}'으로 변환되었습니다. \n",m);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
