public class Fraction
{
    private int _top;
    private int _bottom;

    /// Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {            
        _top = top;
        _bottom = bottom;
    }

    //Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
        _top = top;
    }

    public int getBottom()
    {
        return _bottom;
    }
    public int setBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Methods
    public string GetFractionString()
    {
    }
    public double GetDecimalValue()
    {

    }
}
