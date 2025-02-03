namespace ArrayOperations;

/*
11. Array operations
Write a program with an array that is initialized with test data. Use any primitive data type
of your choice. The program should also have the following methods:
• getTotal. This method should accept a one-dimensional array as its argument and
return the total of the values in the array.
• getAverage. This method should accept a one-dimensional array as its argument and
return the average of the values in the array.
• getHighest. This method should accept a one-dimensional array as its argument and
return the highest value in the array.
• getLowest. This method should accept a one-dimensional array as its argument and
return the lowest value in the array.
Demonstrate each of the methods in the program.
*/


public class Program
{
    public static void Main()
    {
        const int arraySize = 10;
        int[] array = new int[arraySize];
        Random rand = new Random();
        for(int i = 0; i < arraySize; i++)
        {
            array[i] = rand.Next(-100, 100);
            Console.Write($"{array[i]}, ");
        }

        Console.WriteLine("Total: {0}", ArrayTools.GetTotal(array));
        Console.WriteLine("Avg: {0}", ArrayTools.GetAverage(array));
        Console.WriteLine("Highest: {0}", ArrayTools.GetHighest(array));
        Console.WriteLine("Lowest: {0}", ArrayTools.GetLowest(array));

        Console.ReadLine();
    }
}