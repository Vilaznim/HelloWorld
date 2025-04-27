namespace HelloWorld;

class Program
{
    //Day 2
    static void Main(string[] args) {
        int a = 5, b = 10;
        Console.WriteLine(a);
        Console.WriteLine(b);

        //Swap a and b without a third variable
        Console.WriteLine("Swapping a and b values");
        (a, b) = (b, a);
        
        Console.WriteLine(a);
        Console.WriteLine(b);

        float c = 4.5f, d = 7.1f;
        Console.WriteLine(c);
        Console.WriteLine(d);

        char e = 'A', f = 'Z';
        Console.WriteLine(e);
        Console.WriteLine(f);

        bool isValid = true, isInvalid = false;
        Console.WriteLine(isValid);
        Console.WriteLine(isInvalid);

        string g = "Maren", h = "William";
        Console.WriteLine(g);
        Console.WriteLine(h);

        object obj = 123;
        Console.WriteLine(obj);

        var guess = 42;
        Console.WriteLine(guess);

        //Celsius to Fahrenheit
        Console.WriteLine("What is the temperature in Fahrenheit?");
        Console.Write("Write a number in Celsius!");
        string? temp = Console.ReadLine();

        if (!double.TryParse(temp, out double celsius)){
            Console.WriteLine("Whoops, that's not a valid number. Try an actual number!");
            return;
        }

        double fahrenheit = celsius * 9.0 / 5.0 + 32;
        Console.WriteLine($"{celsius}C = {fahrenheit}F");

    }
}