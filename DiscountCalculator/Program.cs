

//< 10 - 1% summa 10 allahindlus 1
//total 10 && total < 20 - 5%
// total >= 20 - 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculationDiscount(userInput);//siia salvestatakse discount

Console.WriteLine($"Your discount is: {discount}.");

double newTotal = CalculateNewTotal(userInput, discount);

//double newTotal = userInput - (userInput * discount) / 100;
Console.WriteLine($"Your updated total with {discount}% is: {newTotal}");
//salvestab v2he m2llu // saab olla ka int v2i string
static double CalculationDiscount(int total)
{
    if (total < 10)
    {
        return 1; //vahe mallu luuakse koht kuhu salvestatakse see v22rtus
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount) //kaivad eri aegadel, seega voivad olla samanimelised parameetrid
{
    double result = total - (total * discount) / 100;
    return result; //parameetrid lihtsalt kirjeldused funktsioonile
    //double total tuleb siisk userInputist ja discount samamoodi aga salvestatakse double discount alla
}