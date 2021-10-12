using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voltron_assemble_interface.Weapons
{
    public class ArmCannon : IVoltronWeapon
    {
        public double Attack()
        {
            return 60;
        }
    }
}
