namespace DiceGame;

public class Player
{
    private string name;
    private int points;
    private int currentDiceRoll;
    public string Name
    {
        set
        {
            name = value;
        }
        get => this.name;
    }
    public int Points
    {
        set => points = value;
        get => this.points;
    }
    public int CurrentDiceRoll
    {
        set => currentDiceRoll = value;
        get => currentDiceRoll;
    }

    public Player(string name)
    {
        Name = name;
    }
}