using System.Text;
using System.Runtime.InteropServices;
using System.Text.Json;

public static class PacketSerializer
{
    public static byte[] Serialize(Object obj, string packetType)
    {
        string js = JsonSerializer.Serialize(obj);
        Packet packet = new Packet
        {
            PacketType = packetType,
            JsonPayload = js
        };

        string outerJson = JsonSerializer.Serialize(packet);
        return Encoding.UTF8.GetBytes(outerJson);    
        
    }

    public static (string packetType , string json) Deserialize(byte[] data)
    {
        string json = Encoding.UTF8.GetString(data);
        Packet packet = JsonSerializer.Deserialize<Packet>(json);

        return(packet.PacketType,packet.JsonPayload);
        

    }
}