public class Fraction
{
    private int _top;
    private int _bottom;

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
    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }
    public int GetTopNumber()
    {
        return _top;
    }
    public int GetBottomNumber()
    {
        return _bottom;
    }
    public void SetTopNumber(int topNumber)
    {
        _top = topNumber;
    }
    public void SetBottomNumber(int bottomNumber)
    {
        _bottom = bottomNumber;
    }
    public void Display()
    {
        Console.WriteLine(_top);
        Console.WriteLine(_bottom);
    }
    public string GetFractionString()
    {
        string fractionString = _top + "/" + _bottom;
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double _doubleTop = _top;
        double _doubleBottom = _bottom;
        double decimalValue = _doubleTop / _doubleBottom;
        return decimalValue;
    }
}
