namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your name?");

        string? name = Console.ReadLine();

        Console.WriteLine($"I am going to touch you, {name}");

        Console.WriteLine("Are you scared?");

        Console.ReadLine();

        Console.WriteLine($"You should be...");
    }
}
