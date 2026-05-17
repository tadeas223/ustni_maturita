public class Logger
{
    private static Logger? instance;

    public static Logger Instance {
        get {
            if(instance == null) 
            {
                instance = new Logger();
            }

            return instance!;
        }
    }

    private Logger() {}

    public void Print(string msg)
    {
        Console.WriteLine(msg);
    }
}
