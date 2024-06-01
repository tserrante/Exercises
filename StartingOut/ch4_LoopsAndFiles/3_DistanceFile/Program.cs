namespace DistanceFile;
/*
3. Distance File
Modify the program you wrote for Programming Challenge 2 (Distance Traveled) so it
writes the report to a file instead of the screen. Open the file in Notepad or another text
editor to confirm the output.
*/
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Distance Calculator");
        bool inputValid = false;
        string baseFilename = "distance";
        while(!inputValid)
        {
            Console.Write("Enter the objects speed: ");
            
            bool speedCaptured = int.TryParse(Console.ReadLine(), out int speed);

            Console.Write("Enter number of hours the object traveled: ");

            bool hoursCaptured = int.TryParse(Console.ReadLine(), out int hours);

            if(hours >= 1 && speed >= 0)
            {
                string date = DateTime.Now.ToShortDateString().Replace(@"/", "_");
                string time = DateTime.Now.ToShortTimeString().Replace(":", string.Empty);
                string fileType = ".txt";
                string newFileName = string.Concat(baseFilename, "_", date, "_", time, fileType);
                using(StreamWriter streamWriter = File.CreateText(newFileName))
                {
                    streamWriter.WriteLine("Hour\tDistance Traveled");
                    streamWriter.WriteLine("------------------------");
                    for(int i = 0; i < hours; i++)
                    {
                        streamWriter.WriteLine("{0}\t\t{1}", i+1, (i+1) * speed);
                    }
                    streamWriter.Close();
                }
                inputValid = true;
                Console.WriteLine($"File {newFileName} created.  Open file to see output.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Input was invalid, restarting.");
            }

        }
    }
}