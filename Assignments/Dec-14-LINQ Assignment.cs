using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = {3, 5, 99, 100, 36, 70, 65, 60, 110, 51, 35, 8, 4, 9, 7, 34};
    
    public void LearnToQuery()
    {
        //List all even numbers from "numbers" array
        var evenNumbers = numbers.Where(x => x / 2 == 0);

        foreach (int x in evenNumbers)
        {
            Console.WriteLine(x);
        } 

        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);

        foreach (int x in oddNumbers)
        {
            Console.WriteLine(x);
        } 

        // List multiples of 5 and 7 from "numbers"
        var multipleOf5N7 = numbers.Where(x => x / 5 == 0 && x / 7 == 0);

        foreach (int x in multipleOf5N7)
        {
            Console.WriteLine(x);
        } 

        // List all items less than 100 and ends with 0, from "numbers"
        var lessThanHunNEndWithZero = numbers.Where(x => x < 100 && x / 10 == 0);

        foreach (int x in lessThanHunNEndWithZero)
        {
            Console.WriteLine(x);
        } 
    }
}