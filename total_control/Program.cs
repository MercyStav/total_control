// Домашняя контрольная задача.
const int charLimit = 3;

string[] startArray = { "Hello", "2", "World", ":-)", "кукусики", "123" };

string[] newArray = getNewArray(startArray, charLimit);


Console.Clear();
Console.WriteLine("start array:");
printArray(startArray);

Console.WriteLine("\nnew array:");
printArray(newArray);


void printArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}\t");
        }
        Console.WriteLine();
    }
}

int getSizeNewArray(string[] array, int charLimit)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= charLimit)
        {
            result++;
        }
    }

    return result;
}

string[] getNewArray(string[] startArray, int charLimit)
{
    string[] newArray = { };

    int sizeNewArray = getSizeNewArray(startArray, charLimit);

    if (sizeNewArray > 0)
    {
        newArray = new string[sizeNewArray];

        int i, k;
        for (i = k = 0; i < startArray.Length && k < newArray.Length; i++)
        {
            if (startArray[i].Length <= charLimit)
            {
                newArray[k] = startArray[i];
                k++;
            }
        }
    }

    return newArray;
}