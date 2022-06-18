using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator_strategy_patter
{
    public class Character
    {
        private float currentHealth = 100;
        private IAttackStrategy attackStrategy;

        public Character(IAttackStrategy attackStrategy)
        {
            this.attackStrategy = attackStrategy;
        }

        public void Attack(Character other)
{
            attackStrategy.Execute(other);
        }

        public float ShowCurrentHealth()
        {
            return  currentHealth;
        }

        //The TakeDamage method should reduce currentHealth by the passed value (to a minimum of zero)  and log the attack to the console.

        public void TakeDamage(DamageType damageType, float damage)
        {
            if (damage >= currentHealth)
            {
                currentHealth = 0;
                Console.WriteLine("Your character has died.");
            }
            else
            {
                currentHealth -= damage;
                Console.WriteLine($"Character has taken {damageType} damage of {damage} points!");
            }
            
        }

    }
}
