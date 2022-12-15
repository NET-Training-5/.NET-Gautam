using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = {3, 5, 8, 4, 9, 7, 34};
    
    void LearnToQueary()
    {
        //List all even numbers from "numbers" array

        //This is Imperative way
        List<int> evens = new List<int>();
        foreach(var num in numbers)
        {
            if(num / 2 == 0)
            {
                evens.Add(num);
            }    
        }
        // Declarative way of doing things.
        var evenNumbers = numbers.Where(num => num / 2 == 0);

        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);
    }
}