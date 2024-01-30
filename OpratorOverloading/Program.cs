

Money m1 = new Money(10);
Money m2 = new Money(20);
Money m3 = new Money(30);


Console.WriteLine($"Money m1 : ${m1.Amount}, Money m2 : ${m2.Amount}");
Money m4 = m1 + m2 + m3;
Console.WriteLine(m4.Amount);

Console.ReadKey();
public class Money
{
    private decimal _amount;
    public decimal Amount => _amount;

    public Money(decimal value)
    {
        this._amount = Math.Round(value);
    }


    // Overload Arthmatic opratores (Binary ==> work with tow values)

    // Addition
    public static Money operator +(Money a, Money b)
    {

        var value = a.Amount + b.Amount;

        return new Money(value);
    }

    //Subtraction
    public static Money operator -(Money a, Money b)
    {
        var value = a.Amount - b.Amount;
        return new Money(value);
    }

    //Multiplication
    public static Money operator *(Money a, Money b)
    {
        var value = a.Amount * b.Amount;
        return new Money(value);
    }


    //Boolean Opratores

    //Gratter than
    public static bool operator >(Money a, Money b)
    {
        return a.Amount > b.Amount;
    }

    // Less than
    public static bool operator <(Money a, Money b)
    {
        return a.Amount < b.Amount;
    }

    // Gratter than or equal
    public static bool operator >=(Money a, Money b)
    {
        return a.Amount >= b.Amount;
    }

    //Less than or equal
    public static bool operator <=(Money a, Money b)
    {
        return a.Amount <= b.Amount;
    }

    // Is equal
    public static bool operator ==(Money a, Money b)
    {
        return a.Amount == b.Amount;
    }

    // Is not equal
    public static bool operator !=(Money a, Money b)
    {
        return a.Amount != b.Amount;
    }

    // Unary (Work with one value)


    // Decrement
    public static Money operator ++(Money a)
    {
        var value = a.Amount;
        return new Money(++value);
    }

    // Increament
    public static Money operator --(Money a)
    {
        var value = a.Amount;
        return new Money(--value);
    }
}