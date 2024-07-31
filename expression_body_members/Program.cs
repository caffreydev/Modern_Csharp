
var money = new Money(10);
Console.WriteLine(money);
try
{
    money.Value = -100;
}
catch (Exception)
{
    Console.WriteLine("Can't set the value to a  negative number.");
}

money.Value = 100;

Console.WriteLine(money);

class Money
{
    private decimal value;

    public decimal Value
    {
        get => value;
        set => SetValue(value);
    }

    public Money(decimal value) => SetValue(value);

    private void SetValue(decimal newValue) => value = newValue >= 0 ? newValue : throw new Exception();

    public string AsString => "$" + value;

    public override string ToString() => $"Your money is {AsString}";
}

