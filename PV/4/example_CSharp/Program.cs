public delegate void Callback(int node);
public delegate void DoneCallback();

public class Graph : Dictionary<int, List<int>>;

public class Program 
{
    public static void Main(string[] args)
    {
        Graph graph = new();
        
        graph.Add(0, [1]);
        graph.Add(1, [0, 3]);
        graph.Add(2, []);
        graph.Add(3, [0, 1]);
        
        bool done = false;
        Task t = WorkAsync(() => {Console.WriteLine("work done"); done = true;});
     
        Dfs(graph, 0, (node) => Console.WriteLine($"found: {node}"));

        while(!done){}
    }

    public static async Task WorkAsync(DoneCallback callback)
    {
        await Task.Delay(1000);
        callback();
    }

    public static void Dfs(Graph graph, int start, Callback callback, List<int>? visited = null)
    {
        if(visited == null)
        {
            visited = new List<int>();
        }
        
        visited.Add(start);

        callback(start);

        foreach(int neighbor in graph[start])
        {
            if(!visited.Contains(neighbor))
            {
                Dfs(graph, neighbor, callback, visited);
            }
        }
    }
}
