public class Server
{
    public string ServerName{get; set;}
    public Server(string servername)
    {
        ServerName = servername;
    }
    public void PrintStatus()
    {
        System.Console.WriteLine($"Server {ServerName} is runnng");
    }
}