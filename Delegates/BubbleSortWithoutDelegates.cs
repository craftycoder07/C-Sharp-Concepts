namespace Delegates;

public class BubbleSortWithoutDelegates
{
    /*
     * Problem with below code is you cant other objects.
     * Even if you use 'Generics' you need some way of doing comparison.
     */
    public static void Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}