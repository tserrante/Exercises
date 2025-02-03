
namespace LotteryApplication;

public class Lottery
{
    private const int LOTTERY_LENGTH = 5;
    private int[] lotteryNumbers;

    public Lottery()
    {
        lotteryNumbers = new int[LOTTERY_LENGTH];
        Random rand = new Random();

        for(int i = 0; i < LOTTERY_LENGTH; i++)
        {
            lotteryNumbers[i] = rand.Next(0, 10);
        }
    }

    public int GetNumberOfCorrectDigits(int[] lotteryGuess)
    {
        int count = 0;
        for(int i = 0; i < lotteryNumbers.Length; i++)
        {
            if(lotteryNumbers[i] == lotteryGuess[i])
                count++;
            
        }
        return count;
    }
}