using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private SortedDictionary<int, List<string>> lista {get; set;}
    public GradeSchool()
    {
        lista = new SortedDictionary<int, List<string>>();        
    }
    
    public void Add(string student, int grade)
    {
        if (lista.ContainsKey(grade)){
            lista[grade].Add(student);
            lista[grade].Sort();
        }
        else{
            lista.Add(grade, new List<string> {student});            
        }
    }

    public IEnumerable<string> Roster()
    {        
        var list = new List<string>();
        
        foreach (var key in lista){
            list.AddRange(key.Value);
        }
        
        return list;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var list = new List<string>();

        if (lista.ContainsKey(grade)){
            list = lista[grade];
        }

        return list;
    }
}