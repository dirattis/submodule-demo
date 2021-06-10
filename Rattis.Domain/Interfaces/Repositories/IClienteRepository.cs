using Rattis.Investments.Domain.Entities;
using Rattis.Investments.Domain.Interfaces.Repositories.Base;

namespace Rattis.Investments.Domain.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        string GetCPFWithOnlyNumbers(int id);
    }
}
