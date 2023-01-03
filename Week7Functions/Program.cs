Console.WriteLine("Are you coming or leaving? (in/out):");
string userchoice = Console.ReadLine();

if (userchoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}



PrintHello();
PrintGoodbye();


static void PrintHello() //funtion /method
{
    Console.WriteLine("Hello,world!");
}

static void PrintGoodbye()
{
    Console.WriteLine("See you later, aligator.");
}