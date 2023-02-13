Console.Clear();

string[] CreateStringArray()
{
    string[] arr = new String[3];
    for (int i=0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1} строку массива");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintStringArray(string[] arr)
{
    Console.Write($"[");
    for (int i=0; i < arr.Length; i++)
    {
        Console.Write($"'{arr[i]}'");
    }
    Console.Write($"]");
    Console.WriteLine();
}

string[] SortStringArray(string[] arr)
{
    int leng = 0;
    for (int i=0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) leng++;
    }
    string[] arrFin = new string[leng];
    int index = 0;
    for (int n=0; n < arr.Length; n++)
    {
        if (arr[n].Length < 4)
        {
            arrFin[index++] = arr[n];
        }
    }
    return arrFin;
}

string[] arrStart = CreateStringArray();
PrintStringArray(arrStart);
arrStart = SortStringArray(arrStart);
PrintStringArray(arrStart);