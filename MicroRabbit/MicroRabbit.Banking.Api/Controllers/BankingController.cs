
using System.Collections.Generic;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    /**
     * Banking api controller
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }
    }
}
