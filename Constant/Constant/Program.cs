﻿

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

// 256 toByteCasting = 0, 257 = 1, 267 = 11... :)
// 256 is  0000 0000  0000 0000  0000 0001  0000 0000 and byte is 0000 0000
// 257 is  0000 0000  0000 0000  0000 0001  0000 0001 and byte is 0000 0001
// 267 is  0000 0000  0000 0000  0000 0001  0000 1011 and byte is 0000 1011

// -256 toByteCasting = 0, 257 = 255, 267 = 245... :D
// 256 is  1000 0000  0000 0000  0000 0001  0000 0000 and byte is 0000 0000
// 257 is  1000 0000  0000 0000  0000 0001  0000 0001 and byte is ... 1111 1111 WHY?
// 267 is  1000 0000  0000 0000  0000 0001  0000 1011 and byte is ... 1111 0101 WHY?

byte toByteCasting = (byte) toIntCasting;

Console.WriteLine(toByteCasting);