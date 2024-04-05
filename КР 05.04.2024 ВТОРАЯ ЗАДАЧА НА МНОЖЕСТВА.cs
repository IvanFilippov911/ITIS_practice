using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var words = new string[] { "ababa", "ababa", "lala", "lolo", "gagaga", "gagaga" };
        
        foreach (var i in GetDistinctValues1<string>(words)) { Console.WriteLine(i); }
        foreach (var i in GetDistinctValues2<string>(words)) { Console.WriteLine(i); }
    }
    private static T[] GetDistinctValues1<T>(T[] values) // первый способ 
    {
        var listResult = new List<T>();

        foreach (var valueArray in values)
        {
            var flag = false;
            foreach (var valueList in listResult)
            {
                if (valueArray.Equals(valueList))
                {
                    flag = true;
                    break;
                };
            }
            if (!flag) listResult.Add(valueArray);
        }
        return listResult.ToArray();
    }

    private static T[] GetDistinctValues2<T>(T[] values) // второй способ
    {
        var set = new HashSet<T>();
        foreach (var value in values)
            set.Add(value);
        return set.ToArray();
    }
}
