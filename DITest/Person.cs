namespace DITest
{
    public class Person
    {
        private string name;
        private int age;
        private Adress adress;

        public Person(string name, int age, Adress adress)
        {
            this.name = name;
            this.age = age;
            this.adress = adress;
        }
        public override string ToString()
        {
            return $"Persons name is {name}, age: {age}, adress: {adress.ToString()}";
        }
    }
}
