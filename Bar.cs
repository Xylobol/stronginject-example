namespace stronginject_example;

public class Bar
{
    private readonly int _someNumber;
    
    public Bar(Foo foo)
    {
        Console.WriteLine("Hello from the Bar constructor");
        Console.WriteLine("The guid is " + foo.GetGuid());
        _someNumber = 536;
    }

    public int GetNum()
    {
        return _someNumber;
    }
}