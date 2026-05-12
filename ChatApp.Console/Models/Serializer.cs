using System;
using System.Text;
using System.Text.Json;


static class Serializer
{
    public static byte[] ToBytes<T>(T obj) where T : class
    {
        string ObjToJson = JsonSerializer.Serialize(obj);
        return Encoding.UTF8.GetBytes(ObjToJson);
        
    }

    public static T FromBytes<T>(byte[] data) where T : class
    {
        string json = Encoding.UTF8.GetString(data);
        return JsonSerializer.Deserialize<T>(json);
    } 
}