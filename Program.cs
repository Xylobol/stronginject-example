namespace stronginject_example;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("hy world :)");
        var container = new Container();
        container.Run((Bar bar) => Console.WriteLine("The number is " + bar.GetNum()));
    }
}