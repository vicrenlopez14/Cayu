namespace Domain.Exceptions;

public class UnsupportedMessage : Exception
{
    public UnsupportedMessage(String unsupportedType) : base($"Type {unsupportedType} is unsupported.")
    {
    }
}