public static class StringEx
{
    /*
     * Extension methods are used to extend the functionality of the classes.
     * Good use case to do this is for extending functionality of the sealed classes. (E.g. string class)
     */

    /*
     * Creating EXTENSION METHOD
     * First parameter is going to be with this keyword.
     * Type of first parameter is going to be the type for you which you are creating extension method.
     */
    public static int GetCharCount(this string str, char c)
    {
        int count = 0;
        foreach (var character in str.ToCharArray())
        {
            if (character == c)
                count++;
        }
        return count;
    }
}