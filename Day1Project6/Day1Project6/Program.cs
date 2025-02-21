using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BaseCha = "기본 특성";
            const string BattleCha = "전투 특성";
            int Att = 16755, MaxHp = 78103, Cri = 36, Spe = 1017, Sub = 41;
            int Swi = 611, Pati = 22, Skill = 39;

            Console.WriteLine(BaseCha);
            Console.WriteLine(
                "공격력 :      {0}\n" + 
                "최대 생명력 : {1}\n",
                Att,MaxHp
                );
            Console.WriteLine(BattleCha);
            Console.WriteLine(
               "치명 :        {0}\n" +
               "특화 :        {1}\n" +
               "제압 :        {2}\n" +
               "신속 :        {3}\n" +
               "인내 :        {4}\n" +
               "숙련 :        {5}\n",
               Cri, Spe, Sub, Swi, Pati, Skill
               );
        }
    }
}
