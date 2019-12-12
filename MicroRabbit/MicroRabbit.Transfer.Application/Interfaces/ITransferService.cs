
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    /**
     * Transfer Service interface
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
