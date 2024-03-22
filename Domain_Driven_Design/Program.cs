
using Domain_Driven_Design_Solution.Library_Domain.Entities;
using Domain_Driven_Design_Solution.Library_Domain.ValueObjects;

Console.WriteLine(" --------- Start Project --------- ");

Person person = new(
    new PersonID("1"),
    new FullName("Kamran","Tajerbashi"),
    new Email("KamranTajerbashi@mail.com"),
    new Phone("09020320844")
    );

#region Color
Color color1 = new(255,230,340);
Color color2 = new(255,230,340);
if (color1 == color2)
{
    Console.WriteLine("Color : Equal");
}
else
{
    Console.WriteLine("Color : Not Equal");
}
#endregion

#region Person
Console.WriteLine("Person : {0}", person);
#endregion

Console.WriteLine(" --------- End Project --------- ");
Console.ReadLine();