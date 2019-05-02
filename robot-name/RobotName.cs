using System;
using System.Collections.Generic;

public class Robot
{

    public static List<string> NamesInUse = new List<string>();
    public Robot()
    {
        Name = GenerateString();
    }

    public string Name { get; private set; }
        

   public void Reset()
   {
        NamesInUse.Remove(Name);
        Name = GenerateString();
   }


    public string GenerateString()
    {
        var random = new Random();
        const string chars = "QWERTYUIOPASDFGHJKLZXCVBNM";
        const string numbers = "0123456789";
        string string1 = "";

        string1 = chars[random.Next(0,chars.Length)].ToString() + chars[random.Next(0,chars.Length)] + numbers[random.Next(0,numbers.Length)] + numbers[random.Next(0, numbers.Length)] + numbers[random.Next(0, numbers.Length)];
      
        if (NamesInUse.Contains(string1))
        {
            string1 = GenerateString();
        }

        NamesInUse.Add(string1);

        return string1;
    }
}