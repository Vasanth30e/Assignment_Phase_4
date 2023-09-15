using Calc;

public class Program
{
    public static void Main(String[] args)
    {
        Arithmatic arithmatic = new Arithmatic();
        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Add two numbers");

        Console.WriteLine("Result: " + arithmatic.Add(12, 12));

        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Subtract two numbers");

        Console.WriteLine("Result: " + arithmatic.Sub(12, 12));

        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Multiply two numbers");

        Console.WriteLine("Result: " + arithmatic.Mul(12, 12));

        Console.WriteLine("Arithmetic Operations");
        Console.WriteLine("Divide two numbers");

        Console.WriteLine("Result: " + arithmatic.Div(12, 12));
    }
}
