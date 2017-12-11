using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars, arrays, foreach loops
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
            Console.WriteLine($"Hello {names[1].ToLower()}!");
            var stuff = new List<string> { "pencils", "markers", "paper" };
            Console.WriteLine("hi there!");

            string newStuff = "pencils";
            Console.WriteLine(newStuff);
            newStuff = "pens";
            Console.WriteLine("hi there, I see you\'ve got " + newStuff);  // concatenation
            Console.WriteLine($"hi there, I see you have a {newStuff}");
            string item1 = "milk";
            string item2 = "oranges";
            string item3 = "juice";
            Console.WriteLine($"My grocery list includes {item1}, {item2}, and {item3.Length}.");

            // concatenating string vars
            string groceries = item1 + ", " + item2 + ", and " + item3;
            Console.WriteLine($"... And this is my concatenated list: {groceries}.");

            // trimming strings (eliminating spaces)
            string message = "   Hello world   ";
            Console.WriteLine($"[{message}]");
            string trimmedMessage = message.TrimStart();
            string trimmedMessage2 = message.TrimEnd();
            Console.WriteLine($"[{trimmedMessage}]");
            Console.WriteLine($"[{trimmedMessage2}]");
            string trimmedMessage3 = message.TrimStart().TrimEnd();
            Console.WriteLine($"[{trimmedMessage3}]");
            string trimmedMessage4 = message.Trim();
            Console.WriteLine($"[{trimmedMessage4}]");

            // replacing strings 
            trimmedMessage4 = trimmedMessage4.Replace("Hello", "hi there");
            Console.WriteLine($"[{trimmedMessage4}]");

            // searching for substrings, returning booleans
            string lyric = "All in all we\'re just another brick in the wall.";
            Console.WriteLine($"{lyric.Contains("brick")}");
            Console.WriteLine($"{lyric.Contains("cement")}");
            var stringBoolean = lyric.Contains("brick");
            Console.WriteLine(stringBoolean);
            Console.WriteLine(lyric.StartsWith("All"));
            Console.WriteLine(lyric.StartsWith("None"));

            // numbers: int
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) % c;
            Console.WriteLine($"Remainder of {a} + {b} / {c} = " + d);
            int max = int.MaxValue;
            int what = max + 3;
            Console.WriteLine($"Max + 3 = {what}");

        }
    }
}


// $: dotnet run