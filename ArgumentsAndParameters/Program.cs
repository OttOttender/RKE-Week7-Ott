
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput on argument/data //selecting the argument for the fuction to act on with its parameters

static void PrintAnyWord(string anyString) //anystring on parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}
