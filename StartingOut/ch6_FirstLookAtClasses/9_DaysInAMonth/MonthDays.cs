namespace DaysInAMonth;

public class MonthDays
{
    private static Dictionary<int, int> MonthDayDictionary = new Dictionary<int, int>()
    {
        { (int)MonthEnum.January, 31 }, {  (int)MonthEnum.February, 28 }, {  (int)MonthEnum.March, 31 },
        {  (int)MonthEnum.April, 30 }, {  (int)MonthEnum.May, 31 }, {  (int)MonthEnum.June, 30 },
        {  (int)MonthEnum.July, 31 }, {  (int)MonthEnum.August, 31 }, {  (int)MonthEnum.September, 30 },
        {  (int)MonthEnum.October, 31 }, {  (int)MonthEnum.November, 30 }, {  (int)MonthEnum.December, 31 }
    };
    private int month;
    private int year;

    public MonthDays(int month, int year)
    {
        this.month = month;
        this.year = year;
    }

    public int GetNumberOfDays()
    {
        if(month != (int)MonthEnum.February)
        {
            return MonthDayDictionary[month];
        }
        // leap year logic
        if((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
        {
            return MonthDayDictionary[month] + 1;
        }
        
        return MonthDayDictionary[month];   
    }
}