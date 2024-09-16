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

        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(5,5));
        Console.WriteLine(calculator.Subtract(3,2));
        Console.WriteLine(calculator.Multiply(5,5));
        Console.WriteLine(calculator.Divide(3,0));
        Console.WriteLine(calculator.Add(10,24));
    }
}
