/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоночальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [ ]

*/
System.Console.Write("Введите количество строк в  первоначальном массиве:\t");
int elementsCount = int.Parse(Console.ReadLine());

string[][] jagged_arr = new string[elementsCount][];

// Initialize the elements
jagged_arr[0] = new string[] { "hello" };
jagged_arr[1] = new string[] { "2" };
jagged_arr[2] = new string[] { "world" };
jagged_arr[3] = new string[] { ":-)" };

// Display the array elements:
for (int i = 0; i < jagged_arr.Length; i++)
{

    // Print the row number
   // System.Console.Write("Слово({0}): ", i);

    for (int j = 0; j < jagged_arr[i].Length; j++)
    {
        // Print the elements in the row
       // System.Console.Write("{0} ", jagged_arr[i][j]);

        string text = String.Empty;
        text = jagged_arr[i][j];

        int length = text.Length;

        string result = String.Empty;
        for (int k = 0; k < length; k++)
        {
            if (length < 4)
            {
                result = result + $"{text[k]}";

            }
            else break;
        }
        System.Console.Write($"{result}" + "  ");


    }
   // System.Console.WriteLine();
}
/*
string text = String.Empty;
    text = jagged_arr[i][j];

    int length = text.Length;

    string result = String.Empty;
    for (int k = 0; k < length; k++)
    {
        if (length < 4)
        {
            result = result + $"{text[k]}";

        }
        else break;
    }
    System.Console.Write($"{result}" + " ");

    */