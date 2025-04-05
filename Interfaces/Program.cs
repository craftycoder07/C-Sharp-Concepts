using Interfaces;

/*
 * Following shows that default methods are only accessible via that interface variable.
 * Polymorphism is also applicable for interfaces. All polymorphism rules apply here.
 */
IBankAccount  bankAccount = new RandomAccount();
bankAccount.GetBalance2();

//Default methods are not inherited
RandomAccount randomAccount = new RandomAccount();
//randomAccount.GetBalance2();
