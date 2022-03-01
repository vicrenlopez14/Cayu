using Domain.Common;
using Domain.Entities;

namespace Domain.Events;

public class MessageSentEvent : DomainEvent
{
    public MessageSentEvent(Message message)
    {
        Message = message;
    }

    public Message Message { get; set; }
}