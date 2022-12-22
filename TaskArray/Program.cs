void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

string[] MakeNewArray(string[] arr)
{
    int size = arr.Length;
    string[] newArr = new string[size];
    int count = default;
    int max = 3;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= max)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref newArr, count);
    return newArr;
}

Console.WriteLine("Введите несколько слов, символов или чисел через пробел (привет :) пока 3): ");
string[] array = Console.ReadLine().Split(' ').ToArray();
string[] newArray = MakeNewArray(array);
Console.WriteLine("Элементы, длина которых меньше или равна трём символам: ");
PrintArray(newArray);
