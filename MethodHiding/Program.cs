//With METHOD HIDING which method gets called is dependent on reference variable as opposed to METHOD OVERRIDING


using MethodHiding;


/*
 * CASE 1: Parent class reference variable and object
 * RESULT: Parent class method will be called
 */
Shape s = new Shape();
s.Draw();                       //In draw method of shape


/*
 * CASE 2: Child class reference variable and object
 * RESULT: Child class method will be called
 */
Rectangle c = new Rectangle();
c.Draw();                       //In draw method of rectangle



/*
 * CASE 3: Parent class reference variable and child class object
 * RESULT: Parent class method will be called
 */
Shape sr = new Rectangle();
sr.Draw();                       //In draw method of shape


