public class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.Get(i));
        }
        
        Console.WriteLine("remove:");
        list.Remove(2);
        
        for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.Get(i));
        }
    }
}
