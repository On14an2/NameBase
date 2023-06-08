using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>();

        Console.WriteLine("Введите имена (для завершения введите пустую строку):");

        while (true)
        {
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || name.Trim().Length == 0)
                break;

            names.Add(name);
        }

        Console.WriteLine("Введите имя для поиска:");
        string searchName = Console.ReadLine();

        if (names.Contains(searchName))
        {
            Console.WriteLine($"Имя {searchName} найдено в списке.");
        }
        else
        {
            Console.WriteLine("0");
        }

        Console.ReadLine();
    }
}