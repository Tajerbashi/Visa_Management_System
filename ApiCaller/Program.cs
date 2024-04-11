// See https://aka.ms/new-console-template for more information
using ApiCaller.Attributes;
using ApiCaller.Model;
using ApiCaller.Service;

Console.WriteLine("=========================");
Console.WriteLine("     Start Project");
Console.WriteLine("=========================");
#region CallAPI
//Console.WriteLine("Do You Want Start Api Call ? Y(Yes)/N(No) : ");
//var key = Console.ReadKey();
//do
//{
//    var api = new CallGetApi("https://localhost:44350","sso/Users/ReadAll");
//    Console.WriteLine("API : {0}", api.CallApi(""));
//    Console.WriteLine("Try Again ? Y(Yes)/N(No) : ");
//    key = Console.ReadKey();

//} while (key.Key != (ConsoleKey)27);
#endregion
#region Attribute
Console.WriteLine("Attributes sample");
var CurrentUser = new UserDTO("Admin");
static void PrintAuthorInfo(System.Type t)
{
    System.Console.WriteLine($"Author information for {t}");

    // Using reflection.
    System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.
    string name = t.Name;
    // Displaying output.
    foreach (System.Attribute attr in attrs)
    {
        if (attr is PrivilegeAttribute a)
        {
            System.Console.WriteLine($"{name}.{a.GetName()}, version {a.Version:f}");
        }
    }
}
if (CurrentUser.Roles.Any(x => x.RoleName.Equals("Admin")))
{
    PrintAuthorInfo(typeof(UserService));
}
else
{
    throw new Exception("You Dont Have Access");
}

Console.ReadKey();
#endregion
Console.WriteLine("=========================");
Console.WriteLine("    Finished Project");
Console.WriteLine("=========================");
