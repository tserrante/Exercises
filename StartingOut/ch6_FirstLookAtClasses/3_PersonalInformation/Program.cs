namespace PersonalInformation;
/*
3. personal information class
Design a class that holds the following personal data: name, address, age, and phone num-
ber. Write appropriate accessor and mutator methods. Demonstrate the class by writing a
program that creates three instances of it. One instance should hold your information, and
the other two should hold your friends’ or family members’ information.
*/
public class Program
{
    public static void Main()
    {
        List<PersonalData> data = new List<PersonalData>
        {
            new PersonalData("Person A", 22, "84 Oak St.", "5405514321"),
            new PersonalData("Person B", 62, "221 Weynon Priorty Ct.", "4418675309"),
            new PersonalData("Person C", 18, "901 Elm St.", "7579213323")
        };
        foreach (PersonalData entry in data)
        {
            System.Console.WriteLine(entry.ToString());
        }
        Console.Read();
    }

}