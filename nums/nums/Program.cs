
using System.Text.RegularExpressions;


/*
 * 
 * Integers
 *
*/

// 1 байт

byte b = 255; // можно использовать для возраста человека, количества дней в месяце
//byte bMinus = -255; // don't work
// sbyte sb = 255; // don't work
sbyte sb = 127; 
sbyte sbMinus = -128;
Console.WriteLine("Value of b: " + b);
Console.WriteLine("Value of sb: " + sb);
Console.WriteLine("Value of sbMinus: " + sbMinus);

// 2 байта

short s = short.MaxValue; // 1111111111111111
ushort us = ushort.MaxValue;
Console.WriteLine("MaxValue of short data type: " + s);
Console.WriteLine("MaxValue of ushort data type: " + us);

// 4 байта

int i = int.MaxValue;
uint ui = uint.MaxValue;
Console.WriteLine("MaxValue of int data type: " + i);
Console.WriteLine("MaxValue of uint data type: " + ui);

// 8 байт

long l = long.MaxValue;
ulong ul = ulong.MaxValue;
Console.WriteLine("MaxValue of long data type: " + l);
Console.WriteLine("MaxValue of ulong data type: " + ul);


/*
 * 
 * Calc
 *
*/

int x = 10;
int y = 1;
int sum = x + y;
Console.WriteLine("x = " + x + ", y = " + y + ", sum = " + sum);

int z = 10;
int w = 5;
int dif = z - w;
Console.WriteLine($"z = {z}, w = {w}, dif = {dif}");


/*
 * 
 * Fractional numbers
 *
*/

// 4 байта

float f = float.MaxValue;
Console.WriteLine($"MaxValue of the float data type: {f}");

// 8 байт

double d = double.MaxValue;
Console.WriteLine($"MaxValue of the double data type: {d}");

// 16 байт

decimal dm = decimal.MaxValue;
Console.WriteLine($"MaxValue of the decimal data type: {dm}");

