using Banking.Operation.Transfer.Query.Domain.Tranfers.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banking.Operation.Transfer.Query.Domain.Tranfers.Services
{
    public interface ITransferService
    {
        Task<List<TransferDto>> GetByClient(Guid clientid);

        Task<TransferDto> GetByClientById(Guid clientid, Guid id);
    }
}