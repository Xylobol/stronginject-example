namespace stronginject_example;

public class Bar
{
    private readonly int _someNumber;
    
    public Bar(DataSource dataSource)
    {
        Console.WriteLine("Hello from the Bar constructor");
        Console.WriteLine("Epic is " + dataSource.GetEpic());
        _someNumber = 536;
    }

    public int GetNum()
    {
        return _someNumber;
    }
}