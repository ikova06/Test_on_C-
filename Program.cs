string[] array = {"Hello", "2", "world", ":-)", "Russia", "Denmark", "Kazan" };

int max_word_length = 3;

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("В массиве пусто");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}


string[] ShortArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= max_word_length)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}



void PrintTask(string[] array)
 {
    PrintArray(array);
    string[] shortArray = ShortArray(array);
    Console.WriteLine($"Новый массив с элементами из {max_word_length} или меньше символов: ");
    PrintArray(shortArray);
    Console.WriteLine();
}
PrintTask(array);
