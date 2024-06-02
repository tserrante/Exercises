
/*
6. File Letter Counter
Write a program that asks the user to enter the name of a file, and then asks the user to
enter a character. The program should count and display the number of times that the
specified character appears in the file. Use Notepad or another text editor to create a simple
file that can be used to test the program.
*/

namespace FileLetterCounter;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter filename of text file (including extension): ");
        string filename = Console.ReadLine();
        Console.WriteLine();
        
        if(File.Exists(filename))
        {
            Console.Write("Enter a character: ");
            char ch = Console.ReadLine()[0];
            Console.WriteLine();

            string fileContent = File.ReadAllText(filename);
            int count = fileContent.Count(x => x == ch);
            
            Console.WriteLine($"The Character {ch} appears {count} in the file {filename}");
        }
        else
        {
            Console.WriteLine("File does not exist...exiting.");
        }
        Console.Read();
    }
}