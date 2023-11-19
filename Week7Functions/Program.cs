Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintsHello();
}
else
{
    PrintGoodBye(); 
}



//PrintsHello(); //call on fuction
//PrintGoodBye();


static void PrintsHello() // function // method
{
    Console.WriteLine("Hello, world!");
}
static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}