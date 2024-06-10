namespace PersonalInformation;

public class PersonalData
{
    private string name;
    private int age;
    private string address;
    private string phoneNumber;

    public string Name {get; set;}
    public int Age {get; set;}
    public string Address {get; set;}
    public string PhoneNumber {get; set;}

    public PersonalData(string name, int age, string address, string phoneNumber)
    {
        Name = name;
        Age = age;
        Address = address;
        PhoneNumber = phoneNumber;
    }
    public override string ToString()
    {
        return $"{Name} is {Age} old and lives at {Address}. Ph: {PhoneNumber}";
    }
}