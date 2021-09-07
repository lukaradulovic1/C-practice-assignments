
namespace Weapons
{
    public class Sword
    {
        private int damage;
        
        public Sword()
        {
            this.damage = 10;
        }
        public int Damage 
        {
            get 
            { 
                return damage; 
            }
            
            private set
            {
                this.damage = value;
            } 
        }
    }
}
