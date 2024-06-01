namespace DistanceTraveled;

/*
2. Distance Traveled
The distance a vehicle travels can be calculated as follows:
Distance 5 Speed * Time
For example, if a train travels 40 miles-per-hour for three hours, the distance traveled is
120 miles. Write a program that asks for the speed of a vehicle (in miles-per-hour) and the
number of hours it has traveled. It should use a loop to display the distance a vehicle has
traveled for each hour of a time period specified by the user. For example, if a vehicle is
traveling at 40 mph for a three-hour time period, it should display a report similar to the
one that follows:
Input Validation: Do not accept a negative number for speed and do not accept any value
less than 1 for time traveled.

Hour    Distance Traveled
--------------------------
1       40
2       80
3       120
*/
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Distance Calculator");
        bool inputValid = false;

        while(!inputValid)
        {
            Console.Write("Enter the objects speed: ");
            
            bool speedCaptured = int.TryParse(Console.ReadLine(), out int speed);

            Console.Write("Enter number of hours the object traveled: ");

            bool hoursCaptured = int.TryParse(Console.ReadLine(), out int hours);

            if(hours >= 1 && speed >= 0)
            {
                Console.WriteLine("Hour\tDistance Traveled");
                Console.WriteLine("------------------------");
                for(int i = 0; i < hours; i++)
                {
                    Console.WriteLine("{0}\t\t{1}", i+1, (i+1) * speed);
                }
                inputValid = true;
                Console.Read();
            }
            else
            {
                Console.WriteLine("Input was invalid, restarting.");
            }

        }
    }
}