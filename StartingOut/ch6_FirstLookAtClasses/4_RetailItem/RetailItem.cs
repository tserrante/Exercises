namespace RetailItem;

public class RetailItem
{
    private string description;
    private int unitsOnHand;
    private double price;

    public string Description 
    {get; set;}
    public int UnitsOnHand {get; set;}
    public double Price {get; set;}

    public RetailItem(string description, int unitsOnHand, double price)
    {
        Description = description;
        UnitsOnHand = unitsOnHand;
        Price = price;
    }
}