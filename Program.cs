int FillFirstArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        arr[i] = Console.ReadLine();
        if (arr[i].Length <= 3) count++;
    }
    return count;
}
void FillSecondArray(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"'{arr[i]}' ");
    }
    Console.Write("]");
}
Console.WriteLine("Введите количество строк в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] FirstArray = new string[length];
int count = FillFirstArray(FirstArray);
string[] SecondArray = new string[count];
FillSecondArray(FirstArray, SecondArray);
PrintArray(FirstArray);
Console.WriteLine();
PrintArray(SecondArray);