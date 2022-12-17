namespace stronginject_example;

public class Foo
{
    public Foo(DataSource dataSource)
    {
        Console.WriteLine("Hello from the Foo constructor");
        Console.WriteLine("Epic is " + dataSource.GetEpic());
    }
}