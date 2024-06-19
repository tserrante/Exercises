
namespace DaysInAMonth;

/*
9. Days in a Month
Write a class named MonthDays. The class’s constructor should accept two arguments:
•  An integer for the month (1 5 January, 2 February, etc.).
•  An integer for the year
The class should have a method named getNumberOfDays that returns the number of days
in the specified month. The method should use the following criteria to identify leap years:
  1. 
Determine whether the year is divisible by 100. If it is, then it is a leap year if and if 
only it is divisible by 400. For example, 2000 is a leap year but 2100 is not.
  2. 
If the year is not divisible by 100, then it is a leap year if and if only it is divisible by 
4. For example, 2008 is a leap year but 2009 is not.
Demonstrate the class in a program that asks the user to enter the month (letting the user
enter an integer in the range of 1 through 12) and the year. The program should then dis-
play the number of days in that month. Here is a sample run of the program:
Enter a month (1-12): 2 [enter]
Enter a year: 2008 [enter]
29 days

*/

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Month (1-12): ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Year (yyyy): ");
        int year = int.Parse(Console.ReadLine());

        MonthDays days = new MonthDays(month, year);

        Console.WriteLine($"{days.GetNumberOfDays()}");

        Console.Read();


    }
}