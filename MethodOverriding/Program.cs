//With METHOD OVERRIDING & POLYMORPHISM (learnt in INHERITANCE chapter), which method gets called is decided at the compile time.

/*
 * CASE 1: Parent class reference & parent class object
 * RESULT: Parent class method will be called.
 */
Shape s = new Shape();
s.Draw();           //In draw method of shape


/*
 * CASE 2: Child class reference & Child class object
 * RESULT: Child class method will be called.
 */
Rectangle r = new Rectangle();
r.Draw();           //In draw method of rectangle

/*
 * CASE 3: Parent class reference & Child class object
 * RESULT: Child class method will be called as which method gets called is decided at the run time.
 */
Shape sr = new Rectangle();
sr.Draw();          //In draw method of rectangle


