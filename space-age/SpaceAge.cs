using System;

public class SpaceAge
{
    double year;
    public SpaceAge(int seconds)
    {
        year = Convert.ToDouble(seconds) / 31557600;        
    }

    public double OnEarth()
    {
        return year * 1.0;
    }

    public double OnMercury()
    {
        return year / 0.2408467;
    }

    public double OnVenus()
    {
        return year  / 0.61519726;
    }

    public double OnMars()
    {
        return year / 1.8808158;
    }

    public double OnJupiter()
    {
        return year / 11.862615;
    }

    public double OnSaturn()
    {
        return year / 29.447498;
    }

    public double OnUranus()
    {
        return year / 84.016846;
    }

    public double OnNeptune()
    {
        return year / 164.79132;
    }
}