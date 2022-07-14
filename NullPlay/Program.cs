// See https://aka.ms/new-console-template for more information
using NullPlay;

Console.WriteLine("Hello, World!");

Person person = null;

string personName = person?.FirstName;  //No exception here

try
{
    personName = person.FirstName;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();
