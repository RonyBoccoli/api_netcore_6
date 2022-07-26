using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task<T> InsertAsync(T item);
        Task<T> UpadatetAsync(T item);
        Task<T> DeleteAsync(Guid id);

        Task<T> SelectAsync(Guid id);

        Task<IEnumerable<T>> SelectAsync();

    }
}
