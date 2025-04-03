using AccessModifiers;

//Can't access private members
//Shape.x = 1;

//Can access public member
Shape.y = 2;

//Can't access protected member. Only accessible from derived class
//Shape.z = 3;
Rectangle rect = new Rectangle();
rect.Draw();

