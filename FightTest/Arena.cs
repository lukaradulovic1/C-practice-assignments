using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Arena
{
    List<Fighter> fighters = new();

    public void PrintFighterStats(Fighter fighter)
    {

        Console.WriteLine($"{fighter.Name} health is {fighter.HealthPoints} point(s)");
    }


    public void Fight(Fighter fighter, Fighter fighter2)
    {
        fighter.IsAttacking(fighter2);
        fighter.IsAttacking(fighter);
    }


}




