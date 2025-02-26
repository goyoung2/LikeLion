using System;

class Program
{
    static int playerHP = 100;
    static int enemyHP = 100;

    static void Battle()
    {
        // 게임 종료 조건 체크
        if (playerHP <= 0 || enemyHP <= 0)
        {
            Console.WriteLine(playerHP > 0 ? "🎉 승리!" : "💀 패배...");
            return;
        }

        // 플레이어 턴
        Console.WriteLine($"내 체력: {playerHP}, 적 체력: {enemyHP}");
        Console.Write("공격 방법 (1:검, 2:마법): ");

        switch (Console.ReadLine())
        {
            case "1":
                enemyHP -= new Random().Next(10, 20);
                Console.WriteLine("⚔️ 검 공격 성공!");
                break;
            case "2":
                enemyHP -= new Random().Next(15, 25);
                playerHP -= 5; // 마법 반동
                Console.WriteLine("🔮 마법 역작용!");
                break;
        }

        // 적 턴
        if (new Random().Next(2) == 0)
        {
            playerHP -= new Random().Next(8, 15);
            Console.WriteLine("👾 적의 반격!");
        }

        Battle(); // 재귀 호출로 다음 턴 진행
    }

    static void Main()
    {
        Battle(); // 게임 시작
    }
}