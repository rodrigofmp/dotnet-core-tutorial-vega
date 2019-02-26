using System;
using System.Threading.Tasks;

namespace vega.Core.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}