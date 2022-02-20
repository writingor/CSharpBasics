
// area inside main

byte b1 = 1;
byte b2 = 2;

Console.WriteLine($"b1 = { b1 }");
Console.WriteLine($"b2 from main area before the local area 1 = { b2 }");

//local area 1
{
    // byte b1 = 1; // error
    b2 = 4;
    byte b3 = 3;

    Console.WriteLine($"b2 from local area 1 = { b2 }");
    Console.WriteLine($"b3 from local area 1 = { b3 }");
}

//local area 2
{
    byte b3 = 5;
    byte b4 = b2;

    Console.WriteLine($"b3 from local area 2 = { b3 }");
    Console.WriteLine($"b4 = { b4 }");
}

Console.WriteLine($"b2 from main area after the local area 1 = { b2 }");
//Console.WriteLine(b3); // error

