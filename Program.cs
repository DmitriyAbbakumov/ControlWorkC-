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