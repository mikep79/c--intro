using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            // // vars, arrays, foreach loops
            // var names = new List<string> { "Mike", "Ana", "Felipe" };
            // foreach (var thing in names)
            // {
            //     Console.WriteLine($"Hello {thing.ToLower()}!");
            // }
            // Console.WriteLine();
            // names.Add("Maria");
            // names.Add("Bill");
            // names.Add("Mickey");
            // names.Remove("Ana");
            // names.Remove("Felipe");
            // names.Remove("Mike");
            // Console.WriteLine($"Hello {names[1].ToLower()}!");
            // var stuff = new List<string> { "pencils", "markers", "paper" };
            // Console.WriteLine("hi there!");

            // string newStuff = "pencils";
            // Console.WriteLine(newStuff);
            // newStuff = "pens";
            // Console.WriteLine("hi there, I see you\'ve got " + newStuff);  // concatenation
            // Console.WriteLine($"hi there, I see you have a {newStuff}");
            // string item1 = "milk";
            // string item2 = "oranges";
            // string item3 = "juice";
            // Console.WriteLine($"My grocery list includes {item1}, {item2}, and {item3.Length}.");

            // // concatenating string vars
            // string groceries = item1 + ", " + item2 + ", and " + item3;
            // Console.WriteLine($"... And this is my concatenated list: {groceries}.");

            // // trimming strings (eliminating spaces)
            // string message = "   Hello world   ";
            // Console.WriteLine($"[{message}]");
            // string trimmedMessage = message.TrimStart();
            // string trimmedMessage2 = message.TrimEnd();
            // Console.WriteLine($"[{trimmedMessage}]");
            // Console.WriteLine($"[{trimmedMessage2}]");
            // string trimmedMessage3 = message.TrimStart().TrimEnd();
            // Console.WriteLine($"[{trimmedMessage3}]");
            // string trimmedMessage4 = message.Trim();
            // Console.WriteLine($"[{trimmedMessage4}]");

            // // replacing strings 
            // trimmedMessage4 = trimmedMessage4.Replace("Hello", "hi there");
            // Console.WriteLine($"[{trimmedMessage4}]");

            // // searching for substrings, returning booleans
            // string lyric = "All in all we\'re just another brick in the wall.";
            // Console.WriteLine($"{lyric.Contains("brick")}");
            // Console.WriteLine($"{lyric.Contains("cement")}");
            // var stringBoolean = lyric.Contains("brick");
            // Console.WriteLine(stringBoolean);
            // Console.WriteLine(lyric.StartsWith("All"));
            // Console.WriteLine(lyric.StartsWith("None"));

            // // numbers: int
            // int a = 7;
            // int b = 4;
            // int c = 3;
            // int d = (a + b) % c;
            // Console.WriteLine($"Remainder of {a} + {b} / {c} = " + d);
            // int max = int.MaxValue;
            // int what = max + 3;
            // Console.WriteLine($"Max + 3 = {what}");

            // // double precision floating point numbers
            // double x = 5;
            // double y = 4;
            // double z = 2;
            // double q = (x + y) / z;
            // Console.WriteLine($"(5 + 4) / 2 = {q}");

            // double aa = 19;
            // double bb = 23;
            // double cc = 8;
            // double dd = (aa + bb) / cc;
            // Console.WriteLine("dd = " + dd);

            // double dmax = double.MaxValue;
            // double dmin = double.MinValue;
            // Console.WriteLine($"Double Max is {dmax} and min is {dmin}");

            // // double oneThird = 1.0/3.0;
            // // Console.WriteLine("One third: " + oneThird);

            // decimal decMax = decimal.MaxValue;
            // decimal decMin = decimal.MinValue;
            // Console.WriteLine($"Decimal max and min are {decMax} and {decMin}.");

            // double a = 1.0;
            // double b = 3.0;
            // Console.WriteLine(a / b);

            // decimal c = 1.0M;
            // decimal d = 3.0M;
            // Console.WriteLine(c / d);
            // Now that you've seen the different numeric types, write code that calculates the area of a circle whose radius is 2.50 inches. Remember that the area of a circle is the radius squared multiplied by PI. One hint: .NET contains a constant for PI, Math.PI that you can use for that value.

            // double r = 2.50;
            // double area = r*r;
            // double pi = Math.PI;
            // Console.WriteLine($"Area of circle =" + area*pi);

            // // if else statements
            // int a = 5;
            // int b = 8;
            // int c = 20;
            // if (a + b > 14)
            // {
            //     Console.WriteLine("And how!");
            // }
            // else if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10.");
            // }
            // else 
            // {
            //     Console.WriteLine("nope. :/");
            // }

            // // Now that you've seen the if statement and the looping constructs in the C# language, see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3.
            // int i = 0;
            // int sum = 0;
            // do {
            //     if (i % 3 == 0 ){
            //         sum += i;
            //     }
            //     i++;
            // } while (i < 21);
            // Console.WriteLine($"Sum is {sum}");

            // lists of names, sorting
            // var names = new List<string> {"Mike", "Junior", "Ellie"};
            // Console.WriteLine(names.Count);

            // var index = names.IndexOf("Junior");
            // if (index != -1){
            //     Console.WriteLine($"The name {names[index]} is at index {index}.");
            // }
            // var notFound = names.IndexOf("Not Found");
            // Console.WriteLine($"When an item not found, IndexOf returns {notFound}.");
            
            // names.Sort();
            // foreach (var name in names){
            //     Console.WriteLine(name);
            // }

            // var fibonacciNumbers = new List<int> {1, 1};
            // var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            // var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            // fibonacciNumbers.Add(previous + previous2);
            // foreach(var numb in fibonacciNumbers){
            //     Console.WriteLine(numb);
            // }

            // Try and write the code to generate the first 20 numbers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)
            var fibNumbs = new List<int> {1, 1};

            for (int i = 0; i < 18; i++) {
                var currentIndex = fibNumbs.Count - 1;
                var previousIndex = fibNumbs.Count - 2;
                fibNumbs.Add(fibNumbs[currentIndex] + fibNumbs[previousIndex]);
            }

            Console.WriteLine($"The {fibNumbs.Count}'th fib numb is: {fibNumbs[fibNumbs.Count-1]}.");
            foreach (var numb in fibNumbs){
                Console.WriteLine(numb);
            }
            

            
        }
    }
}


// $: dotnet run