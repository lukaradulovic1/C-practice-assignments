using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ant_mover_program.Ant_body_parts.AntThorax;
using ant_mover_program.Ant_body_parts;
namespace ant_mover_program
{
    public class Ant
    {
        private readonly AntHead head;
        private readonly AntThorax thorax;
        private readonly AntAbdomen abdomen;

        public Ant(AntHead head, AntAbdomen abdomen, AntThorax thorax)
        {
            this.head = head;
            this.abdomen = abdomen;
            this.thorax = thorax;

        }

        public void Walk()
        {
            thorax.MoveLegs();
        }



    }
}
