

// for

Console.WriteLine("for");

for (byte i = 0; i < 7; i++)
{
    if (i == 3) continue;
    Console.WriteLine(i);
}

Thread.Sleep(1000);
Console.Beep();
Console.Clear();


// while

Console.WriteLine("while");
sbyte b = -5;

while ( b >= -10 )
{
    Console.WriteLine(b);
    b--;
}

Thread.Sleep(1000);
Console.Beep();
Console.Clear();


// do while

Console.WriteLine("do while");
do
{
    b++;
    Console.WriteLine(b);
    if (b == -7) b = 3;

} while (b < 5);

Thread.Sleep(1000);
Console.Beep();
Console.Clear();


// foreach

string[] animals = new string[7] { "Cat", "Mouse", "Crow", "Horse", "Dog", "Lion", "Rabbit" };

foreach (string animal in animals)
{
    if (animal != "Lion")
        Console.WriteLine(animal);
    else
        Console.WriteLine($"King {animal}!");
}
Thread.Sleep(1000);

// goto

Console.ForegroundColor = ConsoleColor.Green;

Repeat:

Thread.Sleep(500);
Console.Beep();
Console.Clear();
Thread.Sleep(500);

Random rnd = new Random();

byte animalId = (byte) rnd.Next(animals.Length);
Console.WriteLine($"Your random animal is a {animals[animalId]}!");
Console.WriteLine("Would you like to repeat? (Write Y or N)");

string userInput = Console.ReadLine();

if (userInput.ToUpper() == "Y")
{
    goto Repeat;
}

Exit:
Console.Beep();
Thread.Sleep(1000);
Console.WriteLine("Goodbye!");
Thread.Sleep(1000);
