using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction (int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denomitaor)
    {
        _numerator = numerator;
        _denominator = denomitaor;
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public void GetDecimalString()
    {
        double fractionDecimal = (double)_numerator / (double)_denominator;
        Console.WriteLine($"{fractionDecimal}");
    }






}