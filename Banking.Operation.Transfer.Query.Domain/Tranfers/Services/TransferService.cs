using Banking.Operation.Transfer.Query.Domain.Tranfers.Dtos;
using Banking.Operation.Transfer.Query.Domain.Tranfers.Repositories;
using Net.Core.Template.Domain.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Operation.Transfer.Query.Domain.Tranfers.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;

        public TransferService(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task<List<TransferDto>> GetByClient(Guid clientid)
        {
            var transfers = await _transferRepository.GetByClient(clientid);

            if (!transfers.Any())
            {
                throw new BusinessException("Error", "Nenhum registro encontrado!");
            }

            var transfersDto = transfers.Select(x => x.ToDto()).ToList();

            return transfersDto;
        }

        public async Task<TransferDto> GetByClientById(Guid clientid, Guid id)
        {
            var transfer = await _transferRepository.GetByClientById(clientid, id);

            if (transfer is null)
            {
                throw new BusinessException("Error", "Nenhum registro encontrado!");
            }

            return transfer.ToDto();
        }
    }
}