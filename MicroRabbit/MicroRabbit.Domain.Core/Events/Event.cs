using System;

namespace MicroRabbit.Domain.Core.Events
{

    /**
     * Event class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
