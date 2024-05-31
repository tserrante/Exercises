namespace DistanceTraveled;

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