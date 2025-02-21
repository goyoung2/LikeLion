using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project7
{
    class Program
    {
        static void Main(string[] args)
        {
            float flt = 1f/3;
            double dbl = 1d/3;
            decimal dcm = 1m/3;

            Console.WriteLine($"Float : {flt}\n Double : {dbl} \n decimal : {dcm}");
            Console.WriteLine($"Float : {sizeof(float)} bytes\n Double : {sizeof(double)} bytes\n decimal : {sizeof(decimal)} bytes");
            Console.WriteLine("Float : {0} ~ {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Double : {0} ~ {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Decimal : {0} ~ {1}", decimal.MinValue, decimal.MaxValue);

            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine(num);

            double x = 1234.5;
            int a;

            a = (int)x;
            Console.WriteLine(a);

            Console.WriteLine(
                $"sbyte : {sizeof(sbyte)} \n short : {sizeof(short)} \n int : {sizeof(int)} \n" +
                $"long : {sizeof(long)} \nbyte : {sizeof(byte)} \nushort : {sizeof(ushort)} \n" +
                $"uint : {sizeof(uint)} \nulong : {sizeof(ulong)}"
                );
        }
    }
}
