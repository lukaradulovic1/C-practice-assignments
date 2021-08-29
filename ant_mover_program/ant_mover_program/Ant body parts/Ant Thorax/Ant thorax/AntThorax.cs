using ant_mover_program.Ant_body_parts.AntThorax;
using System.Collections.Generic;

namespace ant_mover_program
{
    public class AntThorax
    {
        private readonly List<AntLeg> legs = new();
        public void AddLegToThorax()
        {


            //left side legs
            var frontLegLeft = new AntLeg(AntLegId.FrontLeft, AntLegPosition.Back);

            var midLegLeft = new AntLeg(AntLegId.MidLeft, AntLegPosition.Forward);

            var rearLegLeft = new AntLeg(AntLegId.RearLeft, AntLegPosition.Back);

            //right side legs
            var frontLegRight = new AntLeg(AntLegId.FrontRight, AntLegPosition.Forward);

            var midLegRight = new AntLeg(AntLegId.MidRight, AntLegPosition.Back);

            var rearLegRight = new AntLeg(AntLegId.RearRight, AntLegPosition.Forward);


            legs.Add(frontLegLeft);
            legs.Add(frontLegRight);
            legs.Add(midLegLeft);
            legs.Add(midLegRight);
            legs.Add(rearLegLeft);
            legs.Add(rearLegRight);
        }
        

        
        public void MoveLegs()
        {
            foreach (var leg in legs)
            {
                leg.Move();
                
            }

        }



    }
}
