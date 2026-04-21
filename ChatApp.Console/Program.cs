// See https://aka.ms/new-console-template for more information
using ChatApp.Console.Models;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        User user1 = new User("Bostim", 289988);
        User user2 = new User("Chiro", 289982);

        System.Console.WriteLine($"{user1.Username} -> ID:{user1.UserId} is now Online:{user1.IsOnline}");
        System.Console.WriteLine($"{user2.Username} -> ID:{user2.UserId} is now Online:{user2.IsOnline}");

        Server server = new Server("MainServer");
        server.PrintStatus();

        // Create three Message objects with different content
            Message message1 = new Message("Kakka", "-_-");
            Message message2 = new Message("Mama", "How's it going?");
            Message message3 = new Message("Jaaanss", "Ailabiu");

            // Print the messages in the required format
            System.Console.WriteLine(message1);
            System.Console.WriteLine(message2);
            System.Console.WriteLine(message3);
    }
}