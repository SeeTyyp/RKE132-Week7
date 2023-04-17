
Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoise = Console.ReadLine();

if(userChoise == "in")
{
PrintHello();

}
else
{
PrintGoodbye();

}
static void PrintHello() 
{
Console.WriteLine("Hello, world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, aligator.");
}