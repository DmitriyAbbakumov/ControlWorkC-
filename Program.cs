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