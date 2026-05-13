public class Graph : Dictionary<int, List<int>> {}

public class Program 
{
    public static void Main(string[] args)
    {

        Console.WriteLine("fibonacci: " + Fibonacci(5));
        Console.WriteLine("factorial: " + Factorial(5));

        Graph graph = new();
        graph.Add(0, [0, 1, 2]);
        graph.Add(1, [0, 2, 4, 3]);
        graph.Add(2, [0, 1, 3]);
        graph.Add(3, [2, 1]);
        graph.Add(4, [1]);
        
        Dfs(graph, 0);

        Console.WriteLine("brute force:");
        Console.WriteLine($"code is {BruteForce()}");
        
        Console.WriteLine("heuristika:");
        Console.WriteLine($"code is {Heuristika()}");
        
        Console.WriteLine("monte carlo:");
        Console.WriteLine($"code is {MonteCarlo()}");
    }

    public static int Fibonacci(int n)
    {
        if(n == 0) 
        {
            return 0;
        }

        return n + Fibonacci(n - 1);
    }

    public static int Factorial(int n)
    {
        if(n == 1) 
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }

    public static void Dfs(Graph graph, int start, List<int>? visited = null) 
    {
        if(visited == null) 
        {
            visited = new(); 
        }

        Console.WriteLine($"found: {start}");

        visited.Add(start);

        foreach(int neighbor in graph[start])
        {
            if(!visited.Contains(neighbor)) 
            {
                Dfs(graph, neighbor, visited);
            }
        }
    }
   
    public static string? BruteForce()
    {
        for(int i = 0; i < 9999; i++)
        {
            string code = i.ToString("D4");
            if(CheckCode(code))
            {
                return code;
            }

        }

        return null;
    }
   
    public static string? MonteCarlo()
    {
        Random rnd = new Random();
        for(int i = 0; i < 10000; i++)
        {
            string code = rnd.Next(9999).ToString("D4");
            if(CheckCode(code))
            {
                return code;
            }

        }

        return null;
    }
   
    public static string? Heuristika()
    {
        for(int i = 0; i < 9999/2; i++)
        {
            string code = (i*2).ToString("D4");
            if(CheckCode(code))
            {
                return code;
            }

        }

        return null;
    }

    public static bool CheckCode(string code)
    {
        if(code == "1234")
        {
            return true;
        }

        return false;
    }
}
