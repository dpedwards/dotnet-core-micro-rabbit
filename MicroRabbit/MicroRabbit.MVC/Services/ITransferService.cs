using MicroRabbit.MVC.Models.DTO;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
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
        Task Transfer(TransferDto transferDto);
    }
}
