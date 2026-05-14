using System.Net;
using System.Net.Sockets;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("[0] server, [1] client");
        
        bool isServer = false;
        while(true)
        {
            try
            {
                int num = int.Parse(Console.ReadLine()!);
                
                switch(num)
                {
                    case 0:
                        isServer = true;
                        break;
                    case 1:
                        isServer = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            } 
            catch
            {
                Console.WriteLine("Not A Number");
            }

            
            if(isServer)
            {
                Server();
            }
            else
            {
                Client();
            }
        }
    }

    public static void Server()
    {
        var listener = new TcpListener(IPAddress.Any, 1234);

        listener.Start();

        while(true)
        {
            TcpClient client = listener.AcceptTcpClient();

            NetworkStream stream = client.GetStream();
            
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            
            writer.WriteLine("Hello from server");
            
            writer.Flush();

            while(client.Connected)
            {
                string? line = reader.ReadLine();
                if(line == null)
                {
                    break;
                }

                writer.WriteLine($"you wrote: {line}");
            
                writer.Flush();
            }

            client.Close();
        }
    }
    
    public static void Client()
    {
        using TcpClient client = new TcpClient("127.0.0.1", 1234);

        NetworkStream stream = client.GetStream();
        
        StreamReader reader = new StreamReader(stream);
        StreamWriter writer = new StreamWriter(stream);
        
        while(client.Connected)
        {
            Console.WriteLine(reader.ReadLine());

            writer.WriteLine(Console.ReadLine());

            writer.Flush();
        }
    }
}
