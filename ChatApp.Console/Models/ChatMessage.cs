public class ChatMessage : BaseMessage
{
    public string RoomName{get;set;}
    public ChatMessage(string senderName,string text,string roomName) :base(senderName,text)
    {
        RoomName = roomName;
        MessageType = MessageType.Chat;
    }

    public override string ToString()
    {
        return $"[Room: {RoomName}] {SenderName}: {Text}";
    }

}