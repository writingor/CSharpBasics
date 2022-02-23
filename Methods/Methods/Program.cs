

#region Function returns a result.


// It takes NO parameters and returns a result.

static int Sum()
{
    byte b1 = 1;
    byte b2 = 2;

    return b1 + b2;
}

int sum = Sum();
Console.WriteLine(sum);


// It takes parameters and returns a result.

static int Difference(byte b1, byte b2)
{
    return b1 - b2;
}

int difference = Difference(1, 2);
Console.WriteLine(difference);

#endregion



#region Procedure do not return a result.


// It takes NO parameters and do not return a result.

static void SayHello()
{
    Console.WriteLine("Hello!");
}

SayHello();

// It takes parameters and do not return a result.

static void SayHelloInYellowLetters(string word)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(word);
    Console.ForegroundColor = ConsoleColor.White;
}

SayHelloInYellowLetters("Hello!");

#endregion



#region Method with reference


Console.WriteLine();
Console.WriteLine("Method with reference (ref):");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;

// This is a function. The function returns something. Ref in the function is also returned.

static int MethodWithRef(ref int i)
{
    ++i;
    
    int result = i + 10;

    return result;
}

int inputOne = 1;

Console.WriteLine("Before calling MethodWithRef() inputOne = {0}", inputOne);

int resultOne = MethodWithRef(ref inputOne);

Console.WriteLine("After calling MethodWithRef() inputOne = {0}, result(from return) = {1}.", inputOne, resultOne);

Console.ForegroundColor = ConsoleColor.White;

#endregion



#region Method with out


Console.WriteLine();
Console.WriteLine("Method with reference (out):");
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;

// This is a function. The function returns something. Out in the function is also MUST BE returned.

static int MethodWithOut(out int i)
{
    // ++i or result = i + 10 don't work
    i = 3;

    int result = i + 10;

    return result;
}

int inputTwo = 1;

Console.WriteLine("Before calling MethodWithOut() input = {0}", inputTwo);

int resultTwo = MethodWithOut(out inputTwo);

Console.WriteLine("After calling MethodWithOut() inputTwo = {0}, result(from return) = {1}.", inputTwo, resultTwo);

Console.ForegroundColor = ConsoleColor.White;

#endregion