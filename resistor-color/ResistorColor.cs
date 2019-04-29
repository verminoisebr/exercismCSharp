using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {        
        int colorCode = 0;
        
        foreach (string s in Colors())
        {            
            if (s == color)
            {
                break;                
            }
            colorCode++;
        }
        return colorCode;
    }

    public static string[] Colors()
    {
        string[] colors = new string[] {"black", "brown","red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        return colors;
    }
}