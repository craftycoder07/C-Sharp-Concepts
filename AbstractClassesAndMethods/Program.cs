using AbstractClassesAndMethods;

// Can't create instance of the abstract class. Below line will give compilation error.
//Shape shape= new Shape("");

//Developers still can use polymorphism with abstarct classes
Shape shape = new Rectangle();
shape.Draw();               //Will call draw method of the object.

Rectangle rectangle = new Rectangle();
rectangle.Draw();



