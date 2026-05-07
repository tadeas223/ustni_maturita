class Program {
    static void Main(string[] args) {
            
        int sum1 = Sum(1, 1);
        
        int sum2 = 0;
        SumRef(ref sum2, 1, 1);
        
        Console.WriteLine($"sum1 = {sum1}, sum2 = {sum2}");

        UserRepository repo = new UserRepository();
        User user = repo.GetUserById(1);
        
        Console.WriteLine(user);

        repo.UpdateUser(ref user);

        Console.WriteLine(user);
    }
    
    static int Sum(int x, int y) {
        return x + y;
    }
    
    static void SumRef(ref int result, int x, int y) {
        result = x + y;
    }
    
    static void Swap<T>(ref T a, ref T b) {
        T tmp = a;
        a = b;
        b = a;
    }
}
