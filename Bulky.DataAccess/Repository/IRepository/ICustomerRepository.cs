using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        void Update(Customer obj);
    }
}
