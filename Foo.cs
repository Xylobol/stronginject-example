namespace stronginject_example;

public class Foo
{
    private readonly string _someGuid;
    
    public Foo(DataSource dataSource)
    {
        Console.WriteLine("Hello from the Foo constructor");
        Console.WriteLine("Epic is " + dataSource.GetEpic());
        _someGuid = Guid.NewGuid().ToString();
    }

    public string GetGuid()
    {
        return _someGuid;
    }
}