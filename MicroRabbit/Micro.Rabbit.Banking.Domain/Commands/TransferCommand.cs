using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    /**
     * Transfer Command class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
