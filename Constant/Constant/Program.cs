

const int constMust = 255;

if (constMust < 256)
{
    byte constIntMustBeByteIfFit = constMust;

    Console.WriteLine(constIntMustBeByteIfFit);
}

const float absoluteZero = -273.15f;


Console.WriteLine(absoluteZero);

int toIntCasting = (int) absoluteZero;

Console.WriteLine(toIntCasting);


byte toByteCasting = (byte) toIntCasting;

Console.WriteLine(toByteCasting);
