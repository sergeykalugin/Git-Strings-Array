using System;

class Program
{
    static void Main(string[] args)
    {
        // Исходный массив строк
        string[] originalArray = { "hello", "to", "the", "world", "of", "C#", "!", "1234", "123", "hi" };
        
        // Вызов функции для фильтрации массива и получение результата
        string[] filteredArray = FilterStrings(originalArray);
        
        // Вывод отфильтрованного массива
        Console.WriteLine("Filtered Array:");
        foreach (var str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }
}