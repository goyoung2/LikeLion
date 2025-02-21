using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project11
{
    class Program
    {
        static void Main(string[] args)
        {
            double ruinDmg, cardGauge, ultDmg, moveSpd, vehicleSpd, ConvSpd, skillCoolDownTime;
            int maxMana, manaRecBattle, manaRecNonBattle;
            Console.WriteLine("루인 스킬 피해를 입력해주세요.");
            ruinDmg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("카드 게이지 획득량를 입력해주세요.");
            cardGauge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("각성기 피해량를 입력해주세요.");
            ultDmg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("최대 마나를 입력해주세요.");
            maxMana = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("전투 중 마나 회복량를 입력해주세요.");
            manaRecBattle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("비전투 중 마나 회복량를 입력해주세요.");
            manaRecNonBattle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("이동 속도를 입력해주세요.");
            moveSpd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("탈 것 속도를 입력해주세요.");
            vehicleSpd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("운반 속도를 입력해주세요.");
            ConvSpd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("스킬 재사용 대기시간 감소를 입력해주세요.");
            skillCoolDownTime = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓▼");
            Console.WriteLine("활동");
            Console.WriteLine("루인 스킬 피해 :　　　　　　　 {0}%", ruinDmg);
            Console.WriteLine("카드 게이지 획득량 : 　　　　　{0}%", cardGauge);
            Console.WriteLine("각성기 피해 : 　　　　　　　　 {0}%", ultDmg);
            Console.WriteLine("최대 마나 : 　　　　　　　　　 {0}", maxMana);
            Console.WriteLine("전투 중 마나 회복량 : 　　　　 {0}", manaRecBattle);
            Console.WriteLine("비전투 중 마나 회복량 : 　　　 {0}", manaRecNonBattle);
            Console.WriteLine("이동 속도 : 　　　　　　　　　 {0}%", moveSpd);
            Console.WriteLine("탈 것 속도 : 　　　　　　　　　{0}%", vehicleSpd);
            Console.WriteLine("운반 속도 : 　　　　　　　　　 {0}%", ConvSpd);
            Console.WriteLine("스킬 재사용 대기시간 감소 : 　 {0}%", skillCoolDownTime);
            Console.WriteLine("〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓〓");
        }
    }
}
