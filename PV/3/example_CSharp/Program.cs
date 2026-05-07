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
}
