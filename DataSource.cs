namespace stronginject_example;

public class DataSource
{
    private readonly string _epic;

    public DataSource()
    {
        Console.WriteLine("Hello from the DataSource constructor");
        _epic = "this could also be a database connection or something";
    }

    public string GetEpic()
    {
        return _epic;
    }
}