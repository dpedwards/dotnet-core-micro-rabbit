
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;
using System.Collections.Generic;

namespace MicroRabbit.Banking.Application.Services
{
    /**
     * Account Service class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
