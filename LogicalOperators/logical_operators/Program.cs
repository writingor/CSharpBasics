

// if else

if (22 == 24)
{
    Console.WriteLine("24 as 24.");
}
else
{
    Console.WriteLine("Something broke.");
}

int i = -1;

if (i < 0)
{
    Console.WriteLine($"The variable i = {i}. This is less than 0.");
}
else if (i < 5)
{
    Console.WriteLine($"The variable i = {i}. This is less than 5.");
}
else if (i == 10)
{
    Console.WriteLine($"The variable i = {i}. This is equal to 10.");
}
else
{
    Console.WriteLine($"The variable i = {i}. This is more than 10.");
}

// switch

switch (i)
{
    case 0:
        Console.WriteLine(0);
        break;
    case 5:
        Console.WriteLine(5);
        break;
    default:
        Console.WriteLine("Something other.");
        break;
}


Console.Write("Enter your name: ");
string name = Console.ReadLine();

switch (name)
{
    case "Igor":
        Console.WriteLine("Nice to meet you! My name is Igor too!");
        break;
    default:
        Console.WriteLine($"Nice to meet you, {name}!");
        break;
}


// || && !

int money = 100;
int minPrice = 20;

Console.Write("Enter the price of the item: ");
int price = int.Parse(Console.ReadLine());


// AND &&

if (minPrice <= price && price <= money)
{
    Console.WriteLine("Buying!");
}
else
{
    Console.WriteLine("No thanks!");
}

// OR ||

if (minPrice > price || price > money)
{
    Console.WriteLine("No thanks!");
}
else
{
    Console.WriteLine("Buying!");
}

// NOT !

if (!(minPrice > price || price > money))
{
    Console.WriteLine("Buying!");
}
else
{
    Console.WriteLine("No thanks!");
}


