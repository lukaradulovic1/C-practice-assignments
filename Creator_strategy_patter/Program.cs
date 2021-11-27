using System;

namespace Creator_strategy_patter
{
    class Program
    {
        static void Main(string[] args)
        {
            var knight = new Character();
            var ranger = new Character();

            knight.Attack(ranger);

        }
    }
}
