public delegate void Callback(int node);

public class Program 
{
    public static void Main(string[] args) 
    {
        Graph graph = new();
    
        graph.Add(0, [0, 1, 2]);
        graph.Add(1, [0, 2, 4, 3]);
        graph.Add(2, [0, 1, 3]);
        graph.Add(3, [2, 1]);
        graph.Add(4, [1]);
        
        Dfs(graph, 0, (node) => Console.Write($"{node} "));
    
        List<int> nums = SelectionSort([1, 2, 4, 3, 5], true);
    
        foreach(int num in nums) {
            Console.WriteLine(num);
        }
    }
    
    public static void Bfs(
        Graph graph,
        int start,
        Callback callback) 
    {
        List<int> visited = new();
        Queue<int> queue = new();
        
        queue.Enqueue(start);
        visited.Add(start);
     
        while(queue.Count != 0) 
        {
            int vertex = queue.Dequeue();
            
            callback(vertex);
         
            foreach(int neighbor in graph[vertex]) 
            {
                if(!visited.Contains(neighbor)) 
                {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }
    }
    
    public static void Dfs(
        Graph graph,
        int start,
        Callback callback,
        List<int>? visited = null)
    {
        if(visited == null) {
            visited = new(); 
        }
         
        visited.Add(start);
         
        callback(start);
         
        foreach(int neighbor in graph[start]) {
            if(!visited.Contains(neighbor)) {
                Dfs(graph, neighbor, callback, visited); 
            }
        }
    }
    
    public static List<int> BubbleSort(List<int> nums, bool asc) 
    {
        while(!IsSorted(nums, asc)) 
        {
            for(int i = 1; i < nums.Count; i++) 
            {
                if((asc && nums[i-1] > nums[i]) || (!asc && nums[i-1] < nums[i]))
                {
                    int tmp = nums[i-1];
                    nums[i-1] = nums[i];
                    nums[i] = tmp;
                }
            }
        }
    
        return nums;
    }

    public static List<int> SelectionSort(List<int> nums, bool asc) 
    {
        for(int i = 0; i < nums.Count - 1; i++) 
        {
            int idx = i;

            for(int j = i + 1; j < nums.Count; j++) 
            {
                if(
                    (asc && nums[idx] > nums[j]) 
                    || (!asc && nums[idx] < nums[j]))
                {
                    idx = j;
                }
            }

            int tmp = nums[i];
            nums[i] = nums[idx];
            nums[idx] = tmp;
        }

        return nums;
    }


    public static bool IsSorted(List<int> nums, bool asc) {
        for(int i = 1; i < nums.Count; i++) {
            if(asc) {
                if(nums[i-1] > nums[i]) {
                    return false;
                }
            } else {
                if(nums[i-1] < nums[i]) {
                    return false;
                }
            }
        }
     
        return true;
    }
}
