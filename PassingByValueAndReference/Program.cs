/*
 * Since A is a struct (value type), it is passed by value.
 * Meaning copy of the type is sent rather than original type.
 * Hence, whatever changes are made to the passed type won't be reflected in original object.
 */
A a;
a.X = 1;
ChangeA(a);
Console.WriteLine(a.X);

/*
 * In case of value types, developer can pass value type by reference.
 * Meaning changes made to the passed object will be reflected in original object even if it is a value type.
 */
A aa;
aa.X = 1;
ChangeAByRef(ref aa);
Console.WriteLine(aa.X);

/*
 * Since B is a class (Reference type), it is passed by reference.
 * Meaning address of the object is passed rather than a object.
 * Thus, whatever changes are made to the passed object are reflected in original object.
 */
B b = new B();
b.X = 1;
ChangeB(b);
Console.WriteLine(b.X);

/*
 * You can also use ref keyword with reference type. In this case, you are sending reference to a reference.
 * If you DON'T use ref keyword, and in calling method you create and assign a object, You are assigning new object to local reference. Original reference object remains intact.
 * If you USE ref keyword, and in calling method create and assign new object, You are essentially assigning new object to original reference.
 */
B bb = new B();
bb.X = 1;
ChangeBByRef(ref bb);
Console.WriteLine(bb.X);


static void ChangeA(A a)
{
    a.X = 2;
}

static void ChangeAByRef(ref A a)
{
    a.X = 2;
}

static void ChangeB(B b)
{
    b.X = 2;
}

static void ChangeBByRef(ref B b)
{
    b.X = 2;
    b = new B();
    b.X = 3;
}

public struct A
{
    public int X;
}

public class B
{
    public int X;
}
