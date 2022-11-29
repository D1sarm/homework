string[] arr1 = new string[5] { "Hello", "2", "world", ":-)", "-2" };
string[] arr2 = new string[arr1.Length];
void Find(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void Printarr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Find(arr1, arr2);
Printarr(arr2);