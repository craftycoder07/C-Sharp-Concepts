using AccessModifierLib;

//Can't access private members anywhere
//Shape.x = 1;

//Can access public member
Shape.y = 2;

//Can't access protected member. Only accessible from derived class
//Shape.z = 3;
Rectangle rect = new Rectangle();
rect.Draw();

//Since Square class is 'internal' in 'AccessModifierLib' library, it is not accessible in 'AccessModifier'
//Developer will get compilation error.
//Square s = new Square();

//'X' is not accessible here as it is declared protected.
//Shape1 s = new Shape1();
//s.X;

// Circle c = new Circle();
// c.Y;



