string[] array1 = new string[6] { "1234", "000", "hello", "-2", "result", "GB" };
string[] array2 = new string[array1.Length];

void PrintArray(string[] array)
    {
    for(int i = 0;i < array.Length;i++)
        {
        Console.Write($"{array[i]} ");
        }
    Console.WriteLine();
    }

PrintArray(array1);