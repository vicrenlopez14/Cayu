using Domain.Entities;

namespace Domain.Events;

public class MessageReceivedEvent
{
    public MessageReceivedEvent(Message message)
    {
        Message = message;
    }

    public Message Message { get; set; }
}