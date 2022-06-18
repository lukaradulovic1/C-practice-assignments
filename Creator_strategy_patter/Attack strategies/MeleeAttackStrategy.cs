using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator_strategy_patter
{
    public class MeleeAttackStrategy : IAttackStrategy
    {
        public void Execute(Character other)
        {
            int damageInflicted = 15;
            other.TakeDamage(DamageType.Melee, damageInflicted);
        }
    }
}
