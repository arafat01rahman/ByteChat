public class BaseMessage
{
    public string SenderName {get; set;}
    public string Text {get;set;}
    public DateTime SentAt{get;set;}
    public MessageType MessageType { get; set; }

    public BaseMessage(string senderName,string text)
    {
        SenderName = senderName;
        Text = text ;
        SentAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"[{SentAt:HH:mm}] {SenderName}: {Text}";
    }
}

