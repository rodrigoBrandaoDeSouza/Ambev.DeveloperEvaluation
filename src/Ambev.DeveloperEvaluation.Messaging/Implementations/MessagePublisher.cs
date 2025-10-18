using Ambev.DeveloperEvaluation.Messaging.Interfaces;

namespace Ambev.DeveloperEvaluation.Messaging.Implementations
{
    public class MessagePublisher : IMessagePublisher
    {
        public Task PublishAsync<TMessage>(TMessage message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
