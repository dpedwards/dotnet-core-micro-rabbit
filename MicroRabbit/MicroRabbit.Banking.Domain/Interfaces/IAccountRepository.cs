

using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Domain.Interfaces
{

    /**
     * Account Repository interface
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
