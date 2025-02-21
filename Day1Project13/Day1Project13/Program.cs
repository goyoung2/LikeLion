using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int first = 10, second = 20;

            result = (first == second);
            Console.WriteLine("{0} == {1} : {2}",first,second,result);

            result = (first > second);
            Console.WriteLine("{0} > {1} : {2}", first, second, result);

            result = (first < second);
            Console.WriteLine("{0} < {1} : {2}", first, second, result);

            result = (first >= second);
            Console.WriteLine("{0} >= {1} : {2}", first, second, result);

            result = (first <= second);
            Console.WriteLine("{0} <= {1} : {2}", first, second, result);

            result = (first != second);
            Console.WriteLine("{0} != {1} : {2}", first, second, result);

            result = (first == second) || (first > 5);
            Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

            result = (first == second) && (first > 5);
            Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

            result = (first == second) ^ (first > 5);
            Console.WriteLine("{0} ^ {1} : {2}", first == second, first > 5, result);

            result = !(first > second);
            Console.WriteLine("!{0} : {1}", first > second, result);

            int x = 14, y = 11, z;
            z = x | y;
            Console.WriteLine("{0}|{1} = {2}", x,y,z);

            z = x & y;
            Console.WriteLine("{0}&{1} = {2}", x, y, z);

            z = x ^ y;
            Console.WriteLine("{0}^{1} = {2}", x, y, z);

            z = ~x;
            Console.WriteLine("~{0} ^ {1} = {2}", x, y, z);

            z = x <<2 ;
            Console.WriteLine("{0}<< 2 = {1}", x, z);

            z = y >> 1;
            Console.WriteLine("{0}>> 1 = {1}", y, z);

        }
    }
}
