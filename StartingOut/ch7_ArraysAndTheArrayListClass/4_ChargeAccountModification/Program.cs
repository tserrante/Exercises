
namespace ChargeAccountValidation;

/*
4. charge Account Modification
Modify the charge account validation class that you wrote for Programming Challenge 3 so
it reads the list of valid charge account numbers from a file. Use Notepad or another text
editor to create the file.
*/
public class Program
{
    public static void Main()
    {
        string[] accountNumbers = ReadAccountNumbers("account_numbers.txt");
       
       AccountValidation validator = new AccountValidation(accountNumbers);

        Console.WriteLine($"5658845 -> {validator.ValidateAccountNumber(5658845)}");
        Console.WriteLine($"5658845 -> {validator.ValidateAccountNumberLinq(5658845)}");
        Console.WriteLine($"565884665 -> {validator.ValidateAccountNumber(565884665)}");
        Console.WriteLine($"565884665 -> {validator.ValidateAccountNumberLinq(565884665)}");

       Console.ReadLine();
    }

    public static string[] ReadAccountNumbers(string filepath)
    {
        //string[] accountNumbers =
        return File.ReadAllText(filepath).Split(',');
    }
}