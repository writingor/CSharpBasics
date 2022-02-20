
// Эта строка для кодировки в UTF8
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Hello, World!");
Console.WriteLine("Привет, Мир!");


// 2 byte

char c = 'a'; // only for 1 char. place inside ' '

// N * 2 byte

string str = "string"; // place inside " ". It is 12 byte.
Console.WriteLine("str size = " + str.Length * 2);


// string is char list

Console.WriteLine(str[0]);


// operations

Console.WriteLine("String 1." + " " + "String 2."); // concatenation

// read console

Console.Write("Enter something here: ");
string userInput = Console.ReadLine();

// unsafe conversion

//int unsafeInput = int.Parse(userInput); // work only with 0-9
//Console.WriteLine("Result of int.Parse() " + unsafeInput);

// safe conversion

int safeInput;
int.TryParse(userInput, out safeInput);
Console.WriteLine("Result of int.TryParse() " + safeInput);

// to string conversion

int i = 102323;
string intWithString = i + ""; // v1
string intToString = i.ToString();
string intWithDollar = $"{i}";

Console.WriteLine(intWithString);
Console.WriteLine(intToString);
Console.WriteLine(intWithDollar);

// Substring

Console.WriteLine(intToString.Substring(2, 2));

// IndexOf

Console.WriteLine(intToString.IndexOf("23"));

// ToLower

string upper = "WALL";
Console.WriteLine(upper.ToLower());

// ToUpper

string lower = "trees";
Console.WriteLine(lower.ToUpper());

// string.Format

string strangeThings = string.Format("User input: {0}", userInput);
Console.WriteLine(strangeThings);

// bonus

Console.WriteLine("Bonus: {0}", userInput);

// IsNullOrEmpty

string.IsNullOrEmpty("Is not empty.");
string.IsNullOrEmpty(""); // is empty

// null

string isNothing = null; // it's a philosophy
string isNothingToo; 
