// See https://aka.ms/new-console-template for more information
using ChatApp.Console.Models;
using System.Text;
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

        // Json Shekhar part. Chapter 2.1
        // ------------------==================-------------------------------
        // ------------------==================-------------------------------
        System.Console.WriteLine("====JSON===");
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

        // Encoding 2.2
        System.Console.WriteLine("========== ENCODING Chapter 2.2 =========");
        //Task 41
        string normalString = "Ekta game banabo!!";
        byte[] byteString = Encoding.UTF8.GetBytes(normalString);
        foreach(var item in byteString)
        {
            System.Console.Write($"{item} ");
        }
        System.Console.WriteLine();
        string backToNormal = Encoding.UTF8.GetString(byteString);
        System.Console.WriteLine(backToNormal);
        // Task 42

        ChatMessage c1 = new ChatMessage("Kader" , "Koitarina mane bolte parina","roomnai");
        string c1Json = JsonSerializer.Serialize(c1);
        byte[] c1ToBytes = Encoding.UTF8.GetBytes(c1Json);

        foreach(var item in c1ToBytes)
        {
            System.Console.Write($"{item} ");
        }
        System.Console.WriteLine($"Total Bytes in C1 is {c1ToBytes.Length}");

        // Task 43,44 is putting the task 41,42 through a Method!!!!! genericccccaaa
        // voy kortese , kishob shuru korlam egula?
        // miss you "hellu wold"
        //TEsting 43
        ChatMessage testMsg = new ChatMessage("Bostim", "Test 43-44", "Room");
        byte[] bytes = Serializer.ToBytes(testMsg);
        ChatMessage recovered = Serializer.FromBytes<ChatMessage>(bytes);
        Console.WriteLine(recovered.ToString());  
        //Task 47 and 48 Completed by creating Serializeer.cs
        // task 49 ! idid man but u cant seeeeeee!
        // skipping that Task 50! LOL!




    }


        

    
    
}