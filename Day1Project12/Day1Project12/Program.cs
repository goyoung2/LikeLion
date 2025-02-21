using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue, y = 0;
            Console.WriteLine("int.MaxValue = " + x);
            checked
            {
                try
                {
                    y = x + 10;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("int.MaxValue + 10 = {0}", y);


            //===========================================
            /*int x = int.MaxValue, y = 0;

            Console.WriteLine("int.MaxValue = " + x);
            y = x + 10;
            Console.WriteLine("int.MaxValue + 10 = {0}", y);*/

            //==========================================
            /* int x = 10, y = 0;

             try
             {
                 Console.WriteLine(x / y);
             }
             catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }*/
        }
    }
}
