Console.Clear();

string[] ArrayString()
{
    Console.Write("Введите элементы массива через запятую: ");
    return Console.ReadLine()!.Replace("\"", "").Split(", ").ToArray();
}

int SizeArray2(string[] array, int n)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] SecondArray(string[] array, int n)
{
    string[] result = new string[SizeArray2(array, n)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= n)
        {
            result[j] =  array[i];
            j++;           
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
    Console.WriteLine();
}


string[] array1 = ArrayString();
PrintArray(array1);
string[] array2 = SecondArray(array1, 3);
PrintArray(array2);

