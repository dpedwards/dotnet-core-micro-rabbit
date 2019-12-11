
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroRabbit.Banking.Domain.Models
{
    /**
     * Account Model class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AccountBalance { get;  set; }
    }
}
