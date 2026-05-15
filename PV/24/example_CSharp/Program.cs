using System.Diagnostics;

public class MyException : Exception {
    public MyException(string msg) : base(msg) {}
}
public class MyException2 : Exception {
    public MyException2(string msg) : base(msg) {}
}

public class Program
{
    public static void Main(string[] args)
    {
        Debug.Assert(1 == 2, "aserce");
        try
        {
            try
            {
                TestFunkce2(true);
            }
            catch(MyException e)
            {
                Console.WriteLine("inner");
                Console.WriteLine(e.Message);
            }
        }
        catch(MyException2 e)
        {
            Console.WriteLine("outer try");
            Console.WriteLine(e.Message);
        }
    }

    public static void TestFunkce(bool thr)
    {
        if(thr)
        {
            throw new MyException("Error");
        }
    }
    
    public static void TestFunkce2(bool thr)
    {
        if(thr)
        {
            throw new MyException2("Error");
        }
    }
}
