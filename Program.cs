using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Mike", "Ana", "Felipe" };
            foreach (var thing in names)
            {
                Console.WriteLine($"Hello {thing.ToLower()}!");
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Add("Mickey");
            names.Remove("Ana");
            names.Remove("Felipe");
            names.Remove("Mike");
            // {
            //     Console.WriteLine($"Hello {name.ToUpper}!");
            // }
            // foreach (var thing in names)
            // {
                Console.WriteLine($"Hello {names[1].ToLower()}!");
            // }
        }
    }
}