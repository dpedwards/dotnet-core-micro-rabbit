
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Application.Interfaces;
using System.Collections.Generic;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Application.Services
{
    /**
     * Transfer Service class
     * 
     * @author D. P. Edwards
     * @license MIT
     * @version 1.0
     */
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
