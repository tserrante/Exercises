namespace HotelOccupancy;
/*
9. Hotel Occupancy
Write a program that calculates the occupancy rate for a hotel. The program should
start by asking the user how many floors the hotel has. A loop should then iterate once
for each floor. In each iteration, the loop should ask the user for the number of rooms
on the floor and how many of them are occupied. After all the iterations, the program
should display how many rooms the hotel has, how many of them are occupied, how
many are unoccupied, and the percentage of rooms that are occupied. The percentage
may be calculated by dividing the number of rooms occupied by the number of rooms.
*/
public class Program
{
    /*
        todo
        The math is wrong!
    */
    public static void Main()
    {
        Console.Write("How many floors?");
        int numFloors = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if(numFloors > 0)
        {
            float percentOccupied = 0.0f;
            for(int i = 0; i < numFloors; i++)
            {
                Console.Write("How many rooms on floor {0}? ", i+1);
                int numRooms = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("How many rooms are occupied? ");
                int numOccupied = int.Parse(Console.ReadLine());

                percentOccupied += numOccupied/numRooms;
            }
            Console.WriteLine("The hotel is at {0} capacity", percentOccupied);
            Console.ReadLine();
        }
    }
}