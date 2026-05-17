using System.Net;
using System.Net.Sockets;
using System;
using System.Text;


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
                BerkleyServer();
            }
            else
            {
                BerkleyClient();
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

    public static void BerkleyServer()
    {
        Socket server = new Socket(
            SocketType.Stream,
            ProtocolType.Tcp
        );

        server.Bind(new IPEndPoint(IPAddress.Any, 1234));
    
        server.Listen(3);

        while(true)
        {
            Socket client = server.Accept();
            
            
            while(client.Connected)
            {
                byte[] buffer = new byte[1024];
                int received = client.Receive(buffer);
                
                string request = Encoding.UTF8.GetString(buffer);
                byte[] response = Encoding.UTF8.GetBytes($"you wrote: {request}");

                client.Send(response);
            }
        }
    }
    
    public static void BerkleyClient()
    {
        Socket client = new Socket(
            SocketType.Stream,
            ProtocolType.Tcp
        );

        client.Connect(
            new IPEndPoint(
                new IPAddress(
                    new byte[] {127, 0, 0, 1}
                ), 
                1234
            )
        );
        
        
        while(client.Connected)
        {
            byte[] response = Encoding.UTF8.GetBytes(Console.ReadLine()!);

            client.Send(response);
            
            byte[] buffer = new byte[1024];
            int received = client.Receive(buffer);
            
            string request = Encoding.UTF8.GetString(buffer);

            Console.WriteLine(request);

        }
    }
}
