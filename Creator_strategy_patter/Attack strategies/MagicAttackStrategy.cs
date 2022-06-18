using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator_strategy_patter
{
    public class MagicAttackStrategy : IAttackStrategy
    {
        public void Execute(Character other)
        {
            int damageInflicted = 50;
            other.TakeDamage(DamageType.Magic, damageInflicted);
        }
    }
}
