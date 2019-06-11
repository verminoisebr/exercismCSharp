using System;
using System.Collections.Generic;


public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        char tempChar = new char();
        string result = new string("");

        foreach (char i in text)
        {
            if(alphabet.Contains(i))
            {
                int loc = alphabet.IndexOf(i) + shiftKey;
                if (loc >= alphabet.Length)
                    {
                        loc = loc - alphabet.Length;
                    }
                tempChar = alphabet[loc];
                result += tempChar;
            } else if (alphabetUpper.Contains(i))
            {
                int loc = alphabetUpper.IndexOf(i) + shiftKey;
                if (loc >= alphabetUpper.Length)
                    {
                        loc = loc - alphabetUpper.Length;
                    }
                tempChar = alphabetUpper[loc];
                result += tempChar;
            } else
            {
                result += i;
            }
        }
        return result;
    }
}