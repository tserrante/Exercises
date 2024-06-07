namespace DiceGame;

public class Dice
{
    private static readonly int DEFAULT_SIDES = 6;
    private Random rollDice;
    private int diceSides;
    
    public int RollDice()
    {
        if(rollDice != null)
        {
            return rollDice.Next(0, this.DiceSides + 1);
        }
        return -1;
    
    }
    public int DiceSides
    {
        get => this.diceSides;
    }
    public Dice()
    {
        this.diceSides = DEFAULT_SIDES;
        this.rollDice = new Random();
    }
    public Dice(int diceSides)
    {
        this.diceSides = diceSides;
        this.rollDice = new Random();
    }
}