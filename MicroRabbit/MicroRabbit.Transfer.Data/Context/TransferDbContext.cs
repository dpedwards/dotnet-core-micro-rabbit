using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.TransferData.Context
{
    /**
     * Transfer Database Context
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options): base(options)
        { 
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
