using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator_strategy_patter
{
    public class Character : IAttackStrategy
    {
        private float currentHealth = 100;
        private IAttackStrategy attackStrategy ;

        public Character()
        {
            var _currentHealth = this.CurrentHealth;

        }

        public float CurrentHealth
        {
            get
            {
                return currentHealth;

            }
            set { this.currentHealth = value; }
        }


        public void Attack(Character other)

        {
            Execute(other);
        }

        private static  void Execute(Character character)
        {
            character.TakeDamage(damage);
        }

        //The TakeDamage method should reduce currentHealth by the passed value (to a minimum of zero)  and log the attack to the console.

        public void TakeDamage(float damage)
        {
            CurrentHealth -= damage;
        }

    }
}
