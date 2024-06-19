namespace RetailItem;

/*
4. RetailItem class
Write a class named RetailItem that holds data about an item in a retail store. The class
should have the following fields:
• description. The description field references a String object that holds a brief
description of the item.
• unitsOnHand. The unitsOnHand field is an int variable that holds the number of units
currently in inventory.
• price. The price field is a double that holds the item’s retail price.
Write a constructor that accepts arguments for each field, appropriate mutator methods
that store values in these fields, and accessor methods that return the values in these fields.
*/

public class Program
{
    public static void Main()
    {
        List<RetailItem> items = new List<RetailItem>()
        {
            new RetailItem("Item A", 22, 6.95),
            new RetailItem("Item B", 0, 14.49),
            new RetailItem("Item C", 433, 0.65)
        };

        Console.WriteLine("Desc.\tPrice ($)\t Qty");
            foreach(RetailItem item in items)
        {
            Console.WriteLine($"{item.Description}\t{item.Price}\t{item.UnitsOnHand}");
        }
        Console.Read();
    }
}