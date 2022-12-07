class Method
{
    //Simplest possible: returns nothing, take no argument

    void PrintMessage()
    {
        Console.WriteLine("Nepal is beautiful")
    }
    //Returns nothing, takes some arguments

    void Print(string message)
    {
        Console.WriteLine(message);
    }

    //Returns something, takes no arguments
    public string GetMessage()
    {
        var city = "Kathmandu";
        return city;
    }
    //Return something, take some arguments

    public double Add(double a, double b)
    {
        return a + b;
    }
}
