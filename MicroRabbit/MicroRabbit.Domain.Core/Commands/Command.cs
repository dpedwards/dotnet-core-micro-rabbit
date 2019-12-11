
using MicroRabbit.Domain.Core.Events;
using System;

namespace MicroRabbit.Domain.Core.Commands
{

    /**
     * Command class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public abstract class Command : Message 
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
