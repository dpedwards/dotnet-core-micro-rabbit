using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    /**
     * Banking Database Context
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options): base(options)
        { 
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
