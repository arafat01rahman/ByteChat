public class SystemMessage : BaseMessage
{
    public string EventType{get;set;}
    public SystemMessage(string senderName,string text,string eventType) :base(senderName,text)
    {
        EventType = eventType;
        MessageType = MessageType.System;
    }

    public override string ToString()
    {
        return $"** {SenderName} has {EventType} the chat **";
    }

}