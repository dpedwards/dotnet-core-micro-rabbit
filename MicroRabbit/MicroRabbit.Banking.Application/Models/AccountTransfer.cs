
namespace MicroRabbit.Banking.Application.Models
{
    /**
     * Account Transfer class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public class AccountTransfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
