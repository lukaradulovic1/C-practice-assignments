using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voltron_assemble_interface
{
    public class VoltronLeftLeg : IVoltronPart
    {
        public double Attack()
        {
            return 5;
        }

        public double Move()
        {
        return 10;
        }
    }
}
