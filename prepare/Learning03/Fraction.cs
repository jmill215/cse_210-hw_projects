using System;
using System.Diagnostics;
using System.Dynamic;

public class Fraction
{
    private int _top;

    private int _bottom;

    //Fraction() Methods
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Get FractionString and DecimalValue
    
    public string GetFractionString()
    {
        //return: String of current fraction
        string text_fraction = ($"{_top}/{_bottom}");
        return text_fraction;
    }

    public double GetDecimalValue()
    {
        //return decimal of a fraction (divide instead of writeline)
        double DecimalValue = (double)_top / (double)_bottom;
        return DecimalValue;
    }

    
}