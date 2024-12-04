
namespace ch7;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[10] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

        SelectionSort(arr);

        Console.WriteLine($"4 is at index {BinarySearch(arr, 4)}");
        Console.WriteLine($"9 is at index {BinarySearch(arr, 9)}");
        Console.WriteLine($"17 is at index {BinarySearch(arr, 17)}");
    }

    public static int BinarySearch(int[] arr, int num)
    {
        int first = 0;
        int last = arr.Length - 1;
        int pos = -1;
        bool found = false;

        while(!found && first <= last)
        {
            int middle = (first + last) / 2;

            if(arr[middle] == num) 
            {
                found = true;
                pos = middle;
            }
            else if(arr[middle] > num)
            {
                last = middle - 1;
            }   
            else
            {
                first = middle + 1;
            }
        }
        return pos;
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