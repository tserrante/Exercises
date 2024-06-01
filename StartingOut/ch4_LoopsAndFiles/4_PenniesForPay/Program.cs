namespace PenniesForPay;
/*
4. Pennies for Pay
Write a program that calculates the amount a person would earn over a period of time if his
or her salary is one penny the first day, two pennies the second day, and continues to double
each day. The program should display a table showing the salary for each day, and then
show the total pay at the end of the period. The output should be displayed in a dollar
amount, not the number of pennies.
Input Validation: Do not accept a number less than 1 for the number of days worked.
*/
public class Program
{
    static readonly double DAILY_RATE = 0.01;
    static readonly int MULTIPLIER = 2;
    public static void Main(string[] args)
    {
        double totalPay;
        double dailyPay = DAILY_RATE;
        bool isValidInput = false;

        while(!isValidInput)
        {
            Console.Write("Enter number of working days: ");
            bool readDays = int.TryParse(Console.ReadLine(), out int days);

            if(days >= 1)
            {
                Console.WriteLine("Day\tPay($)");
                Console.WriteLine("-------------------");
                totalPay = dailyPay;
                for(int i = 0; i < days; i++)
                {
                    totalPay += dailyPay;
                    Console.WriteLine($"{i+1}\t${dailyPay}");
                    dailyPay *= 2;
                }
                Console.WriteLine($"Total: {totalPay}");
                Console.Read();
            }

        }




    }
}

