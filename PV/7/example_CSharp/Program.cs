public delegate Task OnDone(string msg);

public class Program 
{
    public static async Task Main(string[] args)
    {
        Vector v1 = new Vector(1, 2);
        Vector v2 = new Vector(3, 5);

        Console.WriteLine(v1 + v2);
    }

}
