
using MicroRabbit.Transfer.Domain.Models;
using System.Collections.Generic;

namespace MicroRabbit.Transfer.Domain.Interfaces
{

    /**
     * Transfer Repository interface
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */ 
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
