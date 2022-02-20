
byte @byte = 252;

// If less than N.

byte cicle = 0;

while (@byte < 255)
{
    Console.WriteLine($"@byte = {@byte} in cicle {cicle};");
    @byte++;

    if (@byte == 255)
    {
        Console.WriteLine($"@byte = {@byte} in cicle {cicle};");
        break;
    }

    cicle++;
}



// To check overflow.

@byte = 252;

checked
{
    while (@byte < 256)
    {
        Console.WriteLine(@byte);
        try
        {   
            @byte++;
        }
        catch (OverflowException e)
        {
            Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            break;
        }
    }
}