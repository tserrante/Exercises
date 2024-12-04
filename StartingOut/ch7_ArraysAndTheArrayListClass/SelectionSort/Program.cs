
namespace ch7;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[10] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

        Console.WriteLine("Before sort");
        foreach(int elem in arr)
            Console.Write($"{elem}, ");
        
        SelectionSort(arr);

        Console.WriteLine("\nAfter Sort");
        foreach(int elem in arr)
            Console.Write($"{elem}, ");
    }

    public static void SelectionSort(int[] arr)
    {
        int startScan; 
        int index;
        int minIndex;
        int minValue;

        for(startScan = 0; startScan < arr.Length-1; startScan++)
        {
            minIndex = startScan;
            minValue = arr[startScan];

            for(index = startScan + 1; index < arr.Length;  index++)
            {
                if(arr[index] < minValue)
                {
                    minValue = arr[index];
                    minIndex = index;
                }
            }
            arr[minIndex] = arr[startScan];
            arr[startScan] = minValue;
        }
    }
}