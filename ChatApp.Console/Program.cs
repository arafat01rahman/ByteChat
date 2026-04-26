// See https://aka.ms/new-console-template for more information
using ChatApp.Console.Models;
using System.Text.Json;

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

        // Json Shekhar part. 
        // ------------------==================-------------------------------
        // ------------------==================-------------------------------

        string JsonString1 = JsonSerializer.Serialize(user1);
        System.Console.WriteLine(JsonString1);
        
        // Deserialize 
        User deserializedJson = JsonSerializer.Deserialize<User>(JsonString1);
        System.Console.WriteLine(deserializedJson.Username);

        // Task 37: Serialize and Deserialize a ChatMessage object
        ChatMessage chatMessage = new ChatMessage("Alice", "Hello there", "General");

        // Serialize the ChatMessage to JSON
        string chatMessageJson = JsonSerializer.Serialize(chatMessage);
        Console.WriteLine("\nSerialized ChatMessage JSON: ");
        Console.WriteLine(chatMessageJson);

        // Deserialize the ChatMessage JSON back to an object
        ChatMessage deserializedChatMessage = JsonSerializer.Deserialize<ChatMessage>(chatMessageJson);
        Console.WriteLine($"Deserialized ChatMessage - Sender: {deserializedChatMessage.SenderName}, Text: {deserializedChatMessage.Text}, Room: {deserializedChatMessage.RoomName}");

        // Task 38: Serialize and Deserialize a List  ChatMessage objects
        List<ChatMessage> chatMessages = new List<ChatMessage>
        {
            new ChatMessage("Kalu", "Hello Kakka", "General"),
            new ChatMessage("Dholu", "Hi, Kakka!", "General"),
            new ChatMessage("Kakka", "Good evening everyone!", "General")
        };

        // Serialize
        string chatMessagesJson = JsonSerializer.Serialize(chatMessages, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("\nSerialized List of ChatMessages JSON: ");
        Console.WriteLine(chatMessagesJson);

        // Deserialize 
        List<ChatMessage> deserializedChatMessages = JsonSerializer.Deserialize<List<ChatMessage>>(chatMessagesJson);

        //print each message
        Console.WriteLine("\nDeserialized List of ChatMessages: ");
        foreach (var message in deserializedChatMessages)
        {
            Console.WriteLine(message.ToString());
        }
    }
}