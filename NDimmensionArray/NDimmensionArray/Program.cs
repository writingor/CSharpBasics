
byte[] exampleArray = new byte[100]; // big array

byte[] oneDimmensionArray = { 1, 2, 3 }; // == byte[] oneDimmensionArray = new byte[] { 1, 2, 3 };


int[,] twoDimmensionArray = new int[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};

int num = 1;

for (int i = 0; i < 3; i++)
{
    for (int n = 0; n < 3; n++)
    {
        twoDimmensionArray[i, n] = num;
        num++;
    }
}

for (int i = 0; i < 3; i++)  // i < twoDimmensionArray.GetLength(i) not have more array
{
    for (int n = 0; n < 3; n++)  
    {
        Console.Write("{0} ", twoDimmensionArray[i, n]);
    }
    Console.WriteLine();
}


byte[,,] threeDimmensionArray = new byte[3, 3, 3];

threeDimmensionArray[0, 0, 0] = 1;
threeDimmensionArray[0, 0, 1] = 2;
threeDimmensionArray[1, 1, 1] = 3;


# region Calendar (Jagged Array)

byte[][] months = new byte[12][];
// array in array
months[0] = new byte[31]; // january
months[1] = new byte[29]; // february
months[3] = new byte[31]; // march
//...

# endregion
