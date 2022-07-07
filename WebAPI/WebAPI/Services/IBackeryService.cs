using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Entity;

namespace WebAPI.Services
{
    public interface IBackeryService
    {
        Task<IEnumerable<IBackery>> CreateItems(int count);

        Task<IEnumerable<IBackery>> GetAllItems();
    }
}