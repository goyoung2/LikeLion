using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_selfGame
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Horse
    {
        List<Horse> horses = new List<Horse>();
        int trackLength = Console.WindowWidth - 20;
        public char Symbol { get; set; }
        public int Position { get; set; }
        public int Speed { get; set; }  // 이동 속도 (랜덤값)
    }





}
