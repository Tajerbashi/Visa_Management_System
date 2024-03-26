// See https://aka.ms/new-console-template for more information
using ApiCaller.Model;
using ApiCaller.Service;

Console.WriteLine("=========================");
Console.WriteLine("     Start Project");
Console.WriteLine("=========================");

Console.WriteLine("Do You Want Start Api Call ? Y(Yes)/N(No) : ");
var key = Console.ReadKey();
do
{
    var api = new CallGetApi("https://localhost:44350","sso/Users/ReadAll");
    Console.WriteLine("API : {0}", api.CallApi(""));
    Console.WriteLine("Try Again ? Y(Yes)/N(No) : ");
    key = Console.ReadKey();

} while (key.Key != (ConsoleKey)27);

Console.WriteLine("=========================");
Console.WriteLine("    Finished Project");
Console.WriteLine("=========================");
