// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * ANONYMOUS TYPES
 * 1) Anonymous types are types without class name. You just use 'var' and 'new' keywords to create objects of it.
 * 2) If two anonymous types has same properties then they are of same type.
 *    You can do anonymous1 = anonymous2 (basically assignment)
 */
var engineer = new
{
    FirstName = "John",
    LastName = "Doe"
};

var doctor = new
{
    FirstName = "Sam",
    LastName = "Jackson"
};

/*
 * If you use other objects to assign values to properties of anonymous object, you don't have to declare property names.
 * They are automatically inferred.
 */
var dentist = new
{
    doctor.FirstName,
    doctor.LastName
};

/*
 * If you try to check type of anonymous type, you will see that compiler generates random class name.
 * Thus don't use type reflection on anonymous type.
 */
Type type = dentist.GetType();
Console.WriteLine($"Type Name: {type.Name}");