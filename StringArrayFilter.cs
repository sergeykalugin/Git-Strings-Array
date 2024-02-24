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
     // Функция для фильтрации массива строк по условию
    static string[] FilterStrings(string[] inputArray)
    {
        // Подсчет количества строк
        int count = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3) count++;
        }
        
        // Создание и заполнение результирующего массива
        string[] resultArray = new string[count];
        int index = 0;
        foreach (var str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }
        
        return resultArray;
    }
}