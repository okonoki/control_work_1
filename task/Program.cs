string GetStr(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] GetArrayFromStr(string elements)
{
    string[] array = elements.Split(", ");
    return array;
}

int GetNumbers(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

string[] GetResultArray(string[] array, int size)
{
    string[] resArray = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resArray[j] = array[i];
            j++;
        }
    }
    return resArray;
}

string elements = GetStr("Введите элементы массива через запятую: ");
string[] array = GetArrayFromStr(elements);
int size = GetNumbers(array);
string[] resArray = GetResultArray(array, size);
Console.WriteLine(String.Join(", ", resArray));