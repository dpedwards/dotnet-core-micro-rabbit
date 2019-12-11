using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
    /**
     * Event Message class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
