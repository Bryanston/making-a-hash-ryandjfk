// Console template
using System;
class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.Clear();

        Console.Write("Enter key: ");
        string userKey = Console.ReadLine();

        Console.Write("Enter limit: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int total = 0;
        foreach(char c in userKey)
        {
            total += (int)c;
        }

        total = total * total;

        //Console.WriteLine(total);
        string numString = Convert.ToString(total);
        
        int middle = numString.Length / 2;
        //Console.WriteLine(middle);

        string middleTwo = numString.Substring(middle, 2);
        
        int numMiddleTwo = Convert.ToInt32(middleTwo);

        int hashValue = numMiddleTwo % limit;

        Console.WriteLine($"Hash value is {hashValue}.");
        
        
    }
}
