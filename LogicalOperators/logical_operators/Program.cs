

// if else

if (22 == 24)
    Console.WriteLine("24 as 24.");
else
    Console.WriteLine("Something broke.");


// if else if

int i = -1;

if (i < 0)
    Console.WriteLine($"The variable i = {i}. This is less than 0.");
else if (i < 5)
    Console.WriteLine($"The variable i = {i}. This is less than 5.");
else if (i == 10)
    Console.WriteLine($"The variable i = {i}. This is equal to 10.");
else
    Console.WriteLine($"The variable i = {i}. This is more than 10.");


// () ? :

// Be sure to return the result!!!

byte b1 = 1, b2 = 2; 

byte resultOfTernaryOperatorOne = (b1 > b2) ? b1 : b2;
bool resultOfTernaryOperatorTwo = (b1 > b2) ? false : true;

Console.WriteLine($"resultOfTernaryOperatorOne = {resultOfTernaryOperatorOne}");
Console.WriteLine($"resultOfTernaryOperatorTwo = {resultOfTernaryOperatorTwo}");


// += ? :

string string1 = "DefaultValue ";
string1 += b1 == 1 ? "Value1" : "Value2";

Console.WriteLine(string1);


// = ? :

string string2 = "DefaultValue ";
string2 = b1 == 2 ? "Value1" : "Value2";

Console.WriteLine(string2);


// Nested ternary operators. Too hard to read...

bool bool1 = true;
byte byte1 = 1;

string string3 = (bool1 == true) ? ((byte1 == 0) ? "Meow" : "Wof") : ((byte1 == 1) ? "Moo" : "Blew");
Console.WriteLine(string3);

string3 = bool1 == false ? (byte1 == 1 ? "Meow" : "Wof") : (byte1 == 0 ? "Moo" : "Blew");
Console.WriteLine(string3);


// switch

int switcher = 6;

switch (switcher)
{
    case 0: // string "", char ''
        Console.WriteLine("Zero.");
        break;
    case 1:
    case 2:
    case 3:
    case 5: // string "", char ''
        Console.WriteLine("Less than six. But not four or zero!");
        break;
    case 6:
        Console.WriteLine("Oh no! I hate the number six! I'll turn her into...");
        goto case 0;
    default:
        Console.WriteLine(switcher);
        break;
}



#region Who are you?

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

#endregion


# region Game

int money = 100;
int minPrice = 20;

Console.Write("Enter the price of the item: ");
int price = int.Parse(Console.ReadLine());


// Conjunction (AND &&)

if (minPrice <= price && price <= money)
    Console.WriteLine("Buying!");
else
    Console.WriteLine("No thanks!");


// Disjunction (OR ||)

if (minPrice > price || price > money)
    Console.WriteLine("No thanks!");
else
    Console.WriteLine("Buying!");

// Exception with disjuction ( XOR ^ )

// true ^ true = false
// true ^ false || false ^ true = true
// false ^ false = false

byte small = 10;
byte big = 200;

byte sizeOfBall = small;

if (sizeOfBall == big ^ sizeOfBall == small)
    Console.WriteLine($"sizeOfBall = {sizeOfBall}");
else
    Console.WriteLine($"A ball cannot weigh too much and too little at the same time.");

// NOT !

if (!(minPrice > price || price > money))
    Console.WriteLine("Buying!");
else
    Console.WriteLine("No thanks!");

Console.WriteLine("Tnx!");

# endregion
