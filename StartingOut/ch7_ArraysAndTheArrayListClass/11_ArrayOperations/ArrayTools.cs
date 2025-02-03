using System.Collections;
using System.Numerics;

namespace ArrayOperations;

public class ArrayTools
{
    public static T GetTotal<T>(T[] array) where T : INumber<T>
    {
        T sum = T.Zero;

        foreach(T num in array)
        {
            sum += num;
        }
        return sum;
    }

    public static T GetAverage<T>(T[] array) where T : INumber<T>
    {
        if(array.Length == 0)
            throw new InvalidOperationException("array length is zero");

        T average = T.Zero;

        foreach(T num in array)
        {
            average += num;
        }
        return average / T.CreateChecked(array.Length);
    }

    public static T GetHighest<T>(T[] array) where T : INumber<T>
    {
        T number = T.Zero;

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > number)
            {
                number = array[i];
            }
        }
        return number;
    }

    public static T GetLowest<T>(T[] array) where T : INumber<T>
    {
        T number = T.Zero;

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] < number)
            {
                number = array[i];
            }
        }
        return number;
    }
}