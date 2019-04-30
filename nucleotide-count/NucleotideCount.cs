using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> dicionario = new Dictionary<char, int>
        {
            {'A', 0 },
            {'C', 0 },
            {'G', 0 },
            {'T', 0 }
        };    
        
        foreach (char w in sequence)
        {
            if (dicionario.ContainsKey(w))
            {
                dicionario[w]++;
            }
            else
            {
                throw new ArgumentException();
            }        
        } 
        
      
        return dicionario;
    }
}