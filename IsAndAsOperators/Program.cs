/*
 * 'is' and 'as' operators are used with nullable types and reference types.
 */

object i = 1;

/*
 * 'as' operator tries to cast object to specified type.
 * If cast is not successful, it returns null unlike explicit casting where exception is thrown.
 */
int? x = i as int?;


/*
 * 'is' operator also tries to cast object to specified type.
 * it returns true if cast is successful and assigns the value to a variable as shown below.
 * It returns false if cast is NOT successful.
 */
if(i is int j)
    Console.WriteLine(j);