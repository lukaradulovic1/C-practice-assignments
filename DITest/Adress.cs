namespace DITest
{
    public class Adress
    {
        private string adressInfo;

        public Adress(string adressInfo)
        {
            AdressInfo = adressInfo;
            
        }

        public string AdressInfo
        {
            get
            {
                return this.adressInfo;
            }
            set 
            { 
                this.adressInfo = value; 
            }

        }
        public override string ToString()
        {
            return this.adressInfo;
        }
    }
}