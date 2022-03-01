using Domain.Entities;

namespace Domain.Events;

public class MessageDeletedEvent
{
    public MessageDeletedEvent(Message message)
    {
        Message = message;
    }

    public Message Message { get; set; }
}