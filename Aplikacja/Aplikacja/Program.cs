var name = "Daniel";
var sex = "male";
var age = 26;

if (age > 30)
{
    Console.WriteLine("Facet po 30-tce");
}
else if (age == 29)
{
    if (age == 30)
    {
        Console.WriteLine("Trzydziesto letni mężczyzna");

    }
    else
    {
        Console.WriteLine("Dwudziestodziewięcio letni mężczyzna");
    }
}
else
{
    Console.WriteLine("Mężczyzna poniżej 29-go roku życia");
    if(name == "Daniel" && sex == "male")
    {
        Console.WriteLine("Cześć Daniel. Miło mi Cię poznać.");
    }
}