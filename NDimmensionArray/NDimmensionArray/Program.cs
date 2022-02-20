

byte[] oneDimmensionArray = { 1, 2, 3 };


byte[,] twoDimmensionArray = new byte[3, 3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};


byte[,,] threeDimmensionArray = new byte[3, 3, 3];

threeDimmensionArray[0, 0, 0] = 1;
threeDimmensionArray[0, 0, 1] = 2;
threeDimmensionArray[1, 1, 1] = 3;


# region Calendar

byte[][] months = new byte[12][];
// array in array
months[0] = new byte[31]; // january
months[1] = new byte[29]; // february
months[3] = new byte[31]; // march
//...

# endregion
