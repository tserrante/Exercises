

namespace MultiplicationTable;

public class Program
{
    /*
        todo
        handle null cases better
        data input validation
    */
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num1 = int.Parse(System.Console.ReadLine());
        Console.Write("Enter a second number: ");
        int num2 = int.Parse(System.Console.ReadLine());

        for(int i = 0; i < num2 + 1; i++)
        {
            System.Console.WriteLine($"{num1} x {i} = {num1*i}");
        }

        Console.Read();
    }
}