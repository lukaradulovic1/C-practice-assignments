using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Define interface VoltronPart which declares methods Move() returning distance and Attack() returning damage.
namespace voltron_assemble_interface
{
    interface IVoltronPart
    {
        public double Move();

        public double Attack();
    }
}
