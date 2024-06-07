using static System.Threading.Thread;
namespace DiceGame;
/*
21. Dice game
Write a program that plays a simple dice game between the computer and the user. When
the program runs, a loop should repeat 10 times. Each iteration of the loop should do the
following:
•  Generate a random integer in the range of 1 through 6. This is the value of the 
computer’s die.
•  Generate another random integer in the range of 1 through 6. This is the value of the 
user’s die.
•  The die with the highest value wins. (In case of a tie, there is no winner for that 
particular roll of the dice.)
As the loop iterates, the program should keep count of the number of times the computer
wins, and the number of times that the user wins. After the loop performs all of its itera-
tions, the program should display who was the grand winner, the computer or the user.
*/
public class Program
{
    public static void Main()
    {
        Game game = new Game(2, 3);
        game.PlayGame();
    }
}