

namespace MultiplicationTable;
/*
1. Multiplication Table
Write a program that displays a multiplication table. The program should ask the user to
enter a number and also the range up to which the user wants to display the multiplication
table. For example, the multiplication table for the number 3 up to range 2 would look like:
3 x 1 = 3
3 x 2 = 6
*/
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