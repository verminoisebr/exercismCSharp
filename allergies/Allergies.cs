using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int score { get; set; }
    public Allergies(int mask)
    {
        score = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (score & (int)allergen) > 0;        
    }

    public Allergen[] List()
    {
        var allergenValues = Enum.GetValues(typeof(Allergen));
        return ((Allergen[]) allergenValues)
        .Where(x => (((int)x & score) > 0))
        .ToArray();
    }
}