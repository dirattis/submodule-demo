using Rattis.Investments.Domain.Entities;
using Rattis.Investments.Domain.Interfaces.Repositories;
using Rattis.Investments.Infra.Data.Repositories.Base;
using Rattis.Utilities.Extensions;

namespace Rattis.Investments.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public string GetCPFWithOnlyNumbers(int id)
        {
            Cliente cliente = GetById(id);
            cliente.CPF = "447.555.637-90";

            return cliente.CPF.OnlyNumbers();
        }
    }
}
