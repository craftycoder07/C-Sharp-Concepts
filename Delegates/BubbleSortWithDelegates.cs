namespace Delegates;

public class BubbleSortWithDelegates
{
    /*
     * With below code (with delegates) you can apply bubble sort on any objects.
     */
    public static void Sort<T>(T[] array, Func<T, T, int> funcComparer)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (funcComparer(array[j], array[j + 1]) > 0)
                {
                    // Swap
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}