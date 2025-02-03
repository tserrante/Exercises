
namespace ChargeAccountValidation;

public class AccountValidation
{
    // private static int[] accountNumbers = {
    //     5658845, 4520125, 7895122, 8777541, 8451277, 1302850, 
    //     8080152, 4562555, 5552012, 5050552, 7825877, 1250255, 
    //     1005231, 6545231, 3852085, 7576651, 7881200, 4581002
    // };
    private int[] accountNumbers;

    public AccountValidation(string[] accountNumbers)
    {
        this.accountNumbers = new int[accountNumbers.Length];

        for(int i = 0; i < this.accountNumbers.Length; i++)
        {
            this.accountNumbers[i] = int.Parse(accountNumbers[i]);
        }
    }

    public bool ValidateAccountNumberLinq(int accountNumber) => accountNumbers.Contains(accountNumber);

    public bool ValidateAccountNumber(int accountNumber)
    {
        for(int i = 0; i < accountNumbers.Length; i++)
            if(accountNumbers[i] == accountNumber)
                return true;
        
        return false;
    }
}