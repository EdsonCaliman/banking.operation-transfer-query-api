using Banking.Operation.Transfer.Query.Domain.Tranfers.Entities;
using Banking.Operation.Transfer.Query.Domain.Tranfers.Repositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Banking.Operation.Receipt.Consumer.Infra.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        protected IMongoCollection<TransferEntity> Collection { get; private set; }

        public TransferRepository(IMongoDatabase database)
        {
            Collection = database.GetCollection<TransferEntity>("Receipts");
        }

        public async Task<IEnumerable<TransferEntity>> GetByClient(Guid clientid)
        {
            return await Collection.Find(m => m.ClientId == clientid)
                .ToListAsync();
        }

        public async Task<TransferEntity> GetByClientById(Guid clientid, Guid id)
        {
            return await Collection.Find(m => m.ClientId == clientid && m.ReceiptId == id)
                .FirstOrDefaultAsync();
        }
    }
}