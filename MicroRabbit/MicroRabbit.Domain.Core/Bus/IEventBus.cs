using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{

    /**
     * Event Bus interface
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
