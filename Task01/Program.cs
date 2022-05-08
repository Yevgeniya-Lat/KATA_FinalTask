/*

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [ ]

*/



string[] arrString = {"1234", "1567", "-2", "computer science"};

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
