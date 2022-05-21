using Banking.Operation.Transfer.Query.Domain.Tranfers.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banking.Operation.Transfer.Query.Domain.Tranfers.Repositories
{
    public interface ITransferRepository
    {
        Task<IEnumerable<TransferEntity>> GetByClient(Guid clientid);

        Task<TransferEntity> GetByClientById(Guid clientid, Guid id);
    }
}