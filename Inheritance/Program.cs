Manager m = new Manager("Sid", "Chalke");

//PRIVATE member IS NOT accessible
//m.firstName

//PUBLIC member IS accessible
Console.WriteLine(m.lastName);

//Inheritance is transitive in nature. If A<-B<-C, Then A will have access to all PUBLIC properties of C.
m.CheckSalary();
m.TakeLunchBreak();

//Developers can use parent class variables to point to child class objects. This is called polymorphism.
Employee e = new Manager("James", "Bond");

/*
 * In above scenario, members that are available depends on reference variable.
 * Even though object is of type Manager in above case which has access to 'DoPerformanceReview' method,
 * because reference variable is of type Employee which doesn't have access to 'DoPerformanceReview' method,
 * below line will give compilation error
 */
//e.DoPerformanceReview();

/*
 * They can access public parent class members as they will be inherited to child class.
 */
 e.CheckSalary();