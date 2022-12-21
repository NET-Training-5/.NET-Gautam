using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = {3, 5, 99, 100, 36, 70, 65, 60, 110, 51, 35, 8, 4, 9, 7, 34};
    
    public void LearnToQuery()
    {
        //List all even numbers from "numbers" array

        //This is Imperative way
        //List<int> evens = new List<int>();
        //foreach(var num in numbers)
        //{
        //    if(num / 2 == 0)
        //   {
        //       evens.Add(num);
        //    }    
        //}
        // Declarative way of doing things.
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        PrintValues(evenNumbers, "Even Numbers: ");

        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);
        PrintValues(oddNumbers, "Odd Numbers divisible by 3: ");

        // List multiples of 5 and 7 from "numbers"
        var multipleOf5N7 = numbers.Where(x => x % 5 == 0 && x % 7 == 0);
        PrintValues(multipleOf5N7, "Multiple of 5 and 7: ");

        // List all items less than 100 and ends with 0, from "numbers"
        var lessThanHunNEndWithZero = numbers.Where(x => x < 100 && x.ToString().EndsWith("0"));
        PrintValues(lessThanHunNEndWithZero, "Less than 100 N Ends with 0: ");

        // Print squares of all items in numbers array
        var squares = numbers.Select(x => x * x);
        PrintValues(squares, "Squares: ");

        //Print square root of all item less than 50
        var lessThan50 = numbers.Where(x => x < 50).Select(x => Math.Sqrt(x).ToString("N2"));

        // Expression syntax
        var sqRoots2 = from x in numbers
                        where x < 50
                        select Math.Round(Math.Sqrt(x), 2);
        PrintValues(lessThan50, "Square roots (< 50): ");

        //Sort numbers
        var numbersSorted = numbers.Order();

     }

    void PrintValues<T>(IEnumerable<T> items, string label)
    {
        Console.Write($"\n{label}");
        foreach (var x in items)
            Console.Write(x + " ");   
    }
}