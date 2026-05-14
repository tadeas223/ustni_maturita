public class Program
{
    public static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("test.txt"))
        {
            writer.WriteLine("file");
        }
    }
}
