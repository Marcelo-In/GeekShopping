namespace GeekShopping.MessageBus
{
    public interface IMessageBus
    {
        Task PubliicMessage(BaseMessage message, string queueName);
    }
}