using System;


public class Program
{
    static void Main()
    {

        static bool IsAlmostHappy(string number)
        {
            var intArray = new int[number.Length];
            for (int i = 0; i < intArray.Length; i++) intArray[i] = Convert.ToInt32(Convert.ToString(number[i]));

            intArray[^1]++;
            if (intArray[0] + intArray[2] + intArray[4] == intArray[1] + intArray[3] + intArray[5]) return true;
            intArray[^1] -= 2;
            return (intArray[0] + intArray[2] + intArray[4] == intArray[1] + intArray[3] + intArray[5]);
            
        }


        Console.WriteLine(IsAlmostHappy("132231")); //Tests
        Console.WriteLine(IsAlmostHappy("132232"));
        Console.WriteLine(IsAlmostHappy("132230"));
        Console.WriteLine(IsAlmostHappy("132239"));
    }
}
