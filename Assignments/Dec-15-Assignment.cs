using System;
using System.Collections.Generic;
using System.Linq;

class Countries
{
   string[] countries = {"China", "India", "United States", "Indonesia", "Pakistan", "Nigeria", "Brazil", "Bangladesh", "Russia", "Mexico", "Japan", "Philippines", "Ethiopia", "Egypt", "DR Congo", "Vietnam", "Iran", "Turkey", "Germany", "France"};
    
    public void getCountriesFromList()
    {
       var getCountriesStartingWithN = from x in countries
                            where x.StartsWith("N")
                            select x;
        DisplayValues(getCountriesStartingWithN, "Countries starting with letter N:");
    
        var lessThanFour = from x in countries
                            where x.Length < 5
                            select x;
        DisplayValues(lessThanFour, "Countries having length less than or equal to 4:");
    
        var countriesInUppercase = from x in countries
                                    select(x.ToUpper());
        DisplayValues(countriesInUppercase, "Converting Countries in Uppercase:");
    }
    void DisplayValues<T>(IEnumerable<T> items, string label)
    {
        Console.Write($"\n{label}");
        foreach (var x in items)
            Console.Write(x + " ");
    }
}