namespace Web.Ej1
{
    public class Person
    {
        public string Name { get; set; }

        //constructor
        public Person(string name)
        {
            Name = name;
        }

        public string GetSaludo() 
        {
            return $"Hola! mi nombre es {Name}";
        }
    }
}
