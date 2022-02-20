

// All math with type less than int returns INTEGER!
// All math with type less than int returns INTEGER!
// All math with type less than int returns INTEGER!

byte b1, b2;
b1 = 10; b2 = 2;

byte backToByte = (byte)(b1 + b2);

Console.WriteLine(backToByte);

++b1;
Console.WriteLine(b1);


// %

int remOfB1AndB2 = b1 % b2;
Console.WriteLine(remOfB1AndB2);


// Math.Pow()

double mathPow = Math.Pow(b1, b2);
Console.WriteLine(mathPow);


// Math.Sqrt()

double mathSqrt = Math.Sqrt(b1);
Console.WriteLine(mathSqrt);





