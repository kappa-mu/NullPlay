// See https://aka.ms/new-console-template for more information
using NullPlay;

TestcNullPropagator();
TestNullCoalescingOperator();

static void TestcNullPropagator()
{
    Person person = null;

    string personName = person?.FirstName;  //No exception here

    try
    {
        personName = person.FirstName; //Exception
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void TestNullCoalescingOperator()
{
    string personName = string.Empty;

    Person person1 = null;
    personName = person1?.FirstName ?? "John";
    Console.WriteLine(personName); //John

    Person person2 = new Person() { FirstName = null };
    personName = person2?.FirstName ?? "Bob";
    Console.WriteLine(personName); //Bob

    Person person3 = new Person() { FirstName = "Jenny" };
    personName = person3?.FirstName ?? "John";
    Console.WriteLine(personName); //Jenny

    int? a = null;
    var b = (a ?? 0);  //0
    var c = (a ??= 0); //0
    Console.WriteLine(b);
    Console.WriteLine(c);

}

Console.ReadLine();

