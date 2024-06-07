namespace DiceGame;

public class Game
{
    private const int DEFAULT_ROUNDS = 5;
    private const int DEFAULT_NUM_PLAYERS = 2;
    private int numPlayers;
    private int numRounds;
    private List<Player> players;
    private Dice dice;

    public Game(int numPlayers, int numRounds)
    {
        players = new List<Player>();
        dice = new Dice();
        if(numPlayers >= 2)
        {
            this.numPlayers = numPlayers;
        }
        else
        {
            Console.WriteLine($"Cannot have {numPlayers} players, using default value of two players");
            this.numPlayers = DEFAULT_NUM_PLAYERS;
        }
        Console.WriteLine("Enter Player Information");
        
        for(int i = 0; i < this.numPlayers; i++)
        {
            Console.Write($"Player {i+1} name: ");
            string playerName = Console.ReadLine();
            players.Add(new Player(playerName));
            Console.WriteLine();
        }

        if(numRounds <= 0)
        {
            Console.WriteLine($"Cannot have {numRounds} rounds, using default value of five rounds");
            this.numRounds = DEFAULT_ROUNDS;
        }
        else
        {
            this.numRounds = numRounds;
        }
        
    }

    public void PlayGame()
    {
        for(int i = 0; i < this.numRounds; i++)
        {
            Console.WriteLine("Leader Board");
            PrintPoints();

            Console.WriteLine($"Round {i+1}");
            
            foreach(Player player in players)
            {
                player.CurrentDiceRoll = dice.RollDice();
                Console.WriteLine($"{player.Name} rolled a {player.CurrentDiceRoll}");
                Thread.Sleep(750);
            }

            string winnerName = GetRoundWinnerOrEmptyString();
           
            if(string.IsNullOrEmpty(winnerName))
            {
                Console.WriteLine("Tie!");
            }
            else
            {
                Console.WriteLine($"{winnerName} won the round!");
                players.Find(x => string.Equals(winnerName, x.Name)).Points++;
            }
            Console.WriteLine("Press Enter to play the next round");
            Console.ReadLine();
        }

        Console.WriteLine("Final Scores");
        PrintPoints();
        
        string gameWinnerName = GetGameWinnerOrEmptyString();

        if(string.IsNullOrEmpty(gameWinnerName))
        {
            Console.WriteLine("Cat Game, no winner!");
        }
        else
        {
            Console.WriteLine("The Winner is {0}", gameWinnerName);
        }

        Console.WriteLine();
        Console.ReadLine();
        
    }

    private string GetRoundWinnerOrEmptyString()
    {
        string roundWinner = string.Empty;
        for(int i = 0; i < players.Count; i++)
        {
            Player currentPlayer = players[i];
            
            for(int j = i + 1; j < players.Count; j++)
            {
                if(players[j].CurrentDiceRoll > currentPlayer.CurrentDiceRoll)
                {
                    roundWinner = players[j].Name;
                }
                if(players[j].CurrentDiceRoll < currentPlayer.CurrentDiceRoll)
                {
                    roundWinner = currentPlayer.Name;
                }
            }
        }
        return roundWinner;
    }

    private string GetGameWinnerOrEmptyString()
    {
        string gameWinner = string.Empty;
        for(int i = 0; i < players.Count; i++)
        {
            Player currentPlayer = players[i];
            
            for(int j = i + 1; j < players.Count; j++)
            {
                if(players[j].Points > currentPlayer.Points)
                {
                    gameWinner = players[j].Name;
                }
                if(players[j].Points < currentPlayer.Points)
                {
                    gameWinner = currentPlayer.Name;
                }
            }
        }
        return gameWinner;
    }

    private void PrintPoints()
    {
        foreach(Player player in players)
        {
            Console.WriteLine($"{player.Name}:{player.Points}");
        }
        Console.WriteLine();
    }
}