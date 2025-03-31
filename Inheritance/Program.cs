Manager m = new Manager("Sid", "Chalke");

//PRIVATE member IS NOT accessible
//m.firstName

//PUBLIC member IS accessible
Console.WriteLine(m.lastName);

//Inheritance is transitive in nature. If A<-B<-C, Then A will have access to all PUBLIC properties of C.
m.CheckSalary();
m.TakeLunchBreak();