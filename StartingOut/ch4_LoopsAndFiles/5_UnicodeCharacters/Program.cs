namespace UnicodeCharacters;

/*
5. Unicode Characters
Write a program that asks the user to enter a Unicode decimal value that must lie either in
the range of 65 to 90 or 97 to 122. The program must use a user controlled loop to display
the letter (i.e. from A to Z or a to z) corresponding to the Unicode decimal value.
*/

public class Program
{
    public static void Main()
    {
        bool userFinished = false;
        while(!userFinished)
        {
            Console.Write("Enter a Unicode decimal value between 65-90, or 90-122");
            Console.WriteLine();
            bool readUnicode = int.TryParse(Console.ReadLine(), out int unicodeValue);
            if((unicodeValue >= 65 && unicodeValue <= 97) || (unicodeValue >= 97 && unicodeValue <= 122))
            {
                char unicodeChar = Convert.ToChar(unicodeValue);
                Console.WriteLine("Value\tUnicode Character");
                Console.WriteLine("---------------------------");
                Console.WriteLine($"{unicodeValue}\t{unicodeChar}");
            }
            else
            {
                Console.WriteLine("Invalid Input, no output");
            }

            Console.Write("Continue? (enter 'n' to exit)");
            string keyboardInput = Console.ReadLine().ToUpper();
            
            if(keyboardInput.Equals("N"))
            {
                userFinished = true;
            }
            Console.WriteLine();
        }
    }
}