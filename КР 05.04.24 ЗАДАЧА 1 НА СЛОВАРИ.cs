using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dict = new Dictionary<string, int>();
        dict["Moscow"] = 12000000;
        dict["London"] = 8000000; 
        dict["Neftekamsk"] = 700000;
        dict["Ufa"] = 1300000;
        dict["Meleuz"] = 60000;
        dict["Belgorod"] = 40000;

        foreach(var key in dict.Keys) 
            if (dict[key] > 1000000) Console.WriteLine(dict[key]);
    }
}
