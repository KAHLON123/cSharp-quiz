//welcome
#nullable disable
Console.Clear();
double count = 0;

Console.WriteLine("Welcome to the best quiz ever");

//questions and checking answers
Console.WriteLine("What is the biggest sea animal?");
string answer1 = Console.ReadLine();

if (answer1.ToLower() == "blue whale")
{
    Console.WriteLine("That's correct!");
    count++;
}
else
{
    Console.WriteLine("Not quite");
}

Console.WriteLine("How many continents are there?");
string answer2 = Console.ReadLine();

if (answer2 == "7" || answer2.ToLower() == "seven")
{
    Console.WriteLine("Yep! Way to go");
    count++;
}
else
{
    Console.WriteLine("Maybe next time?");
}

Console.WriteLine("How may inches are in a foot?");
string answer3 = Console.ReadLine();

if (answer3 == "12" || answer3.ToLower() == "twelve")
{
    Console.WriteLine("WOWZERS!!!");
    count++;
}
else
{
    Console.WriteLine("Nah, thats WRONG");
}

Console.WriteLine("WHAT is the abbreviation of computing science?");
string answer4 = Console.ReadLine();

if (answer4.ToLower() == "cs")
{
    Console.WriteLine("GOOD JOB NERD");
    count++;
}
else
{
    Console.WriteLine("[VERY LOUD INCORRECT BUZZER]");
}
//output final percentage
double total = (count / 4) * 100;
Console.WriteLine($"Your grade is: {count}/4 or {total}%");