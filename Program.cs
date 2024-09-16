namespace KH_CS_OOP;
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John Doe";
        person.Age = 32;
        List<string> interests = new List<string>(){
            "Watching TV ",
            "Programming "
        };
        person.Interests = interests;
        person.BetterGreeting();
    }
}
