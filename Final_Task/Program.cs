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
/// Добавляем commit

string[] arrString = {"Russia", "Denmark", "Kazan"};

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