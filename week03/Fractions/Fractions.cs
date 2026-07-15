using System;
using System.Diagnostics;

class Fractions
{
    private int _top;
     private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }
    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int  GetTop()
    {
        return _top;
    }
    public void  SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetDecimalValue()
    {
        double speed =(double)_top/(double)_bottom;
        Console.WriteLine($"{speed}");
    }
}