using System;



class Program
{

    static void Main()
    {
        Arena arena = new Arena();
        Fighter firstDude = new Fighter(100, 10, "Fedor");
        Fighter secondDude = new Fighter(100, 30, "Cain Velasques");

        bool someoneLost = false;


        arena.PrintFighterStats(firstDude);
        arena.PrintFighterStats(secondDude);
        while (firstDude.HealthPoints > 0)
        {
            arena.Fight(firstDude, secondDude);

        }
        
    }
}

