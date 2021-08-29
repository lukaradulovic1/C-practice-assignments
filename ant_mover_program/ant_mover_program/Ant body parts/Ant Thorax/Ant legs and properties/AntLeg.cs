using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ant_mover_program.Ant_body_parts.AntThorax
{
    public class AntLeg
    {
        private readonly AntLegId id;
        private AntLegPosition position;


        public AntLeg(AntLegId id, AntLegPosition position)
        {
            this.id = id;
            this.position = position;
        }

        public void Move()
        {
            if (position == AntLegPosition.Back)
            {
                position = AntLegPosition.Forward;
                Console.WriteLine($"Ants {id} moves {position} now");
            }

            else if (position == AntLegPosition.Forward)
            {
                position = AntLegPosition.Back;
                Console.WriteLine($"Ants {id} moves {position} now");
            }
        }




    }
}
