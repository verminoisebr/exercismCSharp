using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> lista;
    public HighScores(List<int> list) => this.lista = list;
    
    public List<int> Scores() => lista;
    
    public int Latest() => lista.Last();
    
    public int PersonalBest() => lista.Max();
    
    public List<int> PersonalTopThree()
    {
        lista.Sort();
        lista.Reverse();
        if (lista.Count() > 3)
            {
                lista.RemoveRange(3, lista.Count() - 3);
            }
        return lista;
    }
}