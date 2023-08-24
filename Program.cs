string[] array = {"Hello", "2", "world", ":-)", "Russia", "Denmark", "Kazan" };

int max_word_length = 3;

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
