using System;

public class Fraction
{
    //Attributes
    private int _top;
    private int _bottom;

    //Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int GetTopNumber()
    {
        return _top;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

    //Methods

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;

    }
}
