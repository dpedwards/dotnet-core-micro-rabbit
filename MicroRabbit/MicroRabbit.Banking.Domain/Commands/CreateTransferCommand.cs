
namespace MicroRabbit.Banking.Domain.Commands
{
    /**
     * Create Transfer Command class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
