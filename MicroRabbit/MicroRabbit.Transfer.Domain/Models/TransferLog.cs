
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbit.Transfer.Domain.Models
{
    /**
     * Transfer Log class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */
    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount {get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TransferAmount { get;  set; }
    }
}
