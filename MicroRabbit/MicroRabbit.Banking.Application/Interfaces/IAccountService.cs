
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Interfaces
{
    /**
     * Account Service interface
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
