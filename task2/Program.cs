using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        char[] delimiters = { ' ', '.', ',', ';', ':', '!', '?', '-', '_', '(', ')', '[', ']', '{', '}', '\"', '\'' };
        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        int maxLength = words.Max(word => word.Length);

        List<string> longestWords = words.Where(word => word.Length == maxLength).ToList();

        Console.WriteLine("Самые длинные слова:");
        foreach (string word in longestWords)
        {
            Console.WriteLine(word);
        }
    }
}
