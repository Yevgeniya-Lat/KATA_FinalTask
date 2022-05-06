string[] arrString = { "hello", "2", "world", ":-)" };

for (int i = 0; i < arrString.Length; i++)
{
    string text = String.Empty;
    text = arrString[i];

    int length = text.Length;

    string result = String.Empty;
    for (int j = 0; j < length; j++)
    {
        if (length < 4)
        {
            result = result + $"{text[j]}";

        }
        else break;
    }
    System.Console.Write($"{result}" + " ");

}