using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                sum += int.Parse(c.ToString());
            }
        }
        Console.WriteLine("Сумма всех цифр в строке: " + sum);
    }
}
