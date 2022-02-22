

// for

Console.WriteLine("for");

for (byte i = 0; i < 7; i++)
{
    if (i == 3) continue;
    Console.WriteLine(i);
}


// while

Console.WriteLine("while");
sbyte b = -5;

while ( b >= -10 )
{
    Console.WriteLine(b);
    b--;
}


// do while

Console.WriteLine("do while");
do
{
    b++;
    Console.WriteLine(b);
    if (b == -7) b = 3;

} while (b < 5);


// foreach

string[] animals = new string[7] { "Cat", "Mouse", "Crown", "Whorse", "Dog", "Lion", "Rabbit" };

foreach (string animal in animals)
{
    if (animal != "Lion")
        Console.WriteLine(animal);
    else
        Console.WriteLine($"King {animal}!");
}

