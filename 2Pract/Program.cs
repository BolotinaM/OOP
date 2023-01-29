public readonly struct Result
{
    private readonly int f;
    private readonly int s;

    public Result(int first, int second)
    {
        f = first;
        s = second;
    }

    public static Result operator *(Result a, Result b)
        => new Result(a.f * b.f, a.s * b.s);

public override string ToString() => $"NewPoint ({f} , {s})";
}

public static class OperatorOverloading
{
    public static void Main()
    {
        var a = new Result(1, 2);
        var b = new Result(4, 1);

         Console.WriteLine(a * b); 
    }
}