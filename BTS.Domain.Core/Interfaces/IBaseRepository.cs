using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS.Domain.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetItemByIdAsync(int Id);
        Task<T> AddItemAsync(T item);
        Task<IEnumerable<T>> GetItemsAsync();
        Task<T> UpdateItemAsync(T itemChanges);
        Task<bool> DeleteItemByIdAsync(int Id);
    }
}
